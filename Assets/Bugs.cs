using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bugs : StatusIndicator
{
    float timer = 0; 
    protected void Update() {
        base.Update(); 
        timer += 0.01f;  
        if (timer >= 60) {
            globals.bugs +=  Random.Range(0.01f, 0.04f); 
            timer = 0; 
        } 
    }
    public override void onFull() {
        // globals.money 
        Debug.Log("Too many bugs"); 
    } 
}
