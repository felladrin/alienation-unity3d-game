using UnityEngine;

public class MoveHorizontalyRandomly : MonoBehaviour {
	public bool MovingToRightDirection;
	public float Speed;

	void Start () {
		InvokeRepeating ("MaybeChangeDirection", 3, 3);
	}
	
	void FixedUpdate () {
		if (MovingToRightDirection) {
			transform.Translate (Vector3.right * Speed * Time.deltaTime);
		} else {
			transform.Translate (Vector3.left * Speed * Time.deltaTime);
		}
	}

	void MaybeChangeDirection() {
		if (Random.value > 0.5) {
			MovingToRightDirection = !MovingToRightDirection;
		}
	}
}
