using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System.Collections; 

public class ButtonColor : MonoBehaviour {
    public void ResetColor() {
        /*
        timer += 0.1f; 
        if (timer >= 1f) {
            GetComponent<Graphic>().color = Color.white;             
            timer = 0; 
        }       
        Debug.Log(GetComponent<Timer>().incrementing % 3 == 0); 
        if (GetComponent<Timer>().incrementing % 3 == 0) {
            Debug.Log("RESET COL"); 
        }
        */ 
    }
    /* 
    public IEnumerator ChangeColor(float price) {
        if (globals.money < GetComponent<Buyable>().price) { // [refactor] this check is done inside Buyable too 
            GetComponent<Graphic>().color = Color.red;             
        } 
        if (globals.money >= GetComponent<Buyable>().price) {
            GetComponent<Graphic>().color = Color.green;             
        }           
        yield return new WaitForSeconds(1); 
        GetComponent<Graphic>().color = Color.white;             
     }
     */ 

     public void ChangeColorToRed() {
         GetComponent<Graphic>().color = Color.red; 
         StartCoroutine(ChangeColorToWhite()); 
    } 
    public void ChangeColorToGreen() {
         GetComponent<Graphic>().color = Color.green; 
         StartCoroutine(ChangeColorToWhite()); 
    } 
    public IEnumerator ChangeColorToWhite() {
        yield return new WaitForSeconds(1); 
        GetComponent<Graphic>().color = Color.white; 
        Debug.Log("HI"); 
    }
} 

/* 
public class ButtonColor : MonoBehaviour {
    float timer = 0; 
    /* 
    public void Update() { 
        foreach(GameObject buyable in GameObject.FindGameObjectsWithTag("Buyable")) {
            Debug.Log(buyable.gameObject.GetComponent<MonoBehaviour>().price); 
        } 
        // Debug.Log(GameObject.FindGameObjectsWithTag("Buyable").GetComponent<MonoBehaviour>().price); 
    } 
    *  
    public void Update() {
        timer += 0.1f; 
        if (timer >= 1f) {
            GetComponent<Graphic>().color = Color.white;             
            timer = 0; 
        }       
    } 
    public void ChangeColor(float price) {
        timer = 0; 
        if (globals.money < GetComponent<Buyable>().price) { // [refactor] this check is done inside Buyable too 
            GetComponent<Graphic>().color = Color.red;             
        } 
        if (globals.money >= GetComponent<Buyable>().price) {
            GetComponent<Graphic>().color = Color.green;             
        }         
    }
} */ 