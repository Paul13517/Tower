using UnityEngine;
using UnityEngine.UI;

public class TrackImage : DefaultTrackableEventHandler {

    public Sprite foundSprite, notFoundSprite; 
    public Image image; 

    public void changeTrackImage(bool isTracking) {
         if(isTracking)
             image.sprite = foundSprite;
         else  
             image.sprite = notFoundSprite;
    }

    protected override void OnTrackingFound() {
        base.OnTrackingFound();
        changeTrackImage(true);
    }

    protected override void OnTrackingLost() {
        base.OnTrackingFound();
        changeTrackImage(false);
    }
}
