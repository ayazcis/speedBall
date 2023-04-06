using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
	public Canvas canvas; // game over canvas�
	public int collided = 0; // oyunun durup durmad���n� kontrol 

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("obstacle"))
		{
			
			ballMovement.speed = 0.0f;
			canvas.gameObject.SetActive(true);
			collided = 1;
		}
	}
	private void Update()
	{
		if (collided == 1)
		{
			if (Input.GetKey(KeyCode.Space))
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
				collided = 0;
				ballMovement.speed = 5.0f;
				canvas.gameObject.SetActive(false);
			}
		}
	}
}
