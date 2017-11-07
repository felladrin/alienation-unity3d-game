using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameOverScene : MonoBehaviour {
	void OnEnable () {
		EventManager.OnWorldDestroyed += EndGame;
	}
	
	void OnDisable () {
		EventManager.OnWorldDestroyed -= EndGame;
	}

	void EndGame() {
		SceneManager.LoadScene ("gameover");
	}
}
