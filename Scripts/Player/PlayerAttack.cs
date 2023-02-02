using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
	[SerializeField] private Transform firePoint;
	public GameObject projectile;
	private bool IsAvailable = true;
    public float CooldownDuration = 1.0f;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButton("Fire1"))
		{
			//this is used for the attack cooldown
			if (IsAvailable == false)
			{
				return;
			}
		 
		 
			BasicAttack();
			//starts cooldown timer
			StartCoroutine(StartCooldown());
		} 
    }
	
	private void BasicAttack()
	{
		//creates the attack at the firepoint
		GameObject a = Instantiate(projectile) as GameObject;
		a.transform.position = firePoint.position;
	}
	
	private IEnumerator StartCooldown()
     {
         IsAvailable = false;
         yield return new WaitForSeconds(CooldownDuration);
         IsAvailable = true;
     }
}
