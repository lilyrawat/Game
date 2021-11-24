using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    //Load Game 
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
    }
    //Levels overview scene 
    public void levels(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
   //To quit the game
    public void QuitGame(){
        Debug.Log("Quit!");
        Application.Quit();
    }

}
