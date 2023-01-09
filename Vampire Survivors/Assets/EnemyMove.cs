using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;

    [SerializeField] private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        //Find player
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;

    }

    // Update is called once per frame
    void Update()
    {
        //
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);

        if(IsAWall())
        {
            transform.rotation = Quaternion.LookRotation(movement);
            transform.localRotation *= Quaternion.Euler(0,90,90);
        }
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Player"))
        {
            moveSpeed = 0;
        }
    }

    public bool IsAWall(){
        return moveSpeed != 0;
    }
}
