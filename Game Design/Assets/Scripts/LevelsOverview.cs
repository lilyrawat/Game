using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsOverview : MonoBehaviour
{
  
    // pop up panel
    public GameObject popUp;

    // array of score texts
    public Text[] scores = new Text[5];

    // array of buttons
    public Button[] levels = new Button[5];

    // array of pointer gameobjects
    public GameObject[] pointer = new GameObject[5];

    // script
    User user;

    void Start()
    {
        // accesses the currLevel script
        user = GameObject.FindGameObjectWithTag("Level").GetComponent<User>();
      
        //shows pointer on current level
        pointer[user.level-1].SetActive(true);
      
        Button btn1 = levels[0].GetComponent<Button>(); 
        Button btn2 = levels[1].GetComponent<Button>(); 
        Button btn3 = levels[2].GetComponent<Button>(); 
        Button btn4 = levels[3].GetComponent<Button>(); 
        Button btn5 = levels[4].GetComponent<Button>(); 

        btn1.onClick.AddListener( level1 );
        btn2.onClick.AddListener( level2 );
        btn3.onClick.AddListener( level3 );
        btn4.onClick.AddListener( level4 );
        btn5.onClick.AddListener( level5 );
        
        for(int i=0;i<5;i++){
          if(user.scores[i] != 0){
              scores[i].text= "Score: " + user.scores[i].ToString();
          }
        }
    }

    void level1(){
        levelProcider(1);
    }
    void level2(){
        levelProcider(2);
    }
    void level3(){
        levelProcider(3);
    }
    void level4(){
        levelProcider(4);
    }
    void level5(){
        levelProcider(5);
    }

    
    void levelProcider(int clicked){
        if(user.level < clicked){
            print("level is locked!!!");
            //shows popup of locked levels
            StartCoroutine(popup());
        }else{
            // opens clicked level
            print("level available!!!");
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+clicked);
        }
    }
    // pop up method for locked levels
    IEnumerator popup(){
            popUp.SetActive(true);
            yield return new WaitForSeconds(3);
            popUp.SetActive(false);
        
    }
}
