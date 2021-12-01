using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class Automator : MonoBehaviour, IPointerClickHandler
{
    public Global globals; 
    public float price; 
    public bool bought; 
    public GameObject worker; 
    float timer = 0; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (bought) { 
            worker.GetComponent<Worker>().Buy(); 
        } 
    } 

     public void OnPointerClick(PointerEventData eventData) {
         Buy(); 
    } 
    public void Buy() {
        GetComponent<Buyable>().Buy(); 
    }
}
