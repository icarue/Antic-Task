using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopInMenuDiff : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 POPIN =new Vector3 (21.9f, 10f,-10f);
    private Vector3 POPOFF = new Vector3 (500f, 0f,5f);
    public MainMenuBt menu; 


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 	
    	if(menu.popDiff){
    		transform.position = POPIN; 


    		}else{
    			transform.position = POPOFF; 
    		}
    	
        
    }
}
