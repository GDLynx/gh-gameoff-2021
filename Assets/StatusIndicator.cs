using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.EventSystems;
public abstract class StatusIndicator : MonoBehaviour 
{
    public Image statusBar; // [refactor] may rename this 
    public Global globals; 
    float status, max = 100; 
    float lerpSpeed; 

    // Start is called before the first frame update
    void Start()
    {
        // status = 0.1f; 
        statusBar.fillAmount = 0;  
    }

    // Update is called once per frame
    protected void Update()
    {
        status = globals.GetStatus(this); 
        statusBar.fillAmount = status; // status.global_value; // which could be bloodpressure, or bugs 
        if (status >= max) {
            status = max; 
            onFull(); 
        } 
    } 

    public void IncreaseStatus(float amount) {
        status += amount; 
    } 
    public void DecreaseStatus(float amount) {
        status -= amount; 
    }  

    // not sure if there should be a method here which checks if the status bar is full and [for example] ends the game 
    public virtual void onFull() {
        Debug.Log("Status bar is full"); 
    } 
}

