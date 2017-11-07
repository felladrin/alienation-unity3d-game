using UnityEngine;

public class RotateInLoop : MonoBehaviour {
	public float MinAngle;
	public float MaxAngle;
	public bool TurningClockwise;

	void Update () {
		var eulerRotationZ = transform.rotation.eulerAngles.z;
		if (TurningClockwise) {
			if (eulerRotationZ > 180 && eulerRotationZ < MinAngle) {
				TurningClockwise = !TurningClockwise;
			} else {
				transform.Rotate (Vector3.forward, -1);
			}
		} else {
			if (eulerRotationZ < 180 && eulerRotationZ > MaxAngle) {
				TurningClockwise = !TurningClockwise;
			} else {
				transform.Rotate (Vector3.forward, 1);
			}
		}
	}
}
