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
        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("escape!");
        Lives--;
        ballBegins();
    }

    void ballBegins()
    {
        Vector3 ballPos = new Vector3(0, 15, 0);
        rb.MovePosition(ballPos);
        rb.linearVelocity = new Vector3(4, -10, 0);
    }
}
