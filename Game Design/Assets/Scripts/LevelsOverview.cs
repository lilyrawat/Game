using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsOverview : MonoBehaviour
{
    // // Start is called before the first frame update
    // public Button level1;
    // public Button level2;
    // public Button level3;
   //  public Button level3; 
   public GameObject currLevelIndicator;
   public GameObject popUp;
   //public GameObject item;
   public Text[] scores = new Text[5];
    public Button[] levels = new Button[5];
    public Vector3[] positionsOfButtons = new Vector3[]{new Vector3(-8.99f, 0.33f,0f), new Vector3(-5.35f, 2.17f, 0f), new Vector3(-1.93f, 0.21f, 0f),  new Vector3(1.7f, 2.18f, 0f), new Vector3(5.94f, -0.09f, 0f), };
    
     CurrLevel result;
    void Start()
    {
        result = GameObject.FindGameObjectWithTag("Level").GetComponent<CurrLevel>();
        //int level = result.level;
      // if(GameObject.FindGameObjectWithTag("indicator")) Destroy(GameObject.FindGameObjectWithTag("indicator"));
        GameObject a = Instantiate(currLevelIndicator, positionsOfButtons[result.level-1] , Quaternion.identity) as GameObject;
       // a.tag = "indicator";
       
	// Button btn = levels[level-1].GetComponent<Button>(); //Grabs the button component
	// btn.onClick.AddListener( clickFunction ); //Adds a listner on the button
      // StartCoroutine(popup(level));
      
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
        // for(int i=1;i<=level;i++){
        //     if(i==1){
        //         btn1.onClick.AddListener( unlockedLevel );
        //     }else if(i==1){
        //         btn2.onClick.AddListener( unlockedLevel );
        //     }else if(i==1){
        //         btn3.onClick.AddListener( unlockedLevel );
        //     }else if(i==1){
        //         btn4.onClick.AddListener( unlockedLevel );
        //     }else if(i==5){
        //         btn5.onClick.AddListener( unlockedLevel );
        //     }
        // }

        // for(int i=level+1;i<=5;i++){
        //     if(i==1){
        //         btn1.onClick.AddListener( lockedLevel );
        //     }else if(i==1){
        //         btn2.onClick.AddListener( lockedLevel );
        //     }else if(i==1){
        //         btn3.onClick.AddListener( lockedLevel );
        //     }else if(i==1){
        //         btn4.onClick.AddListener( lockedLevel );
        //     }else if(i==5){
        //         btn5.onClick.AddListener( lockedLevel );
        //     }
        // }
    }

    // Update is called once per frame
    void Update()
    { 
        for(int i=0;i<5;i++){
          if(result.scores[i] != 0){
              //print(result.scores[i]);
              scores[i].text= "Score: " + result.scores[i].ToString();
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

    void lockedLevel(){
         int level = result.level;
       print("button pressed");
        StartCoroutine(popup());
    }
    void levelProcider(int clicked){
        if(result.level < clicked){
            lockedLevel();
        }else{
            print("level available!!!");
        }
    }
    IEnumerator popup(){
             print("level == 1");
            popUp.SetActive(true);
            yield return new WaitForSeconds(3);
            popUp.SetActive(false);
        
    }
}
