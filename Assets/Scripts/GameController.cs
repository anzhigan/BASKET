using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{   
    public Player player;
    public float resetTimer = 5f;
    void Start()
    {
    }
    
    void Update()
    {
        if (!player.holdingBall)
        {
            resetTimer -= Time.deltaTime;
            if (resetTimer <= 0)
            {
                Application.LoadLevel("Basket");
            }
        }


    }
}


