using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour {

    private PlayerMove player; 

    void Start()
    {
        player = gameObject.GetComponentInParent<PlayerMove>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        player.grounded = true;
    }

     void OnTriggerStay2D(Collider2D col)
    {
        player.grounded = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        player.grounded = false;
    }
}
