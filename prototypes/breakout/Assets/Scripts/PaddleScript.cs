using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    float speed = 18;
    float slowspeed = 18;
    float fastSpeed = 40;
    bool slowed = false;
    float timeSlowed = 0;

    bool OOB = false;

    [SerializeField]
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < -15)
        {
            rb.MovePosition(new Vector3(-15, 0, 0));
            OOB = true;
        }
        else if (transform.position.x > 28)
        {
            rb.MovePosition(new Vector3(28, 0, 0));
            OOB = true;

        }
        else
        {
            OOB = false;
        }

        //if left is pressed move left
        if (Input.GetKey(KeyCode.LeftArrow) && OOB == false)
        {
            Vector3 newPosition = transform.position;
            newPosition.x -= speed * Time.deltaTime;
            transform.position = newPosition;
        }

        //if left is pressed move left
        if (Input.GetKey(KeyCode.RightArrow) && OOB == false)
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
            GameObject.Find("Paddle").GetComponent<Renderer>().material.color = new Color32(200, 100, 100, 0);
            timeSlowed += Time.deltaTime;
            if(timeSlowed >= 2.5)
            {
                speed = slowspeed;
                slowed = false;
                timeSlowed = 0;
            }
        }
        else
        {
            GameObject.Find("Paddle").GetComponent<Renderer>().material.color = new Color32(50, 50, 200, 1);

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

