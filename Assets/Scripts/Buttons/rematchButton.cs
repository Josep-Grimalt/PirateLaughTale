using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RematchButton : MonoBehaviour
{
    public void Rematch() {
        SceneManager.LoadScene("Jackpot");
    }
}
