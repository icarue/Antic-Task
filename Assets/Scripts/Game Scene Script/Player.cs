using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
	private CharacterController CharacterController; 
	public float speed = 5f; 
	public Vector3 p = new Vector3(0,0,0);
	private bool isReady = false; 
	private Vector3 move = new Vector3(0,0,0);
	public string colorPlayer = "blue"; 
	public int turns = 0; 
	public Material MaterialB;
	public Material MaterialG;
	public Material MaterialR;

    // Start is called before the first frame update
    void Start()
    {
        CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    	//Update the player's location
    	p = transform.position;
    	movePlayer();

    	

    	
    	
        
    }
    public void changeColor(){

    	if (colorPlayer=="blue"){
    		colorPlayer="red";
    		this.GetComponent<MeshRenderer>().material = MaterialR;
    	}else{
    		if (colorPlayer=="red"){
    		colorPlayer="green";
    		this.GetComponent<MeshRenderer>().material = MaterialG;
    	}else{
    		colorPlayer="blue";
    		this.GetComponent<MeshRenderer>().material = MaterialB;

    	}}
    	
    }
    //Press key to prepare movement, and release it to move
     void movePlayer(){
     	if (Input.GetKeyDown("up")||Input.GetKeyDown("down")||Input.GetKeyDown("left")||Input.GetKeyDown("right")){
            isReady = true; 
            //Debug.Log("isReady: " + isReady);
        }
        move = new Vector3(Input.GetAxis("Horizontal"), 0,Input.GetAxis("Vertical"));

        if(isReady){
        	if(Input.GetKeyUp("up")||Input.GetKeyUp("down")||Input.GetKeyUp("left")||Input.GetKeyUp("right")){
        		CharacterController.Move(move*Time.deltaTime*speed);
        		isReady = false;
        		turns++; 

        	}

        }



    	
    }
}
