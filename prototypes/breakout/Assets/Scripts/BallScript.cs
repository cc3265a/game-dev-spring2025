using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    public int Lives = 5;

    int brickSpeed = 0;

    float speedInc = 1.5f;
    float speedDec = 0.7f;
    float speedMax = 20f;
    float speedMin = 10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballBegins();

    }

    // Update is called once per frame
    void Update()
    {
        //print(rb.linearVelocity);
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 oldVelocity = rb.linearVelocity;
        GameManager.SharedInstance.checkBrickCount();


        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);

            if (brickSpeed > 0)
            {
                brickSpeed--;
                rb.linearVelocity = new Vector3(oldVelocity.x * speedDec, oldVelocity.y * speedDec, oldVelocity.z * speedDec);
            }

        }
        else if (collision.gameObject.CompareTag("Brick1"))
        {
            Destroy(collision.gameObject);

            if (brickSpeed > 1)
            {
                rb.linearVelocity = new Vector3(oldVelocity.x * speedDec, oldVelocity.y * speedDec, oldVelocity.z * speedDec);
                brickSpeed--;
            }
            else if (brickSpeed < 1)
            {
                rb.linearVelocity = new Vector3(oldVelocity.x * speedInc, oldVelocity.y * speedInc, oldVelocity.z * speedInc);
                brickSpeed++;
            }
        }
        else if (collision.gameObject.CompareTag("Brick2"))
        {
            Destroy(collision.gameObject);

            if (brickSpeed > 2)
            {
                rb.linearVelocity = new Vector3(oldVelocity.x * speedDec, oldVelocity.y * speedDec, oldVelocity.z * speedDec);
                brickSpeed--;
            }
            else if (brickSpeed < 2)
            {
                rb.linearVelocity = new Vector3(oldVelocity.x * speedInc, oldVelocity.y * speedInc, oldVelocity.z * speedInc);
                brickSpeed++;
            }
        }
        else if (collision.gameObject.CompareTag("Brick3"))
        {
            Destroy(collision.gameObject);

            if (brickSpeed > 3)
            {
                rb.linearVelocity = new Vector3(oldVelocity.x * speedDec, oldVelocity.y * speedDec, oldVelocity.z * speedDec);
                brickSpeed--;
            }
            else if (brickSpeed < 3)
            {
                rb.linearVelocity = new Vector3(oldVelocity.x * speedInc, oldVelocity.y * speedInc, oldVelocity.z * speedInc);
                brickSpeed++;
            }
        }
        else if (collision.gameObject.CompareTag("Brick4"))
        {
            Destroy(collision.gameObject);

            if (brickSpeed > 4)
            {
                rb.linearVelocity = new Vector3(oldVelocity.x * speedDec, oldVelocity.y * speedDec, oldVelocity.z * speedDec);
                brickSpeed--;
            }
            else if (brickSpeed < 4)
            {
                rb.linearVelocity = new Vector3(oldVelocity.x * speedInc, oldVelocity.y * speedInc, oldVelocity.z * speedInc);
                brickSpeed++;
            }
        }
        else if (collision.gameObject.CompareTag("Brick5"))
        {
            Destroy(collision.gameObject);

            if (brickSpeed > 5)
            {
                rb.linearVelocity = new Vector3(oldVelocity.x * speedDec, oldVelocity.y * speedDec, oldVelocity.z * speedDec);
                brickSpeed--;
            }
            else if (brickSpeed < 5)
            {
                rb.linearVelocity = new Vector3(oldVelocity.x * speedInc, oldVelocity.y * speedInc, oldVelocity.z * speedInc);
                brickSpeed++;
            }
        }
        print(rb.linearVelocity);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("escape!");
        Lives--;
        GameManager.SharedInstance.changeLivesText(Lives.ToString());
        if (Lives > 0)
            ballBegins();
    }

    void ballBegins()
    {
        print("began");
        Vector3 ballPos = new Vector3(0, 12, 0);
        rb.MovePosition(ballPos);
        rb.linearVelocity = new Vector3(4, -15, 0);
    }
}
