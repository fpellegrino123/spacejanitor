using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text titleText;
    public Text optionsText;
    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad <= 0.5f)
            titleText.text = "S";
        else if (Time.timeSinceLevelLoad <= 1f)
            titleText.text = "SP";
        else if (Time.timeSinceLevelLoad <= 1.5f)
            titleText.text = "SPA";
        else if (Time.timeSinceLevelLoad <= 2.5f)
            titleText.text = "SPACE";
        else if (Time.timeSinceLevelLoad <= 3.5f)
            titleText.text = "SPACE J";
        else if (Time.timeSinceLevelLoad <= 3.6f)
            titleText.text = "SPACE JA";
        else if (Time.timeSinceLevelLoad <= 3.7f)
            titleText.text = "SPACE JAN";
        else if (Time.timeSinceLevelLoad <= 3.8f)
            titleText.text = "SPACE JANI";
        else if (Time.timeSinceLevelLoad <= 3.9f)
            titleText.text = "SPACE JANIT";
        else if (Time.timeSinceLevelLoad <= 4f)
            titleText.text = "SPACE JANITO";
        else if (Time.timeSinceLevelLoad <= 4.1f)
            titleText.text = "SPACE JANITOR";
        if (Time.timeSinceLevelLoad > 4.6f)
        {
            optionsText.text = "1. School Janitor\n 2. Corporate Janitor\n 3. Professional Janitor\n 4. Space Janitor";
            optionsText.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.Alpha1))
            {
                GameManager.Instance.diff = 1;
                SceneManager.LoadScene("Game");
            }
            else if (Input.GetKey(KeyCode.Alpha2))
            {
                GameManager.Instance.diff = 2;
                SceneManager.LoadScene("Game");
            }
            else if (Input.GetKey(KeyCode.Alpha3))
            {
                GameManager.Instance.diff = 3;
                SceneManager.LoadScene("Game");
            }
            else if (Input.GetKey(KeyCode.Alpha4))
            {
                GameManager.Instance.diff = 4;
                SceneManager.LoadScene("Game");
            }
        }
    }
}

