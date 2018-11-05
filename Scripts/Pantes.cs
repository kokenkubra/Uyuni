using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pantes : MonoBehaviour {

    private PlayerMove player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.Damage(1);
            //StartCoroutine(player.Knockback(0.02f, 350, player.transform.position));
        }
    }
}
