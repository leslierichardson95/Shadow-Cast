using UnityEngine;
using System.Collections;

public class SwordTriggerAI : MonoBehaviour {

	public float swordDamage;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			PlayerHealth hurtPlayer = other.gameObject.GetComponent<PlayerHealth> ();
			hurtPlayer.addDamage (swordDamage);
		}
	}
}
