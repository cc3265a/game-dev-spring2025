using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    [SerializeField]

    Collider myCollider;

    [SerializeField]
    GameObject spareBall;

    float tooSlow = 0;

    public static BallScript SharedInstance2;

    float speedBoost = 1.1f;

    public GameObject BallPrefab;

    bool tooMany = false;

    float slowCap = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SharedInstance2 = this;
        ballBegins();
        myCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        print(rb.linearVelocity.magnitude);
        if (rb.linearVelocity.magnitude < slowCap || Mathf.Abs(rb.linearVelocity.y) < slowCap)
        {
            Vector3 oldVel = rb.linearVelocity;
            tooSlow += Time.deltaTime;
            print("tooslow " + tooSlow + " " + rb.linearVelocity.magnitude);


            if (tooSlow >= 2)
            {
                //print("if statement");
                //rb.linearVelocity = new Vector3(oldVel.x, oldVel.y * 10, 0);

                float randX = Random.Range(-5f, 5f);
                Vector3 m_NewForce = new Vector3(randX, 10.0f, 0.0f);


                rb.AddForce(m_NewForce, ForceMode.Impulse);


                print(rb.linearVelocity.magnitude);
                tooSlow = 0;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = new Vector3(1, 1, 0);
        }

        if (GameObject.FindGameObjectsWithTag("ball").Length >= 6)
        {
            tooMany = true;
        }
        else
        {
            tooMany = false;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 oldVelocity = rb.linearVelocity;
        GameManager.SharedInstance.checkBrickCount();
        //print(oldVelocity.magnitude);


        if (collision.gameObject.CompareTag("Brick"))
        {
            //Destroy(collision.gameObject);
            GameManager.SharedInstance.PointsGet(1);


        }
        if (collision.gameObject.CompareTag("Brick2"))
        {
            rb.linearVelocity = new Vector3(oldVelocity.x * speedBoost, oldVelocity.y * speedBoost, 0);

        }
        
        if (collision.gameObject.CompareTag("Brick3") && tooMany == false)
        {
            float i = 0;
            while (i < 3)
            {
                Vector3 sparePos = new Vector3(transform.position.x + i/2, transform.position.y, transform.position.z);
                GameObject spare = Instantiate(spareBall, sparePos, transform.rotation);
                //print("i = " + i);
                i++;
            }

        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("escapeTag"))
        {

            //print("escape!");
            GameManager.SharedInstance.loseLife();
            GameManager.SharedInstance.changeLivesText(GameManager.SharedInstance.getLives().ToString());
            if (GameManager.SharedInstance.getLives() > 0)
                ballBegins();
        }
    }

    void ballBegins()
    {
        resetBallPos();
        
        float randNum = Random.Range(-5f, 5f);
        rb.linearVelocity = new Vector3(randNum, -15, 0);
    }
    
    public void resetBallPos()
    {
        //print("reset ball pos");
        float paddlePos = GameManager.SharedInstance.getSpawnPos();
        if(paddlePos < -15)
        {
            paddlePos = -14;
        }
        if(paddlePos > 28)
        {
            paddlePos = 25;
        }

        rb.MovePosition(new Vector3 (paddlePos, 8, 0));
    }

}
