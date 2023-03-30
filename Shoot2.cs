using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot2: MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletSpawner;
    public float bulletSpeed = 10;


public void Update() 
{
    GunShoot();
}
    public void GunShoot()
{
    if(Input.GetKeyDown(KeyCode.Mouse0))
    {  
            GameObject temporaryBall;
            temporaryBall = Instantiate(bullet, bulletSpawner.transform.position, bullet.transform.rotation) as GameObject;
            Rigidbody temporaryBallRB;
            temporaryBallRB = temporaryBall.GetComponent<Rigidbody>();
            temporaryBallRB.AddForce(bulletSpawner.transform.forward * bulletSpeed);   
            Destroy(temporaryBall, 5f);
    }
}
}