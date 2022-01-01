using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private float time = 10;

    private void Start()
    {
        Destroy(gameObject, time);
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
