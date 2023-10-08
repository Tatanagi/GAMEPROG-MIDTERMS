using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform spawnBulletHere,firePoint;
    public GameObject bulletPrefab,bulletPrefab2;
    public float bulletSpeed, bulletSpeed2;
    public float firerate = 2;
    public float bulletForce = 10;
    private float BaseFireRate, BaseFireRate2;
    
    void Start()
    {
        BaseFireRate = firerate;
        bulletForce = BaseFireRate2;
    }

    // Update is called once per frame
    void Update()
    {
        
        firerate -= Time.deltaTime;
        bulletForce -= Time.deltaTime;
        if (firerate <= 0 && bulletForce <= 0) 
        
        {
            Shoot();
            Shoot2();

        }
        


    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnBulletHere.position, spawnBulletHere.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
        bulletRB.AddForce(spawnBulletHere.forward * bulletSpeed, ForceMode.Impulse);
        firerate = BaseFireRate;
    }

    void Shoot2()
    {
        GameObject bullet2 = Instantiate(bulletPrefab2, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet2.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * bulletSpeed2, ForceMode.Impulse);
        bulletForce = BaseFireRate2;

    }

      

}
