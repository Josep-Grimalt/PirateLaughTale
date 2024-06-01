using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Campaign : MonoBehaviour
{
    public TextMeshProUGUI text;
    string lastScene;

    // Start is called before the first frame update
    void Start()
    {
        lastScene = SceneData.lastScene;
        SceneData.lastScene = SceneManager.GetActiveScene().name;
        switch (lastScene)
        {
            case "Main":
                StartCoroutine(StoryStart());
                break;
            case "Invaders":
                StartCoroutine(StoryArrival());
                break;
            case "Pong":
                StartCoroutine(StoryCelebration());
                break;
            case "Jackpot":
                StartCoroutine(StoryEnding());
                break;

        }
    }

    IEnumerator StoryStart()
    {
        yield return new WaitForSeconds(1);
        text.text = "PRÒLEG";
        yield return new WaitForSeconds(1);
        text.text = "";
        text.fontSize = 80;
        text.text = "Durant el segle XVII el Mediterrani era un mar de turbulències i oportunitats. Les costes estaven plagades de ciutats i ports rics en comerç i riqueses, però també amenaçades per la presència de pirates i corsaris.";
        yield return new WaitForSeconds(5);
        text.text = "Enmig d'aquest escenari, la tripulació del Vent del Sud emergeix com una força a tenir en compte.  Amb el seu vaixell, La Fúria del Mar, com a seu, buscaven sempre noves oportunitats per acumular riqueses i glòria.";
        yield return new WaitForSeconds(5);
        text.text = "A la seva illa amagatall, propera a les costes africanes, la tripulació preparà un pla per una nova missió: Saquejar les mines de Sardenya. Dit i fet, amb la primera llum del dia, la Fúria del Mar va salpar del seu amagatall.";
        yield return new WaitForSeconds(5);
        text.text = "";
        yield return new WaitForSeconds(0.15f);
        transform.SetPositionAndRotation(Vector3.MoveTowards(transform.position, new Vector3(-3.33f, -1, 0), 0.25f), Quaternion.Euler(0, 0, 90));
        yield return new WaitForSeconds(0.05f);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-3.33f, -1, 0), 0.25f);
        yield return new WaitForSeconds(0.05f);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-3.33f, -1, 0), 0.25f);
        text.text = "Malauradament, la tripulació del Vent del Sud va ser interceptada per un convoy que protegia l'illa...";
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Invaders");
    }

    IEnumerator StoryArrival()
    {
        yield return new WaitForSeconds(1);
        text.fontSize = 80;
        text.text = "Després d'escapar victoriosament del convoy, seguiren navegant cap al seu destí. En arribar, van desembarcar en una cala amagada i, ràpidament, prepararen les armes i sortiren a cercar l'enorme botí que contenia l'illa.";
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-3.33f, 0.55f, 0), 0.25f);
        while (transform.position.y != 0.55f)
        {
            yield return new WaitForSeconds(0.05f);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-3.33f, 0.55f, 0), 0.25f);
        }
        yield return new WaitForSeconds(5);
        text.text = "Passats uns minuts de silenci es va sentir un crit intimidant d'uns dels oficials del pirates, indicant que començava l'assaltament...";
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Pong");
    }

    IEnumerator StoryCelebration()
    {
        text.fontSize = 80;
        yield return new WaitForSeconds(1);
        text.text = "En haver derrotat als guàrdies de les mines, transportaren caixes plenes d'or fins al vaixell i, en tenir-ho ple, salparen cap a l'amagatall abans de que poguessin aperèixer els reforços.";
        transform.SetPositionAndRotation(Vector3.MoveTowards(transform.position, new Vector3(-3.33f, -1.7f, 0),0.25f), Quaternion.Euler(0, 0, 270));
        while (transform.position.y != -1.7f)
        {
        yield return new WaitForSeconds(0.05f);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-3.33f, -1.7f, 0), 0.25f);
        }
        yield return new WaitForSeconds(4f);
        text.text = "Quan van arribar a l'amagatall van començar a festejar la victòria. Els pirates es van posar a cantar i beure i beure i cantar i, entre les cançons i les begudes, alguns començaren a jugar i apostar-se la seva part en jocs d'atzar.";
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Jackpot");
    }

    IEnumerator StoryEnding()
    {
        text.fontSize = 80;
        yield return new WaitForSeconds(1);
        text.text = "La festa i les celebrecions van durar dies i dies, però molts perills i aventures els esperaven més enllà de l'horitzó, perills als que s'hauràn d'enfrontar tard o d'hora.";
        yield return new WaitForSeconds(5);
        text.text = "CONTINUARÀ...";
        text.fontSize = 150;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Main");
    }
}
