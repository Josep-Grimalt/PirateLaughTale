using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JackpotButton : MonoBehaviour
{
    public void Jackpot() {
        SceneData.lastScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Jackpot");
    }
}
