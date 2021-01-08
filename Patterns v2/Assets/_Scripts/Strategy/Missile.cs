using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour, IWeapon
{
    public void Shoot()
    {

        Vector3 initialPosition = new Vector3(this.transform.position.x, this.transform.position.y+1f, 0);
        GameObject missile = Instantiate(Resources.Load("MissilePrefab", typeof(GameObject))) as GameObject;
        missile.transform.position = initialPosition;
        missile.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 20f);

    }
}
