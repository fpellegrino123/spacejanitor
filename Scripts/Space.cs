using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Space : MonoBehaviour
{
    public Trash[] trashPrefab;
    public Text laserText;
    public Canvas canvas;
    public Text text;
    public int points;
    public int explosions;
    public Text countdownText;
    public float Countdown;

    void Start()
    {
        countdownText.gameObject.SetActive(true);
        text = Instantiate(laserText, new Vector3(0, 0, 0), Quaternion.identity) as Text;
        text.transform.SetParent(canvas.transform, false);
        text.text = "";
        text.gameObject.SetActive(true);
        points = 0;
        explosions = 0;
        InvokeRepeating("TrashSummon", 2f, 1f);
    }

    void Update()
    {
        Countdown = Mathf.Clamp(Countdown - Time.deltaTime, 0, 100);
        countdownText.text = "Countdown: <color=yellow><b>" + Mathf.CeilToInt(Countdown) + "</b></color>";

        if (Countdown <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void TrashSummon()
    {
        int randomIndex = Random.Range(0, trashPrefab.Length);
        int randX = Random.Range(-4, 4);
        int randY = Random.Range(2, 8);
        Vector3 curPos = new Vector3(randX, randY, 50);
        Trash(randomIndex, curPos);
    }

    private void Trash(int index, Vector3 pos)
    {
        Instantiate(trashPrefab[index], pos, Quaternion.Euler(new Vector3(10, 180, 0)));
    }

    public int GetPoints()
    {
        return points;
    }

    public int GetExplosions()
    {
        return explosions;
    }

    public void Status(GameObject trash)
    {
        if (trash.name == "Avengers")
        {
            string[] joke = { "Janitors Assemble!","Now this is a Janitor level threat","You know, I'm something of a Janitor myself"};
            int j = Random.Range(0, 2);
            text.text = joke[j];
        }
        else if (trash.name == "Jojo")
        {
            string[] joke = { "Is this a Jojo reference?", "Are you approaching me, Jonitor?", "To be continued..." };
            int j = Random.Range(0, 2);
            text.text = joke[j];
        }
        else if (trash.name == "Lord of the Rings")
        {
            string[] joke = { "Aye, I could do that...", "Alright then, keep your trash", "One does not simply walk into space" };
            int j = Random.Range(0, 2);
            text.text = joke[j];
        }
        else if (trash.name == "Metallica")
        {
            string[] joke = { "Enter Janitorman!", "Clean the Lightning", "Master of Janitors" };
            int j = Random.Range(0, 2);
            text.text = joke[j];
        }
        else if (trash.name == "Mona Lisa")
        {
            string[] joke = { "Impressive how a turtle could paint this", "Did Nicolas Cage threw this out?", "Da Vinki?" };
            int j = Random.Range(0, 2);
            text.text = joke[j];
        }
        else if (trash.name == "One Piece")
        {
            string[] joke = { "This will awaken your haki", "Clean D. Trash", "He Laughed" };
            int j = Random.Range(0, 2);
            text.text = joke[j];
        }
        else if (trash.name == "Pokemon")
        {
            string[] joke = { "Gotta catch 'em all!", "Here, a Garbodorite", "Smell ya later!" };
            int j = Random.Range(0, 2);
            text.text = joke[j];
        }
        else if (trash.name == "Skyrim")
        {
            string[] joke = { "Dragonborn, amirite?", "Paarthurnax would be proud...", "Did you get by an arrow on the knee?" };
            int j = Random.Range(0, 2);
            text.text = joke[j];
        }
        else if (trash.name == "Star Wars")
        {
            string[] joke = { "I've got a bad feeling 'bout this...", "Now that is pod racing!", "This is where the fun begins" };
            int j = Random.Range(0, 2);
            text.text = joke[j];
        }
        else if (trash.name == "Weird Al")
        {
            string[] joke = { "Even Worse", "Now this is a Janitor's Paradise", "Smells Like Trash" };
            int j = Random.Range(0, 2);
            text.text = joke[j];
        }
    }
}
