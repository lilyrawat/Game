using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    void Start()
    {
        // sets level to 1 
        PlayerPrefs.SetInt("level", 1);

        // sets all level scores to 0
        PlayerPrefs.SetInt("level1score", 0);
        PlayerPrefs.SetInt("level2score", 0);
        PlayerPrefs.SetInt("level3score", 0);
        PlayerPrefs.SetInt("level4score", 0);
        PlayerPrefs.SetInt("level5score", 0);
    }

    
}
