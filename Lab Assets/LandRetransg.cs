using UnityEngine;
using System.Collections;

public class LandRetransg : MonoBehaviour {
	public float speed;
	public float deadEnd;
	public float rePosition;

	// Update is called once per frame
	void Update () {
		Vector2 position = transform.position;
		if (position.x < deadEnd)
			transform.Translate (rePosition, 0, 0);

		transform.Translate (-speed * Time.deltaTime, 0, 0);
	}
}
