using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public ShipController controller;

    private void Update()
    {
        //Weapons
        if(Input.GetKeyDown(KeyCode.A))
        {
            controller.weaponType = ShipController.WeaponType.Bullet;
            controller.HandleWeaponType();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            controller.weaponType = ShipController.WeaponType.Missile;
            controller.HandleWeaponType();
        }

        //Fires
        if (Input.GetKeyDown(KeyCode.Q))
        {
            controller.flameColor = ShipController.Flame.Blue;
            controller.HandleFlameColor();
            controller.iFlame.ShowFlame();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            controller.flameColor = ShipController.Flame.Red;
            controller.HandleFlameColor();
            controller.iFlame.ShowFlame();
        }

    }


}
