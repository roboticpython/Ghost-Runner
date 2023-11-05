using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe2 : MonoBehaviour
{
    private Rigidbody2D rb;
    private Touch touch;
    private float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movespeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                rb.velocity = (touch.deltaPosition.y > 0)
                    ? Vector2.up * movespeed
                    : -Vector2.up * movespeed;
            }
        }        
    }
}
