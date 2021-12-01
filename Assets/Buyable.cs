using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class Buyable : MonoBehaviour
{
    public Global globals; 
    public float price; 
    public bool bought; 

    public void Buy() {
        if (globals.money >= price && !bought) {
            // StartCoroutine(GetComponent<ButtonColor>().ChangeColor()); // [refactor] may halt script 
            GetComponent<ButtonColor>().ChangeColorToGreen();
            globals.money -= price; 
            bought = true; 
        }         
        if (globals.money < price) {
            GetComponent<ButtonColor>().ChangeColorToRed();
        }
    } 
} 

