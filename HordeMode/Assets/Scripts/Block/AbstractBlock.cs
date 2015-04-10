using UnityEngine;
using System.Collections;

public class AbstractBlock : MonoBehaviour
{
	public int level;
	public int health;
	Color defaultColor = Color.white;

	// Use this for initialization
	void Start ()
	{
		setColor(defaultColor);
		level = 0;
		health = 0;
	}

	void OnMouseOver() {
		setColor (Color.red);
	}
	void OnMouseExit() {
		setColor (defaultColor);
	}
	
	void setColor (Color newColor)
	{
		gameObject.GetComponent<Renderer> ().material.color = newColor;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

