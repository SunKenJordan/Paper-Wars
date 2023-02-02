using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
   [Header ("Health")] 
   [SerializeField] private float startingHealth;
   public float currentHealth { get; private set; }
   private Animator anim;
   public bool dead;
   
   [Header ("iFrames")]
   [SerializeField] private float iFramesDuration;
   [SerializeField] private int numberOfFlashes;
   private SpriteRenderer spriteRend;
   
   
   
   private void Awake()
   {
	   currentHealth = startingHealth;
	   anim = GetComponent<Animator>();
	   spriteRend = GetComponent<SpriteRenderer>();
   }
   
   public void TakeDamage(float _damage)
   {
	   currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
	   
	   if(currentHealth > 0.1)
	   {
		   //anim.SetTrigger("hurt");
		   StartCoroutine(Invunerability());
	   }
	   else
	   {
		   if(!dead && this.gameObject.tag == "Player")
			{
				//anim.SetTrigger("die");
				GetComponent<PlayerController>().enabled = false;
				dead = true;
				gameObject.SetActive(false);
				
			}
			else
			{
				Destroy(this.gameObject);
				GameObject.Find("Player").GetComponent<Score>().scoreNum +=1;
				FindObjectOfType<AudioManager>().Play("EnemyDeath");
				
			}
	   }	
   }
   
   public void AddHealth(float _value)
   {
	   currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
   }
   
   private IEnumerator Invunerability()
   {
	   Physics2D.IgnoreLayerCollision(7, 8, true);
	   for (int i = 0; i < numberOfFlashes; i++)
	   {
		   spriteRend.color = new Color(1,0,0, 0.5f);
		   yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
		   spriteRend.color = Color.white;
		   yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
		   
	   }
	   Physics2D.IgnoreLayerCollision(7, 8, false);
   }
   
   private void LateUpdate()
   {
	   if (Input.GetKey("p"))
		{
			TakeDamage(1);
		}
		
		
   }
   
}
