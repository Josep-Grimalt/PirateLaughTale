using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gamemaster : MonoBehaviour
{
    public Dice[] dices;
    public TextMeshProUGUI text;
    public Button rematchButton, continueButton;
    int[] results;
    bool rolled = false;
    public AudioSource source;
    public AudioClip clip;

    void Start()
    {
        rematchButton.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        results = new int[dices.Length];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !rolled)
        {
            rolled = true;
            source.clip = clip;
            source.Play();
            RollDices();
        }
    }

    void RollDices()
    {
        results[0] = Random.Range(1, 7);
        results[1] = Random.Range(1, 7);
        results[2] = Random.Range(1, 7);
        results[3] = Random.Range(1, 7);
        dices[0].ChangeSprite(results[0]);
        dices[1].ChangeSprite(results[1]);
        dices[2].ChangeSprite(results[2]);
        dices[3].ChangeSprite(results[3]);

        if (results[0] + results[1] > results[2] + results[3])
        {
            text.text = "YOU WIN";
        }
        else
        {
            text.text = "YOU LOSE";
        }
        rematchButton.gameObject.SetActive(true);
        continueButton.gameObject.SetActive(true);
    }
}
