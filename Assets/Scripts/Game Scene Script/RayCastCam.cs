using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastCam : MonoBehaviour
    // Start is called before the first frame update
{
     Ray ray;
     RaycastHit hit;
     public Player player; 
     
     void Update()
     {
         ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         if(Physics.Raycast(ray, out hit))
         {
             if(Input.GetMouseButtonDown(1)){
                 if(hit.collider.name=="Player"){
                    player.changeColor(); 
                 }
             }
                 
         }
     }
 }