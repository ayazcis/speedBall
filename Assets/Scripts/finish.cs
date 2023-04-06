using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
	public Canvas finishCanvas;
	private int finished = 0; // oyunun bitip bitmediði kontrolü
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("ball"))
		{
			ballMovement.speed = 0.0f;
			finishCanvas.gameObject.SetActive(true);
			finished = 1;
		}
	}
	private void Update()
	{
		if (finished == 1)
		{
			if (Input.GetKey(KeyCode.Space))
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
				finished = 0;
				ballMovement.speed = 5.0f;
				finishCanvas.gameObject.SetActive(false);
			}
		}
	}
}
