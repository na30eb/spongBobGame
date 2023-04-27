using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class score : MonoBehaviour
{


    void OnMouseDown()
    {
        calculation.scoreValue += 2;
        Destroy(gameObject);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    
        
    }
}
