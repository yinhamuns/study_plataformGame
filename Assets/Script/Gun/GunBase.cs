using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : MonoBehaviour
{
    public ProjectileBase prefabProjectile;

    public Transform positionToShoot;
    public float timeBetweenShoot = .3f;

    public Transform playerSideReference;

    private Coroutine _currentCoroutine;



    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            if (_currentCoroutine == null)
                _currentCoroutine = StartCoroutine(StartShoot());

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            if (_currentCoroutine != null)
            {
                StopCoroutine(_currentCoroutine);
                _currentCoroutine = null;
            }

        }

    }

    IEnumerator StartShoot()
    {
        while(true)
        {
            Shoot();
            yield return new WaitForSeconds(timeBetweenShoot);
        }

    }



    public void Shoot()
    {

        var projectile = Instantiate(prefabProjectile);
        projectile.transform.position = positionToShoot.position;
        projectile.side = playerSideReference.transform.localScale.x;
    }

}
