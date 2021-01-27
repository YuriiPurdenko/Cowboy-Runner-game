using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScale : MonoBehaviour
{
    
    void Start(){
        float height = Camera.main.orthographicSize * 2f;
        float width = height * Screen.width / Screen.height;


        if(gameObject.tag == "BackGround"){
            transform.localScale = new Vector3(width,height,0);
        }
        else if(gameObject.tag == "Ground"){
            transform.localScale = new Vector3(width + 3f,5,0);
        }
    }

}
