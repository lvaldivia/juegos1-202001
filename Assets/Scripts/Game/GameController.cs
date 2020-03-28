using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float timeElapsed = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= 1f) {
            print("se crea enemigo");
            timeElapsed = 0;
        }
        
    }
}
