using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    string lastScene;
    
    public void Continue()
    {
        lastScene = SceneData.lastScene;
        SceneData.lastScene = SceneManager.GetActiveScene().name;
        if(lastScene == "MinigamesMenu")
        {
            SceneManager.LoadScene(lastScene);
        }
        else
        {
            SceneManager.LoadScene("Campaign 3");
        }
    }
}
