using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class UpgradeWorker : MonoBehaviour, IPointerClickHandler
{
    public Global globals; 
    public float price; 
    public bool bought; 
    public float bugRemovePercentageIncrease; 

    // Update is called once per frame
    void Update()
    {
    } 

     public void OnPointerClick(PointerEventData eventData) {
         Buy(); 
    } 
    public void Buy() {
        if (globals.money >= price && !bought) {
            globals.money -= price; 
            bought = true; 
            GameObject[] objs ;
            objs = GameObject.FindGameObjectsWithTag("Worker");
            foreach(GameObject worker in objs) {
                worker.GetComponent<Worker>().bugRemovePercentage += bugRemovePercentageIncrease;  
            }
        } 
    }
}
