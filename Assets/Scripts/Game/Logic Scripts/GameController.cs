using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    
    [Header("Obstacles Prefabs")]
    public List<GameObject> elements = new List<GameObject>();
    [Header("Start position element")]
    public float startX;
    [Header("HUD")]
    public Button btnStart;
    public Button btnPause;
    public Text txtScore;
    public GameObject popupPause;

    private List<GameObject> pool = new List<GameObject>();
    private float generationTime = 4f;
    private float scoreTime = 0f;
    private float timeElapsed = 0f;
    void Start()
    {
        popupPause.SetActive(false);
        btnStart.gameObject.SetActive(false);
        btnStart.onClick.AddListener(() => startGame());
        btnPause.onClick.AddListener(()=> pauseGame());
        generatePoolObjects();
    }

    void generatePoolObjects() {
        int scale = 1;
        for (int i=0;i< elements.Count;i++) {
            for (int j=0;j< elements.Count; j++) {
                GameObject ga = Instantiate(elements[i], new Vector3(startX, 0.0f, 1.0f), Quaternion.identity);
                scale = ga.tag == "Enemy" ? 1 : -1;
                ga.transform.localScale = new Vector3(0.5f*scale, 0.5f, 1.0f);
                ga.SetActive(false);
                pool.Add(ga);
            }
        }
    }
        
    public void startGame() {
        Time.timeScale = 1f;
        popupPause.SetActive(false);
        btnPause.gameObject.SetActive(true);
        btnStart.gameObject.SetActive(false);
    }

    public string getScore(){
        return scoreTime.ToString();
    }

    void pauseGame() {
        popupPause.SetActive(true);
        Time.timeScale = 0f;
        btnPause.gameObject.SetActive(false);
        btnStart.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        scoreTime += Time.deltaTime;
        txtScore.text = scoreTime.ToString();
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= generationTime) {
            timeElapsed = 0f;
            GetFirstDead();
        }   
    }

    void GetFirstDead() {
       while(true){
           print("getFirstDead");
           int index = Random.Range(0,pool.Count);
           if(!pool[index].activeInHierarchy){
               print("Become active");
               pool[index].SetActive(true);
               pool[index].transform.position 
                            = new Vector3(transform.position.x,transform.position.y,0);
                break;
           }else{
               index = Random.Range(0,pool.Count);
           }
       }
    }

    GameObject getNext() {
        int index = Random.Range(0, elements.Count - 1);
        return elements[index];
    }
}
