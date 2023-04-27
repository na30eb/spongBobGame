using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class calculation : MonoBehaviour
{
    public static int scoreValue=0;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        score=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text=scoreValue.ToString();
        if(scoreValue<0){
            GameManager.Instance.GameOver();
            score.text="gameover";
        }
    }
}
