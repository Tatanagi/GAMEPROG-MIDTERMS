using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uganda_Knuckles_Collieder : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Red"))
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
