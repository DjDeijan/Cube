using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f; // Adds forward force 
    public float sidewaysForce = 500f; // Adds sideways force 
    public float jumpSpeed = 5f; //Adds jump height
    public bool isGrounded; // Collects data if the player is on the ground

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //force that moves our player forward

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space") && isGrounded)
        {
            rb.AddForce(0, jumpSpeed, 0, ForceMode.Impulse);
            isGrounded = false;
        }

        if (Input.GetKey("w"))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if (Input.GetKey("s"))
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        if (rb.position.y < -1f || rb.position.x < -8f || rb.position.x > 8f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}


    

