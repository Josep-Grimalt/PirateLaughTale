using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigamesButton : MonoBehaviour
{
    public void Minigames() {
        SceneData.lastScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("MinigamesMenu");
    }
}
