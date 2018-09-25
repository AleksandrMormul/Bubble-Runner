using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

    public float speed = 1f;
    private bool leftClick2 = false;
    private bool leftClick5 = false;
    private bool leftClick8 = false;
    private bool leftClick3 = false;
    private bool leftClick6 = false;
    private bool leftClick9 = false;
    private bool rightClick1 = false;
    private bool rightClick4 = false;
    private bool rightClick7 = false;
    private bool rightClick2 = false;
    private bool rightClick5 = false;
    private bool rightClick8 = false;
    private bool upClick4 = false;
    private bool upClick5 = false;
    private bool upClick6 = false;
    private bool upClick7 = false;
    private bool upClick8 = false;
    private bool upClick9 = false;
    private bool downClick1 = false;
    private bool downClick2 = false;
    private bool downClick3 = false;
    private bool downClick4 = false;
    private bool downClick5= false;
    private bool downClick6 = false;

    public Transform startPosition;
    public Transform position1;
    public Transform position2;
    public Transform position3;
    public Transform position4;
    public Transform position5;
    public Transform position6;
    public Transform position7;
    public Transform position8;
    public Transform position9;
    float startTime;
    float totalDisctanceToDestination;

     
    private GameManager _gameManager;
    public static bool dead;
    public static bool isWin;
    public static bool progressToWin;
    public static bool isPause;


    private void Start()
    {
        startPosition.position = position5.position;
        dead = false;
        isWin = false;
        progressToWin = false;
        isPause = false;
        
        startTime = Time.time;
        totalDisctanceToDestination = Vector3.Distance(startPosition.position, position4.position);
        


    }

   
    void Update()
    {
       

            //LEFT
            if (leftClick5 == true)
        {

            //gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);

            //float currentDuration = Time.time - startTime;
            //float journeyFraction = currentDuration / totalDisctanceToDestination;
            //transform.position = Vector3.Lerp(startPosition.position, Vector3.left, journeyFraction);

            //transform.Translate (0,-2,0);

                transform.position = Vector3.MoveTowards(transform.position, position4.position, speed * Time.deltaTime);
        }
        if (leftClick2 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position1.position, speed * Time.deltaTime);
        }
        if (leftClick8 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position7.position, speed * Time.deltaTime);
        }
        if (leftClick3 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position2.position, speed * Time.deltaTime);
        }
        if (leftClick6 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position5.position, speed * Time.deltaTime);
        }
        if (leftClick9 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position8.position, speed * Time.deltaTime);
        }

        //RIGHT
        if (rightClick1 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position2.position, speed * Time.deltaTime);
        }
        if (rightClick4 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position5.position, speed * Time.deltaTime);
        }
        if (rightClick7 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position8.position, speed * Time.deltaTime);
        }
        if (rightClick2 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position3.position, speed * Time.deltaTime);
        }
        if (rightClick5 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position6.position, speed * Time.deltaTime);
        }
        if (rightClick8 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position9.position, speed * Time.deltaTime);
        }

        //UP
        if (upClick4 == true)
        {
           transform.position = Vector3.MoveTowards(transform.position, position1.position, speed * Time.deltaTime);
        }
        if (upClick5 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position2.position, speed * Time.deltaTime);
        }
        if (upClick6 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position3.position, speed * Time.deltaTime);
        }
        if (upClick7 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position4.position, speed * Time.deltaTime);
        }
        if (upClick8 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position5.position, speed * Time.deltaTime);
        }
        if (upClick9 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position6.position, speed * Time.deltaTime);
        }
        //DOWN
        if (downClick1 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position4.position, speed * Time.deltaTime);
        }
        if (downClick2 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position5.position, speed * Time.deltaTime);
        }
        if (downClick3 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position6.position, speed * Time.deltaTime);
        }
        if (downClick4 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position7.position, speed * Time.deltaTime);
        }
        if (downClick5 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position8.position, speed * Time.deltaTime);
        }
        if (downClick6 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position9.position, speed * Time.deltaTime);
        }


        if(MobileInput.Instance.SwipeLeft){

            if (transform.position == startPosition.position)
            {
                toFalse();
                leftClick5 = true;
            }
            if (transform.position == position2.position)
            {
                toFalse();
                leftClick2 = true;
            }
            if (transform.position == position8.position)
            {
                toFalse();
                leftClick8 = true;
            }
            if (transform.position == position3.position)
            {
                toFalse();
                leftClick3 = true;
            }
            if (transform.position == position6.position)
            {
                toFalse();
                leftClick6 = true;
            }
            if (transform.position == position9.position)
            {
                toFalse();
                leftClick9 = true;
            }
        }
        if (MobileInput.Instance.SwipeRight)   
        {

            if (transform.position == position1.position)
            {
                toFalse();
                rightClick1 = true;
            }
            if (transform.position == position4.position)
            {
                toFalse();
                rightClick4 = true;
            }
            if (transform.position == position7.position)
            {
                toFalse();
                rightClick7 = true;
            }
            if (transform.position == position2.position)
            {
                toFalse();
                rightClick2 = true;
            }
            if (transform.position == position5.position)
            {
                toFalse();
                rightClick5 = true;
            }
            if (transform.position == position8.position)
            {
                toFalse();
                rightClick8 = true;
            }
        }
        if (MobileInput.Instance.SwipeUp)
        {
            
            if (transform.position == position4.position)
            {
                toFalse();
                upClick4 = true;
            }
            if (transform.position == position5.position)
            {
                toFalse();
                upClick5 = true;
            }
            if (transform.position == position6.position)
            {
                toFalse();
                upClick6 = true;
            }
            if (transform.position == position7.position)
            {
                toFalse();
                upClick7 = true;
            }
            if (transform.position == position8.position)
            {
                toFalse();
                upClick8 = true;
            }
            if (transform.position == position9.position)
            {
                toFalse();
                upClick9 = true;
            }
        }
        if (MobileInput.Instance.SwipeDown)
        {
            if (transform.position == position1.position)
            {
                toFalse();
                downClick1 = true;
            }
            if (transform.position == position2.position)
            {
                toFalse();
                downClick2 = true;
            }
            if (transform.position == position3.position)
            {
                toFalse();
                downClick3 = true;
            }
            if (transform.position == position4.position)
            {
                toFalse();
                downClick4 = true;
            }
            if (transform.position == position5.position)
            {
                toFalse();
                downClick5 = true;
            }
            if (transform.position == position6.position)
            {
                toFalse();
                downClick6 = true;
            }
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

    public void toFalse(){
         leftClick2 = false;
     leftClick5 = false;
     leftClick8 = false;
     leftClick3 = false;
     leftClick6 = false;
     leftClick9 = false;
     rightClick1 = false;
     rightClick4 = false;
     rightClick7 = false;
     rightClick2 = false;
     rightClick5 = false;
     rightClick8 = false;
     upClick4 = false;
     upClick5 = false;
     upClick6 = false;
     upClick7 = false;
     upClick8 = false;
     upClick9 = false;
     downClick1 = false;
     downClick2 = false;
     downClick3 = false;
     downClick4 = false;
     downClick5 = false;
     downClick6 = false;
    }


  
    private void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.gameObject.tag == "Arrow")
             {
                 Debug.Log("DEAD!!!");
                 dead = true;
            
             }
        if (other.gameObject.tag == "Gold" )
        {
            ProgressWinGame.Instance.howGoldToWin--;
            SpawnGolds.Instance.goldSpawn();
            Destroy (other.gameObject);
            ScoreTextScript.goldCount++;
           
        
            if (ScoreTextScript.goldCount == 4)
                isWin = true;
            
            Debug.Log("GOLD = " + ScoreTextScript.goldCount);
        }
        
       
       
    }

}
