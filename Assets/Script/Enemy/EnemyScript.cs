using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemy_speed;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        var step = enemy_speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            target.position *= -1.0f;
        }
    }
}
