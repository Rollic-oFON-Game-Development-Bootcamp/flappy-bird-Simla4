using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isDead = false;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float velocity = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            //to bounce the bird
            rb.velocity = Vector2.up * velocity;

            //Debug.Log("Pressed the mouse");
        }


    }
}
