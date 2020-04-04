using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopupController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text txtScorePanel;
    public Button btnReturn;
    public Button btnExit;
    void Start()
    {
        btnReturn.onClick.AddListener(()=>returnGame());
        btnExit.onClick.AddListener(()=>returnMenu());
    }

    void returnGame(){
        gameObject.SetActive(false);
    }

    void returnMenu(){
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
