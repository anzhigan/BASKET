using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //public GameObject celebration;
    //public float resetTimer = 4f;
    public static bool enable = false;

    void OnTriggerEnter(Collider otherCollider)
    {
        Debug.Log("Score!");
        ScoreText.scoreCount++;
        enable = true;
    }

    /*void Start()
    {
        celebration.SetActive(false);
    }
    void Update()
    {
        if (enable)
        {
            celebration.SetActive(true);
            resetTimer -= Time.deltaTime;
            if (resetTimer <= 0)
            {
                celebration.SetActive(false);
            }
        }
        
    }*/

}
