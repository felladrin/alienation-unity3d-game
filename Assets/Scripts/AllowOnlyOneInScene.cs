using UnityEngine;

public class AllowOnlyOneInScene : MonoBehaviour {
	void Start () {
		if (GameObject.Find (gameObject.name) != gameObject) {
			Destroy (gameObject);
		}
	}
}
