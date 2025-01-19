using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    float speed = 15;
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
    }
}
