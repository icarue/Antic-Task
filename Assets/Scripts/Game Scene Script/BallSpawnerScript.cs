using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{
    public GameObject prefabB;
    public GameObject prefabR;
    public GameObject prefabG;
    public Player Player;
    private int ballCount = 0; 
    //private int count = 0; 
    void Start()
    {
        
        
    } 
    // Update is called once per frame
    void Update()
    {
    	//Wait a little bit between each Ball SPawn
      
    	if (ballCount < MainMenuBt.difficulty){
    		ballCount++; 
    		int rnd = Random.Range(-1, 2); 
    		int xpos = 0;
    		int zpos = 0;
    		if (rnd != 0){
    			xpos = Random.Range(3, 15)*rnd;
    			}else{
    			xpos = Random.Range(3, 15);
    			}
    		rnd = Random.Range(-1, 2); 
    		if (rnd != 0){
    			zpos = Random.Range(3, 15)*rnd;
    			}else{
    			zpos = Random.Range(3, 15);
    			}
    	

    	
  
    	int color = Random.Range(0, 3);
    	switch(color) 
    	{
    	  case 0:
    	 	 Instantiate(prefabB, new Vector3(Player.p.x+xpos, .5f, Player.p.z+zpos), Quaternion.identity);
    	    break;
    	  case 1:
    	 	 Instantiate(prefabR, new Vector3(Player.p.x+xpos, .5f, Player.p.z+zpos), Quaternion.identity);
    	    break;
    	  case 2:
    	 	 Instantiate(prefabG, new Vector3(Player.p.x+xpos, .5f, Player.p.z+zpos), Quaternion.identity);
    	    break;
    	}
        
  
         }
    }
}
