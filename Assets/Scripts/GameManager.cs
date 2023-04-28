using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    //public TextMeshProUGUI scoreText;
    public float scoreplus =0;
    private Spawner spawner;
    public Button retryButton;


    private void Awake() {
    if (Instance == null) {
        Instance = this;
    } else {
        DestroyImmediate(gameObject);
    }
  }

  private void onDestroy() {
    if (Instance == this) {
        Instance = null;
    }
  }

    
    // Start is called before the first frame update
    void Start()
    {
        spawner = FindObjectOfType<Spawner>();
        NewGame();
    }
    public void NewGame(){
        
        calculation.scoreValue=0;
        spawner.gameObject.SetActive(false);

        retryButton.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        //scoreplus=scoreplus+5;
        //scoreText.text=Mathf.FloorToInt(scoreplus).ToString();
    }
    
    public void GameOver() {

    enabled = false;

    //spawner.gameObject.SetActive(false);
    Destroy(this);
    //gameOverText.gameObject.SetActive(true);
    retryButton.gameObject.SetActive(true);
    //UpdateHiScore();
  }
    


}
