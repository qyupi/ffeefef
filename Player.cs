using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform shootPoint;
    public Projectile projectilePrefab;
    public int points;
    public float shootInterval;
    public float shootTimer;
    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        shootTimer -= Time.deltaTime;
        Shoot();
    }
    void Shoot()
    {



        if (shootTimer <= 0)
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            shootTimer = shootInterval;
        }

    }



}