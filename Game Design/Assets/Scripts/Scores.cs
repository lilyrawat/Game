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
    public int scores; 
    public int max_scores;
    public int min_items;
    public int total_cells;
    public int total_cells_covered;
    Area area;

    void Start()
    {
        change_items_used.text = items_used.ToString();
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            area = GameObject.FindGameObjectWithTag("Level").GetComponent<Area>();
            LevelName.text="LEVEL 1";
            max_scores= 50;
            min_items=5;
            scores=max_scores;
         }
        else if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            area = GameObject.FindGameObjectWithTag("Level").GetComponent<Area>();
            LevelName.text="LEVEL 2";
            max_scores= 50;
            min_items=3;
            scores=max_scores;
        }
        else if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            area = GameObject.FindGameObjectWithTag("Level").GetComponent<Area>();
            LevelName.text="LEVEL 3";
            max_scores= 50;
            min_items=4;
            scores=max_scores;
        }
        else if(SceneManager.GetActiveScene().buildIndex == 4)
        {
            area = GameObject.FindGameObjectWithTag("Level").GetComponent<Area>();
            LevelName.text="LEVEL 4";
            max_scores= 60;
            min_items=9;
            scores=max_scores;
        }
        else if(SceneManager.GetActiveScene().buildIndex == 5)
        {
            area = GameObject.FindGameObjectWithTag("Level").GetComponent<Area>();
            LevelName.text="LEVEL 5";
            max_scores= 60;
            min_items=9;
            scores=max_scores;
        }
        
    }

    void Update()
    {
        if(scores<=0){
            GameOver();
        }
    }

   public void check_area1(){
        total_cells=area.positions.Count;
        total_cells_covered = 0;
        for(int i=0;i<total_cells;i++){
            Vector2 pointA = new Vector2(area.positions[i].x - 0.13f, area.positions[i].y - 0.13f); 
            Vector2 pointB = new Vector2(area.positions[i].x + 0.13f, area.positions[i].y + 0.13f);
            if(Physics2D.OverlapArea(pointA, pointB)) total_cells_covered++;
            // if (Physics2D.OverlapCircle(area.positions[i], radius, layerMask)) total_cells_covered++;
        }
        if(total_cells_covered==total_cells) StartCoroutine(ExampleCoroutine());
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
        complete.levelComplete(scores);
    }
}