using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    //Scores
    public Text pointsText;

    //Will Load next build index scene 
    public void NextLevel(){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
    }
    
    //Set active the levelComplete gameobject and Show scores out of the maximum scores for the level. 
    public void levelComplete(int score, int max_scores){
        gameObject.SetActive(true);
        pointsText.text = "Score: "+score.ToString()+" / "+ max_scores.ToString();
    }
}
