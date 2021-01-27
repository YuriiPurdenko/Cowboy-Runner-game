using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollectorScript : MonoBehaviour
{
    // Start is called before the first frame update
   void OnTriggerEnter2D(Collider2D other) {
       if(other.tag == "obstacle" || other.tag == "zombie"){
           other.gameObject.SetActive(false);
       }
   }
}
