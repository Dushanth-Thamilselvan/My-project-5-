using UnityEngine;
using TMPro;

public class SpawnProjectileController : MonoBehaviour
{
    public GameObject BulletPrefab;
    public int bullet_amount = 50;
    public TextMeshProUGUI Bullet_Value_textholder;

    public GameObject gameOver_panel;
    public TextMeshProUGUI sorry_out_of_texthHolder;
    string sorry_out_of_message = "Sorry, you out of lives.";

    public GameObject game_panel;

   

    void Update()
    {
        Bullet_Value_textholder.text = bullet_amount.ToString();
    }

    public void Shoot()
    {
        if (bullet_amount > 0)
        {
            GameObject bullet = Instantiate(BulletPrefab, this.transform.position, transform.rotation, transform);
            bullet_amount--; 

            if (bullet_amount == 0)
            {
                Time.timeScale = 0;  
                sorry_out_of_texthHolder.text = sorry_out_of_message;
                gameOver_panel.SetActive(true);
                game_panel.SetActive(false);
            }

            Destroy(bullet, 2.5f);  
        }
    }
}
