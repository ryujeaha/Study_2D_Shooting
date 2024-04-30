using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy_spawn : MonoBehaviour
{
    public float co_spawn_speed;
    public float  spawn_speed;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Spawn(){
        Instantiate(Enemy,new Vector3(Random.Range(-10f,11f),gameObject.transform.position.y,0),Quaternion.Euler(0,0,180));
        spawn_speed = co_spawn_speed;
    }
    // Update is called once per frame
    void Update()
    {
        spawn_speed -= Time.deltaTime;
        if(spawn_speed <= 0){
            Spawn();
        }
    }
}
