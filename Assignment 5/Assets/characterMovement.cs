using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour
{

    private float speed = 5;
    private float turnspeed = 90f;
    private float rotateAmount;

    public int points = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 1.12f, -28f);

    }

    // Update is called once per frame
    void Update()
    {

    	//enable mouse tracking for first person POV
    	float translation = Input.GetAxis("Vertical") * speed;
    	float strafe = Input.GetAxis("Horizontal") * speed;
    	translation *= Time.deltaTime;
    	strafe *= Time.deltaTime;

    	transform.Translate(strafe, 0, translation);


    	//movement
        Vector3 direction = Vector3.zero;
        rotateAmount = turnspeed * Time.deltaTime;

        if(Input.GetKey(KeyCode.A)) 
        {
            transform.Rotate(0, -rotateAmount, 0);
            //direction.x = 1;
          //  Debug.Log("Pressed A. I move left!");
        }
        if(Input.GetKey(KeyCode.D))
        {
          //  Debug.Log("Pressed D. I move right!");
          //  direction.x = -1;
            transform.Rotate(0, rotateAmount, 0);
        }
        if(Input.GetKey(KeyCode.W)) 
        {
          //  Debug.Log("Pressed W. I move forward!");
            direction.z = 1;
        }
        if(Input.GetKey(KeyCode.S)) 
        {
         //   Debug.Log("Pressed S. I move back!");
            direction.z = -1;
        }

        transform.Translate(direction.normalized * Time.deltaTime * speed);
    }

    //increase points on GUI for player to see
    private void OnGUI()
    {
    	GUI.Label(new Rect(20, 20, 100, 100), "Coins: " + points);
    }
}
