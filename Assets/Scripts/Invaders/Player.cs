using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public Canonball canonball;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public AudioSource source;
    public AudioClip clip;
    float movement;
    int lives;

    // Start is called before the first frame update
    void Start()
    {
        canonball.direction = Vector3.up;
        lives = 5;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        if (movement > 0)
        {
            sr.flipX = false;
        }
        else if (movement < 0)
        {
            sr.flipX = true;
        }
        rb.velocity = new Vector2(movement * speed, 0);

        if (Input.GetKeyDown(KeyCode.Space) && GameObject.FindGameObjectsWithTag("Ball").Length <= 3)
        {
            Shoot();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        lives--;
        if (lives == 0)
        {
            Destroy(gameObject);
            StartCoroutine(Endgame());
        }
    }

    void Shoot()
    {
        source.clip = clip;
        source.Play();
        Instantiate(canonball, Vector3.up + transform.position, Quaternion.identity);
    }

    IEnumerator Endgame()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Invaders");
    }
}
