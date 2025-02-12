using UnityEngine;

public class spareBallScript : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    [SerializeField]

    //Collider myCollider;
    float tooSlow = 0;

    public static spareBallScript SharedInstance2;

    float speedBoost = 1.1f;

    public GameObject spareBallPrefab;

    //bool tooMany = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SharedInstance2 = this;
        //spareBallBegins();
        //myCollider = GetComponent<Collider>();
        float randNum = Random.Range(-5f, 5f);
        rb.linearVelocity = new Vector3(randNum, -15, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //print(rb.linearVelocity);
        if (rb.linearVelocity.magnitude < 2 || Mathf.Abs(rb.linearVelocity.y) < 1)
        {
            Vector3 oldVel = rb.linearVelocity;
            tooSlow += Time.deltaTime;
            print("tooslow " + tooSlow + " " + rb.linearVelocity.magnitude);


            if (tooSlow >= 3)
            {
                print("if statement");
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
            //tooMany = true;
        }
        else
        {
            //tooMany = false;
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
        //if (collision.gameObject.CompareTag("Brick3") && tooMany == false)
        {
            //float randx = Random.Range(-1f, 1f);
            //Vector3 extraBallPos = new Vector3(transform.position.x + randx, transform.position.y, transform.position.z);
            //Instantiate(spareBallPrefab, transform.position, transform.rotation);

        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("escapeTag"))
        {
            //print("goodbye cruel world");
            Destroy(this.gameObject);
            
        }
    }

    void spareBallBegins()
    {

        //float randNum = Random.Range(-5f, 5f);
        //rb.linearVelocity = new Vector3(randNum, -15, 0);
    }

}
