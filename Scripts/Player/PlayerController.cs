using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Rigidbody2D rb2D;
	public float sidewaysForce = 500f;
	
	
	private void Awake()
	{
		
	}
	
    private void FixedUpdate()
    {
       if (Input.GetKey("d"))
		{
			rb2D.AddForce(new Vector2(sidewaysForce * Time.deltaTime, 0));
		}
		
		if (Input.GetKey("a"))
		{
			rb2D.AddForce(new Vector2(-sidewaysForce * Time.deltaTime, 0));
		}
    }
}
