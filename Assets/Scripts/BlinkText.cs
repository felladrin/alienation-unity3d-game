using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class BlinkText : MonoBehaviour {
	public float Speed;

	Text textComponent;

	void Start() {
		textComponent = GetComponent<Text> ();
	}
	
	void Update () {
		Color newColor = new Color(textComponent.color.r, textComponent.color.g, textComponent.color.b, Mathf.PingPong(Time.time * Speed, 1));
		textComponent.color = newColor;
	}
}
