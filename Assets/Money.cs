using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI; 

[RequireComponent(typeof(Global))] 
public class Money : MonoBehaviour
{
    public Global globals; 
    public Text moneyText;  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "$"+globals.money.ToString();    
    }
}
