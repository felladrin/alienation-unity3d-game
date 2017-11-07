using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class WorldLife : MonoBehaviour {
	public int HitPoints;
	public int PointsToDecreaseWhenHit;
	public string Prefix;

	Text textComponent;

	void Awake() {
		textComponent = GetComponent<Text> ();
	}

	void OnEnable () {
		EventManager.OnWorldHit += Decrease;
	}
	
	void OnDisable () {
		EventManager.OnWorldHit -= Decrease;
	}

	void Decrease() {
		HitPoints -= PointsToDecreaseWhenHit;

		if (HitPoints <= 0) {
			EventManager.InvokeWorldDestroyed ();
		}

		if (textComponent != null) {
			textComponent.text = Prefix + HitPoints + "%";
		}
	}
}
