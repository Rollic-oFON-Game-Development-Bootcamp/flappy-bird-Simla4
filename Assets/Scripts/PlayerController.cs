using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isDead = false;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float velocity = 2.5f;
    [SerializeField ]private GameManager gameManager;
    [SerializeField] private UIManager gameOverUI;
    [SerializeField] private float tiltSmooth = 2f;

    private Quaternion downRotation;
    private Quaternion upRotation;

    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 1;

        downRotation = Quaternion.Euler(0, 0, -90);
        upRotation = Quaternion.Euler(0, 0, 35);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            //to jump the bird
            transform.rotation = upRotation;
            rb.velocity = Vector2.up * velocity;
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, Time.deltaTime * tiltSmooth);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            gameManager.ScoreUpdate();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //to dead the bird
        if(collision.gameObject.tag == "Bait")
        {
            isDead = true;
            Time.timeScale = 0;
            gameOverUI.GameOverUI();
        }
    }
}
