using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Target;
    public GameObject Player;
    private Vector3 offset;

    private bool check = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (check)
        {
            transform.position = Player.transform.position + offset;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            check = false;
        }
    }
}


