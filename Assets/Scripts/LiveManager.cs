using TMPro;
using UnityEngine;

public class LiveManager : MonoBehaviour
{
    public TextMeshProUGUI livesTextHolder;
    public static int lives_count = 5;

    public GameObject gameOverPanel;
    public TextMeshProUGUI sorry_out_of_TextHolder;
    string sorry_out_of_message = "Sorry, you are out of lives.";

    public GameObject gamePanel;

    private void Update()
    {
        livesTextHolder.text = lives_count.ToString();

        if (lives_count == 0) // Corrected comparison
        {
            Time.timeScale = 0;
            sorry_out_of_TextHolder.text = sorry_out_of_message;
            gameOverPanel.SetActive(true);
            gamePanel.SetActive(false);
        }
    }
}
