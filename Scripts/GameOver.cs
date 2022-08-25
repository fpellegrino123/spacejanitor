using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text resultsText;
    public Text explosionText;
    public Text pointText;
    public Text anyKeyText;

    void Start()
    {
        resultsText.text = "Amount of points: " + GameManager.Instance.points + "\n Amount of explosions: " + GameManager.Instance.explosions;
        if (GameManager.Instance.points >= 40)
        {
            pointText.text = "Great cleaning!";
        }
        else if (GameManager.Instance.points >= 20)
        {
            pointText.text = "Could have been better";
        }
        else if (GameManager.Instance.points > 0)
        {
            pointText.text = "Did you even try?";
        }
        else
        {
            pointText.text = "Well, everyone starts somewhere";
        }
        if (GameManager.Instance.explosions >= 40)
        {
            explosionText.text = "MORE MORE MORE";
        }
        else if (GameManager.Instance.explosions >= 20)
        {
            explosionText.text = "Are you some kind of masochist?";
        }
        else if (GameManager.Instance.explosions > 0)
        {
            explosionText.text = "Well, this is safer anyway";
        }
        else
        {
            explosionText.text = "Suicidal tactics not your thing either?";
        }
        GameManager.Instance.ResetScore();
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad > 2)
        {
            if ((int)(Time.timeSinceLevelLoad * 2) % 2 == 0)
                anyKeyText.gameObject.SetActive(true);
            else
                anyKeyText.gameObject.SetActive(false);
            if (Input.anyKey)
                SceneManager.LoadScene("Menu");
        }
    }
}
