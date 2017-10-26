using UnityEngine;
using System.Collections;

public class PipeTransform : MonoBehaviour {
	public float deadEnd;
	public float speed;
	// Use this for initialization

	void Update () {
		Vector2 position = transform.position;
		if (position.x < deadEnd) {
			Destroy(gameObject);
			return;
		}
		transform.Translate (-speed*Time.deltaTime ,0 , 0);
	}

	void OnTriggerEnter2D(Collider2D other){
		Application.LoadLevel(Application.loadedLevelName);
	}
}
