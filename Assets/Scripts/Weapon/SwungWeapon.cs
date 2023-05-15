using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwungWeapon : Weapon
{
    public float swingSpeed;
    public float swingDegrees;

    public override void Attack()
    {

        Invoke("AttackReset", 60f / attackRate);

        transform.localEulerAngles = new Vector3 (0,0,-swingDegrees);

        EnableWeapon();

        StartCoroutine(swing());


    }

    IEnumerator swing()
    {
        float degrees = 0f;

        while (degrees < swingDegrees * 2)
        {
            transform.Rotate(Vector3.forward, swingSpeed * Time.deltaTime);
            degrees += swingSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        DisableWeapon();
    }
}
