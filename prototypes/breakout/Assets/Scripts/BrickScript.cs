using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public int x = -1;
    public int y = -1;

    [SerializeField]
    bool isFalling = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isFalling == true)
        {
            Vector3 newPosition = transform.position;
            newPosition.y -= 10 * Time.deltaTime;
            transform.position = newPosition;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            //print("brick hit");
            GameObject mGO = this.gameObject;
            transform.gameObject.tag = "Brick1";
            isFalling = true;
            GetComponent<Collider>().isTrigger = true;
        }

              

    }


}
