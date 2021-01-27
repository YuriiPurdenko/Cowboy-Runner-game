using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{


    [SerializeField]
    GameObject[] obstacles;

    List<GameObject> spawnerObstacles = new List<GameObject>();

    // Start is called before the first frame update
   
    void Awake(){
        initializeObstacles();
        shuffel();
    }
   
    void Start()
    {
        StartCoroutine(spawnRandomObstacle());
    }


    void initializeObstacles(){
        int index = 0;
        for(int i = 0 ; i < obstacles.Length * 3; i++){
            GameObject obj = Instantiate(obstacles[index], new Vector3(transform.position.x,transform.position.y,2), Quaternion.identity) as GameObject;
            spawnerObstacles.Add(obj);
            spawnerObstacles[i].SetActive(false);
            index++;
            if(index == obstacles.Length){
                index = 0;
            }
        }
    }




    void shuffel(){
        for(int i = 0 ; i < spawnerObstacles.Count; i++){
            GameObject temp = spawnerObstacles[i];
            int random = Random.Range(0,spawnerObstacles.Count);
            spawnerObstacles[i] = spawnerObstacles[random];
            spawnerObstacles[random] = temp;
        }
    }

    IEnumerator spawnRandomObstacle(){
        yield return new WaitForSeconds(Random.Range(1.5f, 4.5f));

        int random  = Random.Range(0,spawnerObstacles.Count);
        while(true){
            if(!spawnerObstacles[random].activeInHierarchy){
                spawnerObstacles[random].SetActive(true);
                spawnerObstacles[random].transform.position = new Vector3(transform.position.x, transform.position.y, 2);
                break;
            }
            else{
                random = Random.Range(0,spawnerObstacles.Count);
            }    
        }
        StartCoroutine(spawnRandomObstacle());
    }



}
