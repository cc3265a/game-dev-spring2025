using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    float speed = 18;
    float slowspeed = 18;
    float fastSpeed = 40;
    bool slowed = false;
    float timeSlowed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if left is pressed move left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 newPosition = transform.position;
            newPosition.x -= speed * Time.deltaTime;
            transform.position = newPosition;
        }

        //if left is pressed move left
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 newPosition = transform.position;
            newPosition.x -= -speed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (slowed == false)
            {
                speed = fastSpeed;
            }
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = slowspeed;
        }


        if (slowed)
        {
            timeSlowed += Time.deltaTime;
            if(timeSlowed >= 2.5)
            {
                speed = slowspeed;
                slowed = false;
                timeSlowed = 0;
            }
        }

        GameManager.SharedInstance.GetPaddlePos(transform.position);

    }
    private void OnTriggerEnter(Collider other)
    {
        //print("brick hit!");

        if (other.gameObject.CompareTag("Brick1"))
        {
            //print("watch your head!");
            speed = 10;
            slowed = true;
        }

    }


}
