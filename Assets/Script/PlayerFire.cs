using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform spawnBulletHere;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public float firerate = 10;
    private float BaseFireRate; 
    void Start()
    {
        BaseFireRate = firerate;
    }

    // Update is called once per frame
    void Update()
    {

        firerate -= Time.deltaTime;
        if (firerate <= 0) 
        
        {
            Shoot();

        }

        
        //if (Input.GetButtonDown("Fire1"))
        //{
            //Shoot();
        //}
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnBulletHere.position, spawnBulletHere.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
        bulletRB.AddForce(spawnBulletHere.forward * bulletSpeed, ForceMode.Impulse);
        firerate = BaseFireRate;
    }

      

}
