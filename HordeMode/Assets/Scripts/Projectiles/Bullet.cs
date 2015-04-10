using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	private float speed = 7f;

	// Use this for initialization
	void Start ()
	{
		Destroy (gameObject, 4);

	}

	// Update is called once per frame
	void Update ()
	{

		transform.Translate (new Vector3 (0.0f, 0.0f, speed * Time.deltaTime));
	}

	void OnCollisionEnter (Collision _other)
	{
		Destroy (gameObject);
	}

    
}
