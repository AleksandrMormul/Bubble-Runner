using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float speed = 100f;



    void Update()
    {

        //Keaboard input

        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            //transform.position = new Vector3(460, transform.position.y, transform.position.z);
            //transform.position += transform.right * speed * Time.deltaTime;
            //transform.position += direction * Time.deltaTime;
            //transform.position = Vector2.left * speed * Time.deltaTime;
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {   
            gameObject.transform.Translate(Vector2.down * speed * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        }

        

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }

    }


}
