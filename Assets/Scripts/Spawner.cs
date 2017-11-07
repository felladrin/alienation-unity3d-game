using UnityEngine;

public class Spawner : MonoBehaviour {
	public Transform enemy;
	public float minTimeToRespawn;
	public float maxTimeToRespawn;

	void Start ()
	{
		InvokeRepeating("spawn", 1, Random.Range(maxTimeToRespawn, minTimeToRespawn));
	}

	void spawn ()
	{
		Instantiate(enemy, transform.position, transform.rotation);
	}
}