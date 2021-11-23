using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Scores : MonoBehaviour
{
    public GameOverScreen gameover;
    public LevelComplete complete;
    public Text change_items_used;
    public Text LevelName;
    public int items_used = 0;
    private int scores; 
    private int max_scores;
    private int min_items;
   // User user;
    // public int total_cells;
    // public int total_cells_covered;
    Area area;

    void Start()
    {
        change_items_used.text = items_used.ToString();
        area = GameObject.FindGameObjectWithTag("Level").GetComponent<Area>();
      //  user = GameObject.FindGameObjectWithTag("Player").GetComponent<User>();
        
        // print(PlayerPrefs.GetInt("value"));
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            LevelName.text="LEVEL 1";
            PlayerPrefs.SetInt("currlevel", 1);
            max_scores= 50;
            min_items=5;
         }
        else if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            LevelName.text="LEVEL 2";
            PlayerPrefs.SetInt("currlevel", 2);
            max_scores= 50;
            min_items=3;
        }
        else if(SceneManager.GetActiveScene().buildIndex == 4)
        {
            LevelName.text="LEVEL 3";
            PlayerPrefs.SetInt("currlevel", 3);
            max_scores= 50;
            min_items=4;
        }
        else if(SceneManager.GetActiveScene().buildIndex == 5)
        {
            LevelName.text="LEVEL 4";
            PlayerPrefs.SetInt("currlevel", 4);
            max_scores= 60;
            min_items=9;
        }
        else if(SceneManager.GetActiveScene().buildIndex == 6)
        {
            LevelName.text="LEVEL 5";
            PlayerPrefs.SetInt("currlevel", 5);
            max_scores= 60;
            min_items=9;
        }
        scores = max_scores;
    }



    public void newItemUsedCheck(){
        if(items_used > min_items) {
            scores=max_scores - 10*(items_used - min_items);
        }
        if(scores<=0) GameOver();
    }

    public void areaCoveredCheck(){
        if(area.check_area()) StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("Completed!!");
        yield return new WaitForSeconds(2);
        Win();
    }

    public void GameOver(){
        gameover.Setup();
    }

    public void Win(){
        int currlevel = PlayerPrefs.GetInt("currlevel");
        if(currlevel == 1 && PlayerPrefs.GetInt("level1score") < scores){
           PlayerPrefs.SetInt("level1score", scores);
        }else if(currlevel == 2 && PlayerPrefs.GetInt("level2score") < scores){
           PlayerPrefs.SetInt("level2score", scores);
        }else if(currlevel == 3 && PlayerPrefs.GetInt("level3score") < scores){
           PlayerPrefs.SetInt("level3score", scores);
        }else if(currlevel == 4 && PlayerPrefs.GetInt("level4score") < scores){
           PlayerPrefs.SetInt("level4score", scores);
        }if(currlevel == 5 && PlayerPrefs.GetInt("level5score") < scores){
           PlayerPrefs.SetInt("level5score", scores);
        }
        if(PlayerPrefs.GetInt("level") == currlevel) PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
        complete.levelComplete(scores);
    }
}