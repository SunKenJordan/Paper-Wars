using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
	public float Speed;
	private Vector3 lastCameraPosition;
	
	// Start is called before the first frame update
    void Start()
    {
		//lastCameraPosition = cameraTransform.position;
        //Sprite sprite = GetComponent<SpriteRenderer>().sprite;
		
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
		
		if(transform.position.y < -15)
		{
			transform.position = new Vector2((Random.Range(-7, 8)), 15);
		}
    }
}
