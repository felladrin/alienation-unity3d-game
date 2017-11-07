using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Score : MonoBehaviour {
	public string Prefix;
	public int PointsToAdd;

	int CurrentValue;
	Text textComponent;

	void Awake() {
		textComponent = GetComponent<Text> ();
	}

	void OnEnable () {
		EventManager.OnTargetDestroyed += Increase;
	}
	
	void OnDisable () {
		EventManager.OnTargetDestroyed -= Increase;
	}

	void Increase() {
		CurrentValue += PointsToAdd;

		if (textComponent != null) {
			textComponent.text = Prefix + CurrentValue;
		}

		if (CurrentValue > PlayerPrefs.GetInt("HighScore")) {
			PlayerPrefs.SetInt("HighScore", CurrentValue);
		}
	}
}
