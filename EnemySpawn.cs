using System;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject Spawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(Spawn.gameObject, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
