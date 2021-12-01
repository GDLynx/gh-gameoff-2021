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
    // Start is called before the first frame update
    public float timer = 0; 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bought) { 
            worker.GetComponent<Worker>().Buy(); 
        } 
        timer += 0.1f; 
        if (timer > 1) {
            GetComponent<Graphic>().color = Color.white; 
        }
    } 

     public void OnPointerClick(PointerEventData eventData) {
         Buy(); 
    } 
    public void Buy() {
        timer = 0; 
        if (globals.money >= price && !bought) {
            globals.money -= price; 
            bought = true; 
        }         
        if (globals.money >= price) {
            GetComponent<Graphic>().color = Color.green; 
        }
        if (globals.money < price) {
            GetComponent<Graphic>().color = Color.red; 
        }
    }
}
