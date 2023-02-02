using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : Projectile
{
	[SerializeField] private Transform firePoint;
	public GameObject projectile;
	private bool IsAvailable = true;
    public float CooldownDuration = 1.0f;
	public RangedEnemy rE;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		{
			//this is used for the attack cooldown
			if (IsAvailable == false || rE.GetComponent<RangedEnemy>().inPosition == false)
			{
				return;
			}
		 
		 
			BasicAttack();
			//starts cooldown timer
			StartCoroutine(StartCooldown());
		} 
    }
	
	public void BasicAttack()
	{
		//creates the attack at the firepoint
		GameObject a = Instantiate(projectile) as GameObject;
		a.transform.position = firePoint.position;
	}
	
	public IEnumerator StartCooldown()
     {
         IsAvailable = false;
         yield return new WaitForSeconds(CooldownDuration);
         IsAvailable = true;
     }
}
