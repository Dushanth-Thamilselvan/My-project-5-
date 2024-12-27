using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 100;

    public GameObject explosion;

    void Start()
    {
        rb.linearVelocity = Vector2.up * speed;  
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "enemy")
        {
            ScoreManager.score += 10;  
            Destroy(gameObject);  
            playExplosion(); 
        }
    }

    private void playExplosion()
    {
        GameObject e  = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;

        Destroy(e, 2.0f);  
    }
}
