using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ShootOnClick : MonoBehaviour {
	public GameObject Bullet;
	public float DelayBetweenShots;

	float timeSinceLastShot;
	AudioSource audioSource;

	void Start() {
		audioSource = GetComponent<AudioSource> ();
	}
	
	void Update () {
		timeSinceLastShot += Time.deltaTime;

		if ((Input.GetMouseButtonDown (0) || Input.GetMouseButtonDown (1) || Input.GetMouseButtonDown (2)) && (timeSinceLastShot > DelayBetweenShots)) {
			Instantiate (Bullet, transform.position, transform.rotation);
			audioSource.Play ();
			timeSinceLastShot = 0;
		}
	}
}
