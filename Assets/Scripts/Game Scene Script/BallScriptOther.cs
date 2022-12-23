using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScriptOther : MonoBehaviour
{
	public Player player; 

	public string myColor; 
	public GameScoreSc gamescore; 
	private bool isScored = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(!isScored){
    		//Calculate Distance between 2 objects. 

    		 float dist = Vector3.Distance(player.p, transform.position);
    		//If the player is close, add to the score if the color is the same, else substract points
    		if (dist <= 1){    	
    			isScored = true;
                gamescore.ballsScored++; 
                //Destroy(gameObject);
    			if(myColor==player.colorPlayer){
    				Debug.Log("Same color");
    				gamescore.GameScore+=Mathf.Floor(dist*100);
    				Debug.Log("Total Score= "+gamescore.GameScore);
    			}else{
    				Debug.Log("Different color");
    				gamescore.GameScore-=Mathf.Floor(dist*100); 
    				Debug.Log("Total Score= "+gamescore.GameScore);

    			}
                if(gamescore.ballsScored>= MainMenuBt.difficulty){
                    // Game Ends
                    SceneManager.LoadScene(0); 
                }
    			//Causes mild problem: Trying to access it after destroying it. But the function below just stops red from appearing
    			//Destroy(gameObject);
/*
    			if (gameObject != null)
    			    {  
    			        Destroy(gameObject);
    			    }
    			
*/
    	

    		}

    	}
        
    }
}
