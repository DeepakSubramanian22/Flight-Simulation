using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));

        // tilt the plane up/down based on up/down arrow keys
        if (verticalInput != 0)
        {
            transform.Rotate(Vector3.right * (rotationSpeed * Time.deltaTime * verticalInput));
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
