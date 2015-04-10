using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
    public bool gameOver;
	void OnTriggerEnter(Collider _other)
    {
        if(_other.gameObject.tag == "Enemy")
        {
            gameOver = true;
        }
    }

    void OnGUI()
    {
        if(gameOver)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, Screen.width / 2, Screen.height / 2), "GameOver!");
        }
    }
}
