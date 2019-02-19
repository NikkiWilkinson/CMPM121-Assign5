using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject sparkles;
    private int counter;
    public Component triggerEvent; 

    // Start is called before the first frame update
    void Start()
    {
        counter = 0; //internal counter
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 90*Time.deltaTime);
    }

    void OnTriggerEnter(Collider coin)
    {

    	if(coin.CompareTag("Player")){
            
            //create particles upon pickup
            Instantiate(sparkles, transform.position, transform.rotation);
            counter = counter + 1;
    		
            //destroy cake when player "collects" it
    		Destroy(gameObject);
			Debug.Log("Object destroyed");

    		//when player collides with cake object, add 1 point to score
    		coin.GetComponent<characterMovement>().points++;
    	}

        if(counter>=1)
        {
            triggerEvent.GetComponent<opendoor>().hasCoins = true;
            Debug.Log("I have enough coins.");
        }
    }
}


