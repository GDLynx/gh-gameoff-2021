using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bugs : StatusIndicator
{
    [SerializeField]
    float timer = 0; 

    [SerializeField]
    float iterations = 0; 
    protected void Update() {
        base.Update(); 
        timer += 0.01f;  
        if (iterations > 5 && iterations % 70 == 0) {
            if (globals.bugs < 10) {
                globals.money += 3f; 
            }
        }
        if (iterations <= 120) {
            if (timer >= Random.Range(0.05f, 1f)) {
                globals.bugs +=  Random.Range(0.02f, 0.04f); 
                if (globals.bugs > 0.1) {
                    globals.money += 0.055f / globals.bugs; 
                } else {
                    globals.money += 0.055f; 
                }
                timer = 0; 
                iterations += 1; 
            } 
        } else {
            if (timer >= Random.Range(0.07f, 1.2f)) {
                globals.bugs +=  Random.Range(0.05f, 0.4f); 
                globals.money += 0.12f / globals.bugs; 
                timer = 0; 
                iterations += 1; 
            } 
        }
        /* 
        if (globals.money < 0) {
           globals.bloodPressure += 0.1f; 
        }
        */ 
        if (globals.bugs > 0.99) {
               globals.bloodPressure += 0.004f; 
        } 
    }
    public override void onFull() {
        // globals.money 
        Debug.Log("Too many bugs"); 
    } 
}
