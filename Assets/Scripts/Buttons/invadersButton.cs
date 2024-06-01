using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InvadersButton : MonoBehaviour
{
    public void Invaders() {
        SceneData.lastScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Invaders");
    }
}
