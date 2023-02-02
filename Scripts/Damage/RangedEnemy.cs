using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : Health
{
	public float Speed;
	private bool a = true;
	private bool b = false;
	public bool inPosition = false;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
		if(a == true && inPosition == true)
		{
			transform.Translate(Vector2.right * Speed * Time.deltaTime);
		}
		if(transform.position.x > 7)
		{
			a = false;
			b = true;
		}
		if(b == true && inPosition == true)
		{
			transform.Translate(Vector2.left * Speed * Time.deltaTime);
		}
		if(transform.position.x < -7)
		{
			b = false;
			a = true;
		}
		if(inPosition == false)
		{
			transform.Translate(Vector2.down * Speed * Time.deltaTime);
		}
		if(transform.position.y < 4)
		{
			inPosition = true;
		}
			
    }
}
