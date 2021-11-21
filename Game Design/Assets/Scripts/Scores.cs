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
    float radius=0.025f;
    int layerMask=1;

    void Start()
    {
        change_items_used.text = items_used.ToString();
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            area = GameObject.FindGameObjectWithTag("Level").GetComponent<Area>();
            LevelName.text="LEVEL 1";
            max_scores= 50;
            min_items=4;
            scores=max_scores;
         }
        else if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            area = GameObject.FindGameObjectWithTag("Level").GetComponent<Area>();
            LevelName.text="LEVEL 2";
            max_scores= 55;
            min_items=4;
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
            if (Physics2D.OverlapCircle(area.positions[i], radius, layerMask)) total_cells_covered++;
        }
        if(total_cells_covered==total_cells) Win();
    }

    public void GameOver(){
        gameover.Setup();
    }

    public void Win(){
        complete.levelComplete(scores);
    }
}

