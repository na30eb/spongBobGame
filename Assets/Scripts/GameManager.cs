using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    float score ;

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
        score=0;

    }

    // Update is called once per frame
    void Update()
    {
        score += score * Time.deltaTime;

    }

}
