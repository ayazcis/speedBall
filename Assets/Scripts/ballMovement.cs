using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    static public float speed = 5.0f;



    void Update()
    {
        // oyun bitmediði anlarda hýzý arttýrmak
        if(speed != 0.0f)
		{
            speed +=0.6f* Time.deltaTime;
		}
        transform.position = new Vector3(transform.position.x + (speed  * Time.deltaTime), transform.position.y, transform.position.z);
		// sað sol hareketleri oyun ilerliyorken
		if (speed != 0.0f)
		{
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -0.13f);

            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 1.30f);

            }
        }
        
    }
}
