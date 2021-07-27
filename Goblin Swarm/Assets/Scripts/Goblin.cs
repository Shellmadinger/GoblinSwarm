using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour
{
    public Transform objectLook;
    public float goblinSpeed;
    float killedByBullet;
    float killedTank;

    // Update is called once per frame
    void Update()
    {
        MoveTowardsObject();
    }

    void MoveTowardsObject()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, objectLook.position);
        transform.position = Vector2.MoveTowards(transform.position, objectLook.position, goblinSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            FindObjectOfType<HudManager>().IncreaseScore();
            Destroy(gameObject);  
        }

    }
}
