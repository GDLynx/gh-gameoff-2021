using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
[RequireComponent(typeof(Global))] 
public class Worker : MonoBehaviour 
{
    public Text priceText; 
    public float price; 
    public Text bugRemovePercentageText; // [refactor] may change to "bugRemovalPercentage" 
    public float bugRemovePercentage; 
    public Button button; 
    public Image progressBar; 
    float progress, maxProgress = 50;
    public float progressPoint; 
    bool canUpdateProgress; 
    public Global globals; 

    float lerpSpeed; 

    // Start is called before the first frame update
    void Start()
    {
        progress = 0; 
        progressBar.fillAmount = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        priceText.text = "$"+price.ToString(); 
        bugRemovePercentageText.text = bugRemovePercentage.ToString()+"%"; 
        HandleProgress(); 
    }  

    public void Buy() { 
        // increase progressBar 
        if (globals.money >= price && !canUpdateProgress) { 
            globals.money -= price; 
            price += 0.0001f; 
            priceText.text = "$"+price.ToString(); 
            progress = 0; 
            canUpdateProgress = true; 
            if (globals.bugs > 0) {
                globals.bugs -= bugRemovePercentage; 
            } else {
                globals.bugs = 0; 
            }
        }
    } 

    public void HandleProgress() {
        if (canUpdateProgress) {
            UpdateProgress(); 
        } 
        if (progress >= 1) {
            canUpdateProgress = false; 
        }
    } 
    public void UpdateProgress() { 
        progress += progressPoint; 
        progressBar.fillAmount = progress;         
    } 

    // when I introduce an "Worker adder" object, the adder will need to set the position of the objects that its creating 
    public void SetPosition(float x, float y) { 
        transform.position = new Vector3(x, y, this.transform.position.z); 
    }
}
