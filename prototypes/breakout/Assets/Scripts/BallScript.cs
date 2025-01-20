using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    public int Lives = 5;
        
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
        //print(oldVelocity.magnitude);


        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
            GameManager.SharedInstance.PointsGet(1);


        }

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

        float ballX = GameManager.SharedInstance.getSpawnPos();


        Vector3 ballPos = new Vector3(ballX, 10, 0);
        rb.MovePosition(ballPos);
        float randNum = Random.Range(-5f, 5f);
        rb.linearVelocity = new Vector3(randNum, -15, 0);
    }
}
