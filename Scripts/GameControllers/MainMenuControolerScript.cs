using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControolerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake() {
      Time.timeScale = 1f;   
    }
    public void playGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
