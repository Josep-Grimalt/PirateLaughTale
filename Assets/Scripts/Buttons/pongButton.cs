using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongButton : MonoBehaviour
{
    public void Pong() {
        SceneData.lastScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Pong");
    }
}
