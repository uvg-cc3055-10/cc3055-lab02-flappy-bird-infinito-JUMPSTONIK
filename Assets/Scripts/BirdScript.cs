using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float jumpForce = 200f;
    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    void Update() {
        if (GameController.instancia.gameOver == false)
        {


            if (Input.GetButtonDown("Jump")) {
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * jumpForce);
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.instancia.gameOver = true;
        ScrollingBackground.scrollingSpeed = 0;
        Column.scrollingSpeed = 0;
        ColumnSpawner.spawnTime = 10000000;
    }
}
