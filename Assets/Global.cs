using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Global")]
public class Global : ScriptableObject
{
    public float money; 
    public float bugs; 
    public float bloodPressure; 
    // may introduce a range (array of 2) called "bugIncreaseRate" 

    public float GetStatus(StatusIndicator obj) {
        // [refactor] I suspect I may be able to do something like the JS "list[eval(variableName)]" trick to avoid using switch statement 
        switch(obj.GetType().Name) {
            case "Bugs":
                return bugs; 
            case "BloodPressure":
                return bloodPressure; 
            default: 
                return 0f; 
        } 
    } 
} 
