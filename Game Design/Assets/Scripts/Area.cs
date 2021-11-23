using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    public List<Vector2> positions = new List<Vector2>();
    public int total_cells;
    public int total_cells_covered;

    void Start()
    {
        var objects = GameObject.FindGameObjectsWithTag("Area");
        foreach (var gameObject in objects) 
        {
            positions.Add(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y));
        }

    }

    public bool check_area(){
        total_cells=positions.Count;
        total_cells_covered = 0;
        for(int i=0;i<total_cells;i++){
            Vector2 pointA = new Vector2(positions[i].x - 0.125f, positions[i].y - 0.125f); 
            Vector2 pointB = new Vector2(positions[i].x + 0.125f, positions[i].y + 0.125f);
            if(Physics2D.OverlapArea(pointA, pointB)) total_cells_covered++;
            // if (Physics2D.OverlapCircle(area.positions[i], radius, layerMask)) total_cells_covered++;
        }
        if(total_cells_covered==total_cells) return true; //StartCoroutine(ExampleCoroutine());
        else return false;
    }

}
