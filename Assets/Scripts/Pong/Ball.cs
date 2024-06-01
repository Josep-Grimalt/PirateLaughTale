using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        Launch();
        startPosition = transform.position;
    }

    void Update()
    {
        if (rb.velocity.x > 0 && rb.velocity.y > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x + 0.01f, rb.velocity.y + 0.01f);
        }
        else if(rb.velocity.x < 0 && rb.velocity.y > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x - 0.01f, rb.velocity.y + 0.01f);
        }
        else if (rb.velocity.y < 0 && rb.velocity.x > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x + 0.01f, rb.velocity.y + 0.01f);
        }
        else if(rb.velocity.y < 0 && rb.velocity.x < 0)
        {
            rb.velocity = new Vector2(rb.velocity.x - 0.01f, rb.velocity.y - 0.01f);
        }
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
