using UnityEngine; 
using UnityEngine.UI; 
using System.Collections; 
public class BloodPressure : StatusIndicator { 
    public GameObject heartExplode; 
    private float pumpTimer = 0; 
    private bool grow; 
    public Image outline; 
    [SerializeField]
    private float sizeChange; 
    public void Update() { 
        base.Update(); 
        if (status >= 0.70f) {
            pumpTimer += 0.1f; 
            // log spamming
            // Debug.Log(pumpTimer); 
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
        // base.onFull(); 
        outline.color = new Color(outline.color.r, outline.color.g, outline.color.b, 0f); 
        heartExplode.SetActive(true); 
        // ideally this should make the [heart] UI element invisible 
        transform.position = new Vector2(transform.position.x - 10000f, transform.position.y - 10000);     
        StartCoroutine(Replay()); 
    } 

    IEnumerator Replay() {
        Debug.Log("Relay"); 
        yield return new WaitForSeconds(1); 
        // should probably display a death screen here with proper text 
        Application.LoadLevel(Application.loadedLevel); 
    }
} 