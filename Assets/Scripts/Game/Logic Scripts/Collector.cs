using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider2D collider2D;
    private List<string> tags = new List<string>(){"Enemy","Zombie"};
    void Start()
    {
        collider2D = GetComponent<BoxCollider2D>();
        collider2D.isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D other) {
        GameObject ga = other.gameObject;
        if(tags.IndexOf(ga.tag) > -1){
            ga.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
