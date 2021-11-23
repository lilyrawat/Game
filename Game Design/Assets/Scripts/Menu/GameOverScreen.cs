using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    //Will set GameOverScreen gameobject active. 
    public void Setup(){
        gameObject.SetActive(true);
    }

    //Will Reload the scene with the same index. 
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
