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
   // User user;
    int level;

    void Start()
    {
        
        if(PlayerPrefs.GetInt("level") == 0){
            PlayerPrefs.SetInt("level", 1);
        }
        level = PlayerPrefs.GetInt("level");

        //shows pointer on current level
        pointer[level-1].SetActive(true);
      
        // buttons
        Button btn1 = levels[0].GetComponent<Button>(); 
        Button btn2 = levels[1].GetComponent<Button>(); 
        Button btn3 = levels[2].GetComponent<Button>(); 
        Button btn4 = levels[3].GetComponent<Button>(); 
        Button btn5 = levels[4].GetComponent<Button>(); 

        // button event listeners 
        btn1.onClick.AddListener( level1 );
        btn2.onClick.AddListener( level2 );
        btn3.onClick.AddListener( level3 );
        btn4.onClick.AddListener( level4 );
        btn5.onClick.AddListener( level5 );
        
        // level scores
        if(PlayerPrefs.GetInt("level1score") == 0) scores[0].text = "Not available";
        else scores[0].text = "Score: " + PlayerPrefs.GetInt("level1score");
        
        if(PlayerPrefs.GetInt("level2score") == 0) scores[1].text = "Not available";
        else scores[1].text = "Score: " + PlayerPrefs.GetInt("level2score");

        if(PlayerPrefs.GetInt("level3score") == 0) scores[2].text = "Not available";
        else scores[2].text = "Score: " + PlayerPrefs.GetInt("level3score");

        if(PlayerPrefs.GetInt("level4score") == 0) scores[3].text = "Not available";
        else scores[3].text = "Score: " + PlayerPrefs.GetInt("level4score");

        if(PlayerPrefs.GetInt("level5score") == 0) scores[4].text = "Not available";
        else scores[4].text = "Score: " + PlayerPrefs.GetInt("level5score");
    }

    // methods associated with buttons
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

    // opens the level scene
    void levelProcider(int clicked){
        if(level < clicked){
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
