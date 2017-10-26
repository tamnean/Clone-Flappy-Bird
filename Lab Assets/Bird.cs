using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
	private Rigidbody2D rg2d;
	private int jumpHigh= 4;
	private Animator animator;

	private AudioSource audioSource;

	public AudioClip flapSound;



	// Use this for initialization
	void Start () {
		rg2d = GetComponent <Rigidbody2D> ();
		animator = GetComponent<Animator>();
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		bool keyDown = Input.GetKeyDown (KeyCode.Space);
		bool mouseDown = Input.GetMouseButtonDown(0);

		if(keyDown || mouseDown){
			rg2d.velocity = Vector2.up*jumpHigh;
			animator.SetTrigger("FlapPush");
			audioSource.PlayOneShot(flapSound);
			faceUp();
		}
		else
			faceDown();
	}

	void faceDown()
	{
		float zAngle = transform.eulerAngles.z;
		if(zAngle>180)
			zAngle = zAngle-360;

		if(zAngle > -45 )
			transform.Rotate(0,0,-2);

	}

	void faceUp()
	{
		float zAngle = transform.eulerAngles.z;
		transform.Rotate(0,0, 30 - zAngle);
		
	}

	void OnCollisionEnter2D (Collision2D other){

	}
	
}
