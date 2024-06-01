using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ball, player, playerGoal, rival, rivalGoal, playerText, rivalText, winLoseTxt;
    
    int playerScore = 0, rivalScore = 0;
    public int winningPonts = 5;
    string lastScene;

    void Start()
    {
        lastScene = SceneData.lastScene;
        SceneData.lastScene = SceneManager.GetActiveScene().name;
    }

    public void PlayerScored()
    {
        playerScore++;
        playerText.GetComponent<TextMeshProUGUI>().text = playerScore.ToString();
        if (playerScore == winningPonts)
        {
            winLoseTxt.GetComponent<TextMeshProUGUI>().text = "YOU WIN";
            StartCoroutine(Win());
        }
        else
        {
            Reset();
        }
    }

    public void RivalScored()
    {
        rivalScore++;
        rivalText.GetComponent<TextMeshProUGUI>().text = rivalScore.ToString();
        if (rivalScore == winningPonts)
        {
            winLoseTxt.GetComponent <TextMeshProUGUI>().text = "YOU LOSE";
            StartCoroutine(Lose());
        }
        else
        {
            Reset();
        }
    }

    private void Reset() {
        ball.GetComponent<Ball>().Reset();
        player.GetComponent<Paddle>().Reset();
        rival.GetComponent<Rival>().Reset();
    }

    IEnumerator Lose() {
        yield return new WaitForSeconds(1.5f);
        if(lastScene == "MinigamesMenu")
        {
        SceneManager.LoadScene(lastScene);
        }
        else
        {
        SceneManager.LoadScene("Pong");
        }
    }

    IEnumerator Win() {
        yield return new WaitForSeconds(1.5f);
        if(lastScene == "MinigamesMenu")
        {
        SceneManager.LoadScene(lastScene);
        }
        else
        {
        SceneManager.LoadScene("Campaign 2");
        }
    }
}
