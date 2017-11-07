using UnityEngine;
using System.Collections;

public class WorldCollision : MonoBehaviour
{
	public GameObject Target;
	public GameObject Meteor;
	public GameObject ExplosionAnimation;
	public AudioClip ExplosionSound;

	SpriteRenderer spriteRenderer;

	void Awake () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.tag == Target.tag || coll.gameObject.tag == Meteor.tag) {
			var temporaryGameObject = new GameObject (name = "ExplosionSound");
			var audioSource = temporaryGameObject.AddComponent<AudioSource> ();
			audioSource.PlayOneShot (ExplosionSound);
			Destroy (temporaryGameObject, 2);

			var temporaryExplosionAnimation = Instantiate (ExplosionAnimation, coll.transform.position, Quaternion.identity);
			Destroy (temporaryExplosionAnimation, 2);

			Destroy (coll.gameObject);

			EventManager.InvokeWorldHit ();

			StartCoroutine (Blink (1));
		}
	}

	IEnumerator Blink (float waitTime)
	{
		var endTime = Time.time + waitTime;
		while (Time.time < endTime) {
			spriteRenderer.enabled = false;
			yield return new WaitForSeconds (0.1f);
			spriteRenderer.enabled = true;
			yield return new WaitForSeconds (0.1f);
		}
	}
}
