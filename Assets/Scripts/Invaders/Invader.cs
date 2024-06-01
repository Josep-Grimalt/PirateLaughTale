using System.Collections;
using UnityEngine;

public class Invader : MonoBehaviour
{
    public int speed;
    public bool isRam;
    bool goesLeft;
    public Rigidbody2D rb;
    public Canonball canonball;
    public SpriteRenderer sr;
    public AudioSource source;
    public AudioClip clip;


    public void Spawn()
    {
        Instantiate(gameObject, new Vector3(Random.Range(-2, 2), Random.Range(1, 5), 0), Quaternion.identity);
    }

    void Start()
    {
        goesLeft = false;
        if (!isRam)
        {
            InvokeRepeating(nameof(Shoot), Random.Range(1, 5), 3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 7)
        {
            goesLeft = true;
            StartCoroutine(GoDown());
        }
        else if (transform.position.x <= -7)
        {
            goesLeft = false;
            StartCoroutine(GoDown());
        }
        Move();
        if (transform.position.y <= -6)
        {
            transform.position = new Vector3(transform.position.x, 5, 0);
        }
    }

    void Move()
    {
        float movement;
        if (goesLeft)
        {
            movement = -1;
            sr.flipX = true;
        }
        else
        {
            movement = 1;
            sr.flipX = false;
        }
        rb.velocity = new Vector2(speed * movement, 0);
    }

    IEnumerator GoDown()
    {
        transform.position += new Vector3(0, -0.25f, 0);
        yield return new WaitForSeconds(2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Gamemanager gamemanager = GameObject.FindObjectOfType<Gamemanager>().GetComponent<Gamemanager>();

            gamemanager.Sink();
            Destroy(gameObject);
        }
    }

    void Shoot()
    {
        source.clip = clip;
        source.Play();
        Vector3 spawnPosition = transform.position + Vector3.down;
        Instantiate(canonball, spawnPosition, Quaternion.identity);
    }
}
