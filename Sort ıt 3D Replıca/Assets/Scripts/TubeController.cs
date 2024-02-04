using System.Collections.Generic;
using UnityEngine;

public class TubeController : MonoBehaviour
{

    public List<GameObject> balls = new List<GameObject>();
    
    private string currentBallColor;



    public void CheckTubeBalls()
    {
        if (balls.Count > 1)
        {
            currentBallColor = balls[0].tag;
          

           
        }

       
    }
}