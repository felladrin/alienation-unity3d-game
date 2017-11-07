using UnityEngine;

public class BulletCollision : MonoBehaviour {
	public int BulletForceAgainsMeteors;
	public GameObject Target;
	public GameObject Meteor;
	public GameObject ExplosionAnimation;
	public AudioClip ExplosionSound;

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == Target.tag || coll.gameObject.tag == Meteor.tag) {
			if (coll.gameObject.tag == Target.tag) {
				Destroy (coll.gameObject);
				EventManager.InvokeTargetDestroyed ();
			}

			if (coll.gameObject.tag == Meteor.tag) {
				coll.gameObject.GetComponent<Rigidbody2D> ().AddForceAtPosition (transform.up * BulletForceAgainsMeteors, transform.position);
			}

			var temporaryExplosionSound = new GameObject (name = "ExplosionSound");
			var audioSource = temporaryExplosionSound.AddComponent<AudioSource> ();
			audioSource.PlayOneShot (ExplosionSound);
			Destroy (temporaryExplosionSound, 2);

			var temporaryExplosionAnimation = Instantiate (ExplosionAnimation, coll.transform.position, Quaternion.identity);
			Destroy (temporaryExplosionAnimation, 2);

			Destroy (gameObject);
		}
	}
}
