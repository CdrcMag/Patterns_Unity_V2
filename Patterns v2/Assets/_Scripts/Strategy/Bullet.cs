﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IWeapon
{

    public void Shoot()
    {

        Vector3 initialPosition = new Vector3(this.transform.position.x, this.transform.position.y + 1f, 0);
        GameObject bullet = Instantiate(Resources.Load("BulletPrefab", typeof(GameObject))) as GameObject;
        bullet.transform.position = initialPosition;
        bullet.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 20f);
    }
}
