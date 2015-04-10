using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    private float health = 3;

    public float movementSpeed;
    public float jumpSpeed;

    private float jumpTimer;
    protected float currJump = 0;
	// Use this for initialization
    public float Health
    {
        get { return health; }
        set { health = value; }
    }
	void Start () {
        jumpTimer = Random.Range(2, 5);
        
	}
	
	// Update is called once per frame
	void Update () {
        MoveLeft();
        Jump();
        IsItDeadYet();
	}
    void OnCollisionEnter(Collision _other)
    {
        if(_other.gameObject.tag == "Bullet")
        {
			health--;
        }
        else if (_other.gameObject.tag == "Spray")
        {

        }
        else if (_other.gameObject.tag == "Chill")
        {

        }
    }

    public void MoveLeft()
    {
        //gameObject.GetComponent<Rigidbody>().AddForce(-movementSpeed * Time.deltaTime, 0, 0, ForceMode.Acceleration);
        gameObject.GetComponent<Rigidbody>().AddForce(-movementSpeed , 0, 0, ForceMode.Acceleration);
    }

    public void Jump()
    {
        if (currJump >= jumpTimer)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, jumpSpeed, 0, ForceMode.Impulse);
            currJump = 0.0f;
            jumpTimer = Random.Range(2, 5);
        }
        else
        {
            currJump += Time.deltaTime;
        }
    }

    void IsItDeadYet()
    {
        if (health <= 0.0f)
        {
            //instansiate particle death effects

            //destroy object
            Destroy(gameObject);
        }
    }
    
}
