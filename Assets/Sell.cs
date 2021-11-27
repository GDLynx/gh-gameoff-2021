using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.EventSystems;

public class Sell : MonoBehaviour, IPointerClickHandler
{
    public Global globals; 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    
     public void OnPointerClick(PointerEventData eventData) { 
         Debug.Log("Sell"); 
         // globals.bugs 
         // globals.money 
         // if (globals.bugs >= 100) { // replace 100 with globals.maxBugsAmount 
         // may need to change this to a formula 
            globals.money += Random.Range(1, 20); // perhaps this should be multiplied by the number of "sales" 
            globals.money -= globals.bugs; 
         // } 
         if (globals.money < -100) {
             globals.bloodPressure += 0.01f; // globals.bloodPressure += Math.sign(globals.money); // ... 
         }
     } 
}
