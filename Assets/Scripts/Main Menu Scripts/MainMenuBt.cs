using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class MainMenuBt : MonoBehaviour
{
	//Variable to be used to set difficulty
	public static int difficulty = 3; 
	public bool popDiff =false; 

  	public bool isMusicOn = false; 
	public Text musicText;  
    //If click on the music button turn it off, else turn it on
    public void OnClickMusic()
    {
        if (isMusicOn){
        	musicText.text = "Music [ ]";  
        	isMusicOn = false; 

        	}else{
        		musicText.text = "Music [X]";  
        		isMusicOn = true; 
        	}
    }
    //If you click on start game, load scene where game is. 
    public void OnClickStartG()
    {
       SceneManager.LoadScene(1); 
     
    }
    public void OnClickDifficulty()
    {
       if(popDiff){
       	popDiff = false; 

       	}else{
       		popDiff = true; 
       		Debug.Log ("Called Popin"); 
       	}
     
    }
     public void OnClick3Ball()
    {
       difficulty = 3;  
       Debug.Log(difficulty); 
     
    }
     public void OnClick10Ball()
    {
       difficulty = 10; 
       Debug.Log(difficulty); 
    }


  
}