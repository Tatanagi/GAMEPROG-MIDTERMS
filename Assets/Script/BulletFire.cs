using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform gunMuzzle;
    public GameObject bulletPrefab;
    public float bulletForce = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }

    }
    void Shoot() 
    
    { 
    
    
    
    }

}
