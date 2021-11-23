using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public Text pointsText;

    public void NextLevel(){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
    }

    public void levelComplete(int score, int max_scores){
        gameObject.SetActive(true);
        pointsText.text = "Score: "+score.ToString()+" / "+ max_scores.ToString();
    }
}
