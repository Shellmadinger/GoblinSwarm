using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*bulletSpeed);
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goblin")
        {
            Destroy(gameObject);
        }
    }
}
