using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    private bool tap, swipeUp1, swipeUp2, swipeUp3, swipeUp4, swipeUp5;
    public List<bool> list = new List<bool>();
    private bool isDraging = false;
    private Vector2 startTouch, swipeDelta;
    public float x,y;

    public void Start()
    {
        tap = swipeUp1 = swipeUp2 = swipeUp3 = swipeUp4 = swipeUp5 = false;
        list.Add(swipeUp1);
        list.Add(swipeUp2);
        list.Add(swipeUp3);
        list.Add(swipeUp4);
        list.Add(swipeUp5);
    }

    public void Update()
    {
        #region Standalone Inputs;
        if (Input.GetMouseButtonDown(0))
        {
            isDraging = true;
            tap = true;
            startTouch = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDraging = false;
            Reset();
        }
        #endregion

        #region Mobile Inputs;
        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                isDraging = true;
                tap = true;
                startTouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isDraging = false;
                Reset();
            }
        }
        #endregion

        //swipeDelta = Vector2.zero;
        
        if (isDraging)
        {
            if (Input.touches.Length > 0)
                swipeDelta = Input.touches[0].position - startTouch;
            else if (Input.GetMouseButton(0))
            {
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
            }
        }


        
        if (swipeDelta.magnitude <= 5 && swipeDelta.magnitude > 0)
        {
            x = swipeDelta.x;
            y = swipeDelta.y;
            if (y > 0) list[0] = true;
            Reset();
            Debug.Log("swipeUp1");
        }
        if (swipeDelta.magnitude <= 30 && swipeDelta.magnitude > 5)
        {
            x = swipeDelta.x;
            y = swipeDelta.y;
            if (y > 0) list[1] = true;
            Debug.Log("swipeUp2");
            Reset();
        }
        if (swipeDelta.magnitude <= 90 && swipeDelta.magnitude > 30)
        {
            x = swipeDelta.x;
            y = swipeDelta.y;
            if (y > 0) list[2] = true;
            Debug.Log("swipeUp3");
            Reset();
        }
        if (swipeDelta.magnitude <= 120 && swipeDelta.magnitude > 90)
        {
            x = swipeDelta.x;
            y = swipeDelta.y;
            if (y > 0) list[3] = true;
            Debug.Log("swipeUp4");
            Reset();
        }
        if (swipeDelta.magnitude > 120)
        {
            x = swipeDelta.x;
            y = swipeDelta.y;
            if (y > 0) list[4] = true;
            Debug.Log("swipeUp5");
            Reset();
        }
    }

    private void Reset()
    {
        startTouch = swipeDelta = Vector2.zero;
        isDraging = false;
    }


}
