using UnityEngine; 
using UnityEngine.UI; 
public class BloodPressure : StatusIndicator { 
    private float pumpTimer = 0; 
    private bool grow; 
    public Image outline; 
    [SerializeField]
    private float sizeChange; 
    public void Update() { 
        base.Update(); 
        if (status >= 0.70f) {
            pumpTimer += 0.1f; 
            Debug.Log(pumpTimer); 
            if (pumpTimer > 0.5f) {
                grow = !grow; 
                pumpTimer = 0f; 
            } 
            if (grow) {
                statusBar.rectTransform.sizeDelta = new Vector2(statusBar.rectTransform.rect.width + sizeChange, statusBar.rectTransform.rect.height + sizeChange); 
                outline.rectTransform.sizeDelta = new Vector2(outline.rectTransform.rect.width + sizeChange, statusBar.rectTransform.rect.height + sizeChange); 
            } else {
                statusBar.rectTransform.sizeDelta = new Vector2(statusBar.rectTransform.rect.width - sizeChange, statusBar.rectTransform.rect.height - sizeChange); 
                outline.rectTransform.sizeDelta = new Vector2(outline.rectTransform.rect.width - sizeChange, statusBar.rectTransform.rect.height - sizeChange); 
            }
        }
    }

    public override void onFull() {
        Debug.Log("Blood pressure is too high"); 
    }
} 