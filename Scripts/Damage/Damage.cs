using UnityEngine;

public class Damage : MonoBehaviour
{
   [SerializeField] protected float damage;
   
   protected void OnTriggerEnter2D(Collider2D collision)
   {
	   
	   if(collision.tag == "Enemy" && this.gameObject.tag == "Projectile")
	   {
		  collision.GetComponent<Health>().TakeDamage(damage);
		  Destroy(this.gameObject);
	   }
   }
}