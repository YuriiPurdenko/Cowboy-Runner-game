using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D myRb;

    [SerializeField]
    float forwardSpeed = -3f;
    void Awake(){
        myRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     myRb.velocity = new Vector2(forwardSpeed,0f);   
    }
}
