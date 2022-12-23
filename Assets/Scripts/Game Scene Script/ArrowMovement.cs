using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
	private CharacterController CharacterController; 
	public Player player; 
    // Start is called before the first frame update
    void Start()
    {
    	CharacterController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.p.x+Input.GetAxis("Horizontal"), 1, player.p.z+Input.GetAxis("Vertical"));
        //Debug.Log("Arrow: "+transform.position);
    }
}
