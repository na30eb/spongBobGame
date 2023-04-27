using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus : MonoBehaviour
{
   private float rightEdge;

    private void Start() {
        rightEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).y-20f;
    }
    
    public void Update()
    {
        transform.position += Vector3.up * Time.deltaTime;

        if (transform.position.x < rightEdge) {
            Destroy(gameObject);
        }   
    }
}
