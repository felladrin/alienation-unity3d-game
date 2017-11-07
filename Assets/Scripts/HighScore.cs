using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HighScore : MonoBehaviour {
	Text textComponent;

	void Awake() {
		textComponent = GetComponent<Text> ();
	}

	void Start () {
		textComponent.text = "HighScore " + PlayerPrefs.GetInt ("HighScore");
	}
}
