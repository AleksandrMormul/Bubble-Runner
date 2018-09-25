using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {



    void Update()
    {
        //Keaboard input
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.position = new Vector3(460, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {   
            transform.position = new Vector3(150, transform.position.y, transform.position.z);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        }

    }
}
