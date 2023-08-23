using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        //transform.Translate(new Vector3(0, 0, horizontalInput) * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Set the rotation to (0, 90, 0)
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Set the rotation to (0, 90, 0)
            transform.rotation = Quaternion.Euler(0, 270, 0);
            transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime * verticalInput);
    }
}
