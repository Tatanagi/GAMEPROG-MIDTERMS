using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Transform> Enenmy_spawner_List;
    public Transform SpawnLocation;
    public GameObject Enemy_Red_Prefab, Enemy_Blue_Prefab, Enemy_Yellow_Prefab;
    public float respawn_time = 5;

    void Awake()
    {
        SpawnLocation = Enenmy_spawner_List[Random.Range(0, Enenmy_spawner_List.Count)];
    }

    // Update is called once per frame
    void Update()
    {
        respawn_time -= Time.deltaTime;
        if (respawn_time <= 0)
        {
            SpawnEnemies();
        }
    }

    public void SpawnEnemies()
    {
        int i = Random.Range(1,4);
        switch (i)
        {

            case 1:
                GameObject enemy_spawned_red = Instantiate(Enemy_Red_Prefab, SpawnLocation.position, SpawnLocation.rotation);
                Rigidbody  red_sp = enemy_spawned_red.GetComponent<Rigidbody>();
                break;
            case 2:
                GameObject enemy_spawned_blue = Instantiate(Enemy_Blue_Prefab, SpawnLocation.position, SpawnLocation.rotation);
                Rigidbody blue_sp = enemy_spawned_blue.GetComponent<Rigidbody>();
                break;
            case 3:
                GameObject enemy_spawned_yellow = Instantiate(Enemy_Yellow_Prefab, SpawnLocation.position, SpawnLocation.rotation);
                Rigidbody yellow_sp = enemy_spawned_yellow.GetComponent<Rigidbody>();
                break;
        }
        respawn_time = Random.Range(2, 5);
        SpawnLocation = Enenmy_spawner_List[Random.Range(0, Enenmy_spawner_List.Count)];

    }
}

