using UnityEngine;
using System.Collections.Generic;

public class Enemy_Spawn_Point : MonoBehaviour
{
    float rand_position;
    Vector2 spawn_position;
    public float spawn_rate = 2.0f;
    private float next_spawn = 0.0f;

    public List<GameObject> enemy_list;
    private GameObject random_enemy;

    private GameObject RandomEnemy()
    {
        var random_temp = Random.Range(-0 , enemy_list.Count);
        return enemy_list[random_temp];
    }

    private void SpawnEnemy()
    {
        if (Time.time > next_spawn)
        {   
            next_spawn = Time.time + spawn_rate;

            Camera camera = Camera.main;
            float cameraWidth = camera.orthographicSize * camera.aspect;

            rand_position = Random.Range(-cameraWidth, cameraWidth);
            spawn_position = new Vector2(rand_position, transform.position.y);

            Instantiate(RandomEnemy(), spawn_position, Quaternion.identity, this.transform);

            Debug.Log("Spawning enemy at: " + spawn_position);
        }
    }

    private void Update()
    {
        SpawnEnemy();
    }
}
