using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


[Header("challeng oobjoct gaem oobjact")]
public GameObject challengeObject;
[Header("defaylty  w aspan wa d3ea lay  atiem ")]
public float spawnDelay = 1f;
[Header("drqsutk as dah js ti ke ")]
public float spawnTime = 2f;


    // Start is called before the first frame update
    void Start()
    {


InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);
























    }

    // Update is called once per frame
    void Update()
    {


transform.position = new Vector3(15, -2.75f, 0);
















    }



void InstantiateObjects()
{


Instantiate(challengeObject, transform.position, transform.rotation);










}








}
