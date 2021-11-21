using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOne : MonoBehaviour
{
    // Start is called before the first frame update
    // public float[, , ] area_matrix = new float[19,19,2];
    public List<Vector3> positions = new List<Vector3>();
    public int max_score=50,min_items=4;
    void Start()
    {
        var objects = GameObject.FindGameObjectsWithTag("Area");
        foreach (var gameObject in objects) 
        {
            positions.Add(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
            //Debug.Log(gameObject.transform.position);
        }
        // float x = -9.42f;   
        // float y = 2.55f;
        // int k=0;
        // for(int i=0;i<19;i++){
        //     area_matrix[i,0,0] = x;
        //     area_matrix[i,0,1] = y - k*0.3f;
        //     k++;
        //     for(int j=1;j<19;j++){
        //         area_matrix[i,j,0] = area_matrix[i,j-1,0] + 0.3f;
        //         area_matrix[i,j,1] = area_matrix[i,j-1,1];
        //     }
        // }
    }

}
