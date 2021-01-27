using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDiedScript : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void endGame();
    public static event endGame gameOver;

    void playerDied(){
        if(gameOver != null){
            gameObject.SetActive(false);
            gameOver();
        }

    }
    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "zombie"){
            playerDied();
            
        }    
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Collector"){
            playerDied();
            
        }    
    }

}
