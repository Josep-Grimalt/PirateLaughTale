using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public Elite corsair, frigate;
    public Invader ram, canonade;
    int eliteEnemies, basicEnemies;
    int totalEnemies;
    string lastScene;

    // Start is called before the first frame update
    void Start()
    {
        lastScene = SceneData.lastScene;
        StartCoroutine(GetScene());
        basicEnemies = Random.Range(4, 9);
        eliteEnemies = Random.Range(1,basicEnemies / 2);
        totalEnemies = eliteEnemies + basicEnemies;
        for (int i = 0; i < basicEnemies; i++)
        {
            if (i % 3 == 0)
            {
                canonade.Spawn();
            }
            else
            {
                ram.Spawn();
            }
        }

        for (int i = 0; i < eliteEnemies; i++)
        {
            if (i % 2 == 0)
            {
                corsair.Spawn();
            }
            else
            {
                frigate.Spawn();
            }
        }
    }

    void Update()
    {
        if(totalEnemies <= 0)
        {
            StartCoroutine(Endgame());
        }
    }

    public void Sink()
    {
        totalEnemies--;
    }

    IEnumerator Endgame()
    {
        yield return new WaitForSeconds(2);
        if(lastScene == "MinigamesMenu")
        {
            
            SceneManager.LoadScene(lastScene);
        }
        else
        {
            SceneManager.LoadScene("Campaign 1");
        }
    }

    IEnumerator GetScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneData.lastScene = SceneManager.GetActiveScene().name;
    }
}
