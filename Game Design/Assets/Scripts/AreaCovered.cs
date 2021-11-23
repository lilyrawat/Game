using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCovered : MonoBehaviour
{
     List<Vector2> positions = new List<Vector2>();
     int total_cells;
     int total_cells_covered;
    //In list, we are storing all the points in the area to be covered. Points are accessed through the tagname Area.
    void Start()
    {
        var objects = GameObject.FindGameObjectsWithTag("Area");
        foreach (var gameObject in objects) 
        {
            //Storing the points in positions List.
            positions.Add(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y));
        }

    }

    //Function to check area is filled or not. 
    public bool check_area(){
        total_cells=positions.Count;
        total_cells_covered = 0;
        for(int i=0;i<total_cells;i++){
            //Taking two diagonal points of the sqaure and then checking if the area is overlapping with shapes or not. 
            Vector2 pointA = new Vector2(positions[i].x - 0.125f, positions[i].y - 0.125f); 
            Vector2 pointB = new Vector2(positions[i].x + 0.125f, positions[i].y + 0.125f);
            if(Physics2D.OverlapArea(pointA, pointB)) total_cells_covered++;
        }
<<<<<<< Updated upstream
        //Checking if all the points are covered. 
        if(total_cells_covered==total_cells) return true;
=======
        if(total_cells_covered==total_cells) return true; 
>>>>>>> Stashed changes
        else return false;
    }

}
