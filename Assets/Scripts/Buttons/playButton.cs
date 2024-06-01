using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void Play() {
        SceneData.lastScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Campaign");
    }
}
