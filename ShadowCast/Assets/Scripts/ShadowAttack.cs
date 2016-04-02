using UnityEngine;
using System.Collections;

public class ShadowAttack : MonoBehaviour {

	private bool attacking = false;

	private float attackTimer = 0;
	public float attackCoolDown;

	public Collider2D swordTrigger;

	// Use this for initialization
	void Start () {
		swordTrigger.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void attack(float damage) {
		attacking = true;
		attackTimer = attackCoolDown;

		swordTrigger.enabled = true;
		if (attacking) {
			gameObject.GetComponent<Animator> ().Play ("Attack2");
			if (attackTimer > 0) {
				attackTimer -= Time.deltaTime;
			} 
			else {
				attacking = false;
				swordTrigger.enabled = false;
			}
		}
	}
}
