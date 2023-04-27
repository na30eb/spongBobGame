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
        NewGame();
    }
    public void NewGame(){
        scoreplus=0;

    }

    // Update is called once per frame
    void Update()
    {

        //scoreplus=scoreplus+5;
        //scoreText.text=Mathf.FloorToInt(scoreplus).ToString();
    }
    


}
