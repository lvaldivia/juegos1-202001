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

    void Awake(){
        controller = GameObject.Find("GameController");
        gameController = controller.GetComponent<GameController>();
    }

    void Start()
    {
        btnReturn.onClick.AddListener(()=>returnGame());
        btnExit.onClick.AddListener(()=>returnMenu());
    }

    private void OnEnable() {
        txtScorePanel.text = gameController.getScore();
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
