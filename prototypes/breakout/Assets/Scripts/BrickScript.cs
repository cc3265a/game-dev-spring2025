using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public int x = -1;
    public int y = -1;

    [SerializeField]
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            print("brick hit");
            GameObject mGO = this.gameObject;
            //Rigidbody gameObjectsRigidBody = mGO.AddComponent<Rigidbody>(); // Add the rigidbody.
            transform.gameObject.tag = "Brick1";
        }

              

    }


}
