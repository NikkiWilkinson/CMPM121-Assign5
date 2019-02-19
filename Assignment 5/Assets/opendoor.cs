using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{

	public Animation doorup;
	public bool hasCoins = false;

    // Update is called once per frame
    void Update()
    {
        if(hasCoins==true)
        {
        	doorup.Play();
    	}
    }
}
