using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayerGoal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayerGoal)
            {
                GameObject.Find("Main Camera").GetComponent<GameManager>().RivalScored();
            }
            else
            {
                GameObject.Find("Main Camera").GetComponent<GameManager>().PlayerScored();
            }
        }
    }
}
