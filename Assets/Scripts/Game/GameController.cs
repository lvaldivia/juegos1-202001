using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float timeElapsed = 0f;
    [Header("Obstacles Prefabs")]
    public List<GameObject> elements = new List<GameObject>();
    public float startX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= 1f) {
            GameObject ga = Instantiate(getNext(), new Vector3(startX, 0.0f, 1.0f), Quaternion.identity);
            ga.transform.localScale = new Vector3(0.5f, 0.5f, 1.0f);
            timeElapsed = 0;
        }   
    }

    GameObject getNext() {
        int index = Random.Range(0, elements.Count - 1);
        return elements[index];
    }
}
