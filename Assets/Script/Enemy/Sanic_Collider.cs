using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanic_Collider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blue"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Player"))
        {

        }
    }
}
