using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot2: MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletSpawner;
    public float fireRate;
    float nextShot;

public void Update() 
{
    GunShoot();
}
    public void GunShoot()
{
    if(Time.time > nextShot)
    {
        nextShot = Time.time + fireRate;
        GameObject temporaryBall;
        temporaryBall = Instantiate(bullet, bulletSpawner.transform.position, bullet.transform.rotation) as GameObject;
        Rigidbody temporaryBallRB;
        temporaryBallRB = temporaryBall.GetComponent<Rigidbody>();
        temporaryBallRB.AddForce(bulletSpawner.transform.forward);
        Destroy(temporaryBall, 5f);
    }
            
    
}
}