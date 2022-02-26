using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public float power;
    Rigidbody2D rb;
   public  GameObject dot;
    public   int numberOfDots;
    GameObject[] dots;
    Vector2 whereToShoot;
    public float SpaceBetweenDots;
    Vector2 shootDir;
    public bool shoot = false;
    private void Update()
    {
        Shoot();
        for (int i = 0; i < numberOfDots; i++)
        {
            dots[i].transform.position = GetDotPosition(i* SpaceBetweenDots);
        }
    }

    private void Shoot()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        shootDir = mousePos - whereToShoot;
        transform.right = shootDir;
        if (Input.GetMouseButtonDown(0) && !shoot)
        {
            shoot = true;
            rb.velocity = transform.right * power;
            rb.isKinematic = false;
        }
        

    }

    Vector2 GetDotPosition(float t)
    {

        return (Vector2)whereToShoot + (shootDir.normalized * power * t) + 0.5f * Physics2D.gravity * t * t;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        whereToShoot = transform.position;
        dots = new GameObject[numberOfDots];
        for(int i = 0; i < dots.Length; i++)
        {
            dots[i]=Instantiate(dot, whereToShoot, Quaternion.identity);
            dots[i].transform.parent = transform;
        }
    }

}
