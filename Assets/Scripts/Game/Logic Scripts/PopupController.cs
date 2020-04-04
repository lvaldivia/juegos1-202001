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

    private GameObject controller;
    private GameController gameController;
    void Start()
    {
        controller = GameObject.Find("GameController");
        gameController = controller.GetComponent<GameController>();
        btnReturn.onClick.AddListener(()=>returnGame());
        btnExit.onClick.AddListener(()=>returnMenu());
    }

    void returnGame(){
        gameController.startGame();
    }

    void returnMenu(){
        Time.timeScale = 1f;
        btnReturn.onClick.RemoveAllListeners();
        btnExit.onClick.RemoveAllListeners();
        SceneManager.LoadScene("Menu");
    }
}
