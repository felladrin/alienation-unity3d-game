using UnityEngine;

public class BulletMovement : MonoBehaviour {
	public float Speed;

	void FixedUpdate () {
		transform.Translate (Vector3.up * Speed * Time.deltaTime);
	}
}
