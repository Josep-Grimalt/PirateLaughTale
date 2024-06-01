using UnityEngine;

public class Rival : MonoBehaviour
{
    private Vector3 startPosition;
    public float speed;
    public Rigidbody2D rb;
    public Ball ball;

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
        if (ball.transform.position.y > transform.position.y + 0.15f)
        {
            movement = 1;
        }
        else if (ball.transform.position.y < transform.position.y + .15f)
        {
            movement = -1;
        }
        else
        {
            movement = 0;
        }

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
