using UnityEngine;
using System.Collections;



public class ShipController : MonoBehaviour
{
    public enum WeaponType
    {
        Missile,
        Bullet
    }
    public enum Flame
    {
        Blue,
        Red
    }

    #region variables
    public WeaponType weaponType;
    public Flame flameColor;

    private IWeapon iWeapon;
    public IFlame iFlame;
    #endregion

    public void HandleWeaponType()
    {

        //To prevent Unity from creating multiple copies of the same component in inspector at runtime
        Component c = gameObject.GetComponent<IWeapon>() as Component;

        if (c != null)
        {
            Destroy(c);
        }

        #region Strategy
        switch (weaponType)
        {

            case WeaponType.Missile:
                iWeapon = gameObject.AddComponent<Missile>();
                break;

            case WeaponType.Bullet:
                iWeapon = gameObject.AddComponent<Bullet>();
                break;

            default:
                iWeapon = gameObject.AddComponent<Bullet>();
                break;
        }
        #endregion
    }

    public void HandleFlameColor()
    {

        Component c = gameObject.GetComponent<IFlame>() as Component;

        if (c != null)
        {
            Destroy(c);
            iFlame.DestroyFlame();
        }

        #region Strategy
        switch (flameColor)
        {

            case Flame.Blue:
                iFlame = gameObject.AddComponent<BlueFlame>();
                break;

            case Flame.Red:
                iFlame = gameObject.AddComponent<RedFlame>();
                break;

            default:
                iFlame = gameObject.AddComponent<BlueFlame>();
                break;
        }
        #endregion

    }

    public void Fire()
    {
        iWeapon.Shoot();
    }

    void Start()
    {
        //Checks the value of the weapon type
        HandleWeaponType();

        //Checks the value of the fire type
        HandleFlameColor();

        //Displays the fire
        iFlame.ShowFlame();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
        
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    HandleWeaponType();
        //}

        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    HandleFlameColor();
        //    iFlame.ShowFlame();
        //}
    }
}