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
    public float timer = 0; 

    // Update is called once per frame
    void Update()
    {
        timer += 0.1f; 
        if (timer > 1 && !bought) {
            GetComponent<Graphic>().color = Color.white; 
        }
    } 

     public void OnPointerClick(PointerEventData eventData) {
         Buy(); 
    } 
    public void Buy() {
        timer = 0; 
        if (globals.money < price) {
            GetComponent<Graphic>().color = Color.red; 
        }
        if (globals.money >= price && !bought) {
            globals.money -= price; 
            bought = true; 
            GameObject[] objs ;
            objs = GameObject.FindGameObjectsWithTag("Worker");
            foreach(GameObject worker in objs) {
                worker.GetComponent<Worker>().bugRemovePercentage += bugRemovePercentageIncrease;  
            }
            GetComponent<Graphic>().color = Color.green; 
        } 
    }
}
