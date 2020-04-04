using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour
{
    // Start is called before the first frame update
    private float height;
    private float width;
    void Start()
    {
        height = Camera.main.orthographicSize * 2f;
        width = height * Screen.width / Screen.height;
        if (gameObject.name == "Background")
        {
            transform.localScale = new Vector3(width, height, 1);
        }
        else {
            transform.localScale = new Vector3(width+10f, 5f, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
