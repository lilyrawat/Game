using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{   
    private Vector2 screenPoint;
    private Vector3 offset;
    Scores level;
  
    void Start(){
        level = GameObject.FindGameObjectWithTag("Player").GetComponent<Scores>();
    }
    void OnMouseOver(){
        if(Input.GetKey(KeyCode.N)){
            print(this);
            transform.rotation *= Quaternion.Euler(Vector3.forward * 1);
            level.areaCoveredCheck();
         }
         if(Input.GetKey(KeyCode.M)){
            transform.rotation *= Quaternion.Euler(Vector3.forward * -1);
            level.areaCoveredCheck();
         }
         if(Input.GetKey(KeyCode.Backspace)){
            Destroy(gameObject);
            level.items_used--;
            // if(level.items_used>level.min_items) level.scores=level.scores+10;
            // Debug.Log(level.scores);
            level.newItemUsedCheck();
            level.change_items_used.text = level.items_used.ToString();
            level.areaCoveredCheck();
        }
    }

    void OnMouseDrag()
    {
        Vector2 curPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) ;
        transform.position = curPosition;
        level.areaCoveredCheck();
    }
}
