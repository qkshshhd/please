using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MoveSpeed = 4f;

    private Vector3 move;

    public float Damage = 3f;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        move = Vector3.left * MoveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += move * Time.deltaTime;
    }


    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            other.gameObject.GetComponent<Player>().Hp -= Damage;
        }

        if (other.gameObject.tag == "Weapon")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "LeftWall")
        {
            Destroy(gameObject);
        }
    }
}
