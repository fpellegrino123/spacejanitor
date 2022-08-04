using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Space : MonoBehaviour
{
    public Trash[] trashPrefab;
    public Text laserText;
    public Canvas canvas;
    public Text text;

    void Start()
    {
        InvokeRepeating("TrashSummon", 2.0f, 1.0f);
        text = Instantiate(laserText, new Vector3(0, 0, 0), Quaternion.identity) as Text;
        text.transform.SetParent(canvas.transform, false);
        text.text = "";
        text.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
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

    public void Status(GameObject trash)
    {
        if (trash.name == "Avengers")
        {
            text.text = "Avengers Assemble!";
        }
        else if (trash.name == "Jojo")
        {
            text.text = "Is this a Jojo Reference?";
        }
        else if (trash.name == "Lord of the Rings")
        {
            text.text = "Aye, I could do that...";
        }
        else if (trash.name == "Metallica")
        {
            text.text = "Enter Sandman!";
        }
        else if (trash.name == "Mona Lisa")
        {
            text.text = "Impressive how a turtle could paint this";
        }
        else if (trash.name == "One Piece")
        {
            text.text = "This will awaken your haki";
        }
        else if (trash.name == "Pokemon")
        {
            text.text = "Gotta catch 'em all!";
        }
        else if (trash.name == "Skyrim")
        {
            text.text = "Dragonborn, amirite?";
        }
        else if (trash.name == "Star Wars")
        {
            text.text = "I've got a bad feeling 'bout this...";
        }
        else if (trash.name == "Weird Al")
        {
            text.text = "Even Worse";
        }
    }
}
