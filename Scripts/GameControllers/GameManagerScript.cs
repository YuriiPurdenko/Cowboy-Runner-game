using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{


    [SerializeField] Button pauseButton, resumeButton, menuButton;
    [SerializeField] Text pauseText, scoreText;
    [SerializeField] GameObject pausePanel;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 1f;
        StartCoroutine(CountScore());
        scoreText.text = score + "M";
    }



    IEnumerator CountScore(){
        yield return new WaitForSeconds(0.6f);
        score++;
        scoreText.text = score + "M"; 
        StartCoroutine(CountScore());
    }
   
    void OnEnable() {
        PlayerDiedScript.gameOver += playerDiedEndTheGame;
    }
    void OnDisable() {
        PlayerDiedScript.gameOver -= playerDiedEndTheGame;
    }



    void playerDiedEndTheGame(){
        if(!PlayerPrefs.HasKey("Score")){
            PlayerPrefs.SetInt("Score",0);
        }
        else{
            int highScore = PlayerPrefs.GetInt("Score");
            if(score > highScore){
                PlayerPrefs.SetInt("Score",score);
            }
        }

        gameOver();
    }

    public void pause(){
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        pauseText.text = "Pause";
        resumeButton.onClick.RemoveAllListeners();
        resumeButton.onClick.AddListener(() => resume());
    }
    void gameOver(){
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        pauseText.text = "Game Over";
        resumeButton.onClick.RemoveAllListeners();
        resumeButton.onClick.AddListener(() => restart());
    }

    void resume(){
         pausePanel.SetActive(false);
         Time.timeScale = 1f;
    }

    void restart(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("GamePlay");
    }
    public void goToMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}
