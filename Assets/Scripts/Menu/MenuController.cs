using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [Header("Button Variables")]
    public Button btnPlay;
    public Button btnAchivements;
    void Start()
    {
        btnPlay.onClick.AddListener(() => goGame());
        btnAchivements.onClick.AddListener(() => goAchivements());
    }

    void goGame() {
        SceneManager.LoadScene("Game");
    }

    void goAchivements() {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
