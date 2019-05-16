﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testscript : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    private float time = 0.0f;
    public float interpolationPeriod = 10.0f;


    // Start is called before the first frame update
    public void Start()
    {
        time += Time.deltaTime;
        GameObject theEnemy = GameObject.Find("Enemy");
        EnemyHealth enemy = theEnemy.GetComponent<EnemyHealth>();

        if (enemy.alive == true)
        {
            InvokeRepeating("Shoot", 0.3f, 0.3f);
        }
    }

    public void Shoot()
    {
        GameObject thePlayer = GameObject.Find("Enemy");
        EnemyHealth enemyHealth = thePlayer.GetComponent<EnemyHealth>();

        GameObject theTurret = GameObject.Find("Tank_Location");
        Tank_Location_Script turret = theTurret.GetComponent<Tank_Location_Script>();


        GameObject theTurret2 = GameObject.Find("Tank_Location_2");
        Tank_Location_Script turret2 = theTurret2.GetComponent<Tank_Location_Script>();

        GameObject theTurret3 = GameObject.Find("TurretTower");
        Tank_Location_Script turret3 = theTurret3.GetComponent<Tank_Location_Script>();

        GameObject theTurret4 = GameObject.Find("TurretTower_2");
        Tank_Location_Script turret4 = theTurret4.GetComponent<Tank_Location_Script>();

        GameObject theTurret5 = GameObject.Find("TurretTower_3");
        Tank_Location_Script turret5 = theTurret5.GetComponent<Tank_Location_Script>();

        GameObject theTurret6 = GameObject.Find("TurretTower_4");
        Tank_Location_Script turret6 = theTurret6.GetComponent<Tank_Location_Script>();

        GameObject theTurret7 = GameObject.Find("TurretTower_5");
        Tank_Location_Script turret7 = theTurret7.GetComponent<Tank_Location_Script>();

        GameObject theTurret8 = GameObject.Find("Tank_Location_3");
        Tank_Location_Script turret8 = theTurret8.GetComponent<Tank_Location_Script>();

        GameObject theTurret9 = GameObject.Find("TurretTower_6");
        Tank_Location_Script turret9 = theTurret9.GetComponent<Tank_Location_Script>();

        GameObject theTurret10 = GameObject.Find("TurretTower_7");
        Tank_Location_Script turret10 = theTurret10.GetComponent<Tank_Location_Script>();

        GameObject theTurret11 = GameObject.Find("TurretTower_8");
        Tank_Location_Script turret11 = theTurret11.GetComponent<Tank_Location_Script>();

        GameObject theTurret12 = GameObject.Find("TurretTower_9");
        Tank_Location_Script turret12 = theTurret12.GetComponent<Tank_Location_Script>();

        GameObject theTurret13 = GameObject.Find("TurretTower_10");
        Tank_Location_Script turret13 = theTurret13.GetComponent<Tank_Location_Script>();

        GameObject theTurret14 = GameObject.Find("TurretTower_11");
        Tank_Location_Script turret14 = theTurret14.GetComponent<Tank_Location_Script>();

        GameObject theTurret15 = GameObject.Find("TurretTower_12");
        Tank_Location_Script turret15 = theTurret15.GetComponent<Tank_Location_Script>();

        GameObject theTurret16 = GameObject.Find("TurretTower_13");
        Tank_Location_Script turret16 = theTurret16.GetComponent<Tank_Location_Script>();

        if (enemyHealth.alive == true && turret.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret.transform.position.x, turret.transform.position.y + 3, turret.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret2.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret2.transform.position.x, turret2.transform.position.y + 3, turret2.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret3.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret3.transform.position.x, turret3.transform.position.y + 3, turret3.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret4.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret4.transform.position.x, turret4.transform.position.y + 3, turret4.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret5.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret5.transform.position.x, turret5.transform.position.y + 3, turret5.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret6.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret6.transform.position.x, turret6.transform.position.y + 3, turret6.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret7.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret7.transform.position.x, turret7.transform.position.y + 3, turret7.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret8.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret8.transform.position.x, turret8.transform.position.y + 3, turret8.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret9.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret9.transform.position.x, turret9.transform.position.y + 3, turret9.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret10.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret10.transform.position.x, turret10.transform.position.y + 3, turret10.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret11.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret11.transform.position.x, turret11.transform.position.y + 3, turret11.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret12.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret12.transform.position.x, turret12.transform.position.y + 3, turret12.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret13.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret13.transform.position.x, turret13.transform.position.y + 3, turret13.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret14.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret14.transform.position.x, turret14.transform.position.y + 3, turret14.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret15.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret15.transform.position.x, turret15.transform.position.y + 3, turret15.transform.position.z), gameObject.transform.rotation);
        }

        if (enemyHealth.alive == true && turret16.isPlaced == true)
        {
            Instantiate(bulletPrefab, new Vector3(turret16.transform.position.x, turret16.transform.position.y + 3, turret16.transform.position.z), gameObject.transform.rotation);
        }
    }
}
