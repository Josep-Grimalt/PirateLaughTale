using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canonball : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool isEnemy;

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * direction;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (isEnemy && collision.gameObject.CompareTag("Player") || isEnemy && collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
        else if (!isEnemy)
        {
            Destroy(gameObject);
        }
    }
}
