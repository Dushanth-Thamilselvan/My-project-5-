using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI score_textholder;
    public static int score = 0;

    public TextMeshProUGUI final_score;

    // Update is called once per frame
    void Update()
    {
        score_textholder.text = score.ToString();
        final_score.text = score.ToString();
    }
}
