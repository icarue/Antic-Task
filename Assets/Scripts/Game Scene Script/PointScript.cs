using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PointScript : MonoBehaviour
{
	public GameScoreSc score; 
	public Text display;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        display.text = "Points: " + score.GameScore;  
    }
}
