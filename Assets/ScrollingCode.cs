using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class ScrollingCode : MonoBehaviour
{
    [SerializeField]
    private Sprite[] sprites = new Sprite[2]; 
    public Image image; 

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>(); 
        RandomSprite(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 600) {
            RandomSprite(); 
            transform.position = new Vector3(transform.position.x, -500, transform.position.z); 
        }        
        transform.position = new Vector3(transform.position.x, transform.position.y + 3, transform.position.z); 
    }

    void RandomSprite() {
        Debug.Log("SPRITE"); // IS NEVER LOGGED 
        image.sprite = sprites[Random.Range(0, sprites.Length)]; 
        image.enabled = true; 
    } 
}

