using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tales_Collider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Yellow"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }

    }
}
