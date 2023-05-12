using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour 
{
	public float speed;
						
	void Update () 
	{
		transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
	}

	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
			
	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.GetComponent<HealthComponent>() != null)
		{
			other.GetComponent<HealthComponent>().TakeDamage(50);
		}



		if (other.tag == "Enemy")
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}
