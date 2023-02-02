using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : EnemyDamage
{
	public float speed = 10.0f;
	private Rigidbody2D rb;
	
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
		//this moves the enemy downwards
		rb.velocity = new Vector2(0, -speed);
    }

    // Update is called once per frame
    void Update()
    {
		//this destroys the object after it leaves the screen
        if(transform.position.y < -10)
			Destroy(this.gameObject);
    }
}
