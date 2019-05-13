using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject ball;
    public GameObject ArCamera;
    public Swipe swipeControl;

    public float[] ballThrowForce = new float[] { 1.5f, 2.5f, 3.5f, 5.5f, 7f};
    public bool holdingBall = true;

    private Rigidbody rb;

    void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void Update()
    {
        if (holdingBall)
        {

            for (int scan = 0; scan < swipeControl.list.Count; ++scan)
            {
                if (swipeControl.list[scan] == true)
                {
                    rb.transform.parent = null;
                    holdingBall = false;
                    rb.useGravity = true;
                    rb.AddForce(rb.transform.forward * ballThrowForce[scan] * 2, ForceMode.Impulse); 
                    rb.AddForce(0, 300, 0);
                }
            }

        }

    }
}