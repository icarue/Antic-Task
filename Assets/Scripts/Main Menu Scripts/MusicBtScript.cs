using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class MainMenuButtons : MonoBehaviour
{
  	public bool isMusicOn = true; 
	public Text display;  
    // Start is called before the first frame update
    public void OnClickMusic()
    {
        if (isMusicOn){
        	display.text = "Music [ ]";  

        	}else{
        		display.text = "Music [X]";  
        	}
    }

  
}