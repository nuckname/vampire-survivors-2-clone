using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private EnemySpawner spawner;

    public float player_move_speed = 5f;
    private Rigidbody2D player_rb;
    Vector2 movement;

    void Awake()
    {
        player_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        player_rb.MovePosition(player_rb.position + movement * player_move_speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "enemy")
        {
            Destroy(gameObject);
            spawner.enabled = false;
        }
    }

    


}
