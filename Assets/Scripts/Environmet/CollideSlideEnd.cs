using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSlideEnd : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    
    void OnTriggerEnter(Collider other)
    {   
        if(other.tag=="Player"){
            Debug.Log("end");
        if(thePlayer.GetComponent<Follower>().enabled == true)
        {
            thePlayer.GetComponent<Follower>().enabled = false; 
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.GetComponent<PlayerMove>().enabled = true;
            thePlayer.transform.rotation = Quaternion.identity;
            thePlayer.transform.position = new Vector3(thePlayer.transform.position.x,-4.77f,thePlayer.transform.position.z);
        }
        }
    }
   
}
