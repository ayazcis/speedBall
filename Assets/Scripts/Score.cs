using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public  TextMeshProUGUI score ;
    private double scoreAmount;
	// Update is called once per frame
	private void Start()
	{
		scoreAmount = 0.0f;
	}
	void Update()
    {
		//platformda alýnan yol kadar skor
			score.text = "Score: " + (int)scoreAmount;
			scoreAmount = transform.position.x - 0.18;
		

    }
}
