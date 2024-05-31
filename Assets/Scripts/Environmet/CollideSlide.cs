using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSlide : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    
    void OnTriggerEnter(Collider other)
    {   
        if(other.tag=="Player"){
            Debug.Log("start");
        if(thePlayer.GetComponent<Follower>().enabled == false)
        {
            thePlayer.GetComponent<Follower>().enabled = true; 
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.GetComponent<PlayerMove>().enabled = false;
            Debug.Log("Trying to change angle");
            thePlayer.transform.Rotate(thePlayer.transform.rotation.x,thePlayer.transform.rotation.y,95.47f);
            thePlayer.transform.position = new Vector3(45.92f,thePlayer.transform.position.y,thePlayer.transform.position.z);
        }
        }
    }
   
}
