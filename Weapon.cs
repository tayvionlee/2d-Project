using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour, IPooledObject
{
    ObjectPool objectPooler;
    public Transform firepoint;
    public GameObject bulletPrefab;
    
    // THIS SCRIPT IS FIREPOINT

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // calls whenever Fire1 is pressed
            Shoot();
            onObjectSpawn();
        }
    }

    void Shoot()
    {
        // Instantiate = spawn
        // Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }


    public void onObjectSpawn()
    {
        // bulletPrefab was here before
        Instantiate(objectPooler, transform.position, transform.rotation);
        objectPooler = ObjectPool.instance;

       // if (Input.GetButtonDown)
    }

    void FixedUpdate()
    {

        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        // Problem below - NullReferenceException
       // objectPooler.SpawnFromPool("Bullets-sheet_0", transform.position, Quaternion.identity);
    }

}

