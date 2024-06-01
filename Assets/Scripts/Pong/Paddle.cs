using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Vector3 startPosition;
    public float speed;
    public Rigidbody2D rb;
    public AudioSource source;
    public AudioClip clip;
    private float movement;

    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }

    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        source.clip = clip;
        source.Play();
    }

}
