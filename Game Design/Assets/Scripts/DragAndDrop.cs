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
        // for rotating to the right
        if(Input.GetKey(KeyCode.N)){
            print(this);
            transform.rotation *= Quaternion.Euler(Vector3.forward * 1);
            level.areaCoveredCheck();
         }
         // for rotating to the left
         if(Input.GetKey(KeyCode.M)){
            transform.rotation *= Quaternion.Euler(Vector3.forward * -1);
            level.areaCoveredCheck();
         }
         // for deleting an item
         if(Input.GetKey(KeyCode.Backspace)){
            Destroy(gameObject);
            level.items_used--;
            level.newItemUsedCheck();
            level.change_items_used.text = level.items_used.ToString();
            level.areaCoveredCheck();
        }
    }

    // for moving the items
    void OnMouseDrag()
    {
        Vector2 curPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) ;
        transform.position = curPosition;
        level.areaCoveredCheck();
    }
}
