using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextSceneOnClick : MonoBehaviour {
	void Update () {
		if (Input.GetMouseButtonDown (0) || Input.GetMouseButtonDown (1) || Input.GetMouseButtonDown (2)) {
			if (SceneManager.GetActiveScene ().buildIndex == SceneManager.sceneCountInBuildSettings - 1) {
				SceneManager.LoadScene (0);
			} else {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			}
		}
	}
}
