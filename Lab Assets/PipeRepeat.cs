using UnityEngine;
using System.Collections;

public class PipeRepeat : MonoBehaviour {
	public Transform original;
	public float yMax;
	public float yMin;
	public float deley;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("repeatPipe" , 1 , deley);

	}

	void repeatPipe(){
		Vector3 position = original.position;

		position.y = Random.Range (yMax, yMin);
		GameObject.Instantiate(original, position , Quaternion.identity);
	}
}
