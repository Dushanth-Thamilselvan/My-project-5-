using UnityEngine;

public class ScreenBounce : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.3f, 2.3f),
                transform.position.y, transform.position.z);

    }
}
