using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour {

    public Sprite[] HeartSprites;

    public Image HeartUI;
    private PlayerMove player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
    }

    void Update()
    {
        HeartUI.sprite = HeartSprites[player.curHealth];
    }
}
