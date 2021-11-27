using UnityEngine; 
public class BloodPressure : StatusIndicator { 
    public override void onFull() {
        Debug.Log("Blood pressure is too high"); 
    }
} 