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
		//platformda al�nan yol kadar skor
			score.text = "Score: " + (int)scoreAmount;
			scoreAmount = transform.position.x - 0.18;
		

    }
}
