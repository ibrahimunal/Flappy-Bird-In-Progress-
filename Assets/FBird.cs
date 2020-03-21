using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBird : MonoBehaviour
{
    public float force;
    private bool isFlapping;
    Vector3 birdMove = Vector3.zero;
    public Vector3 flyingSpeed;
    public  float speedForward;
    void Start()
    {
    }
    void FixedUpdate()
    {

        if (transform.position.y < 0) {
            transform.rotation = Quaternion.Euler(0, 0, -45 * Time.deltaTime);

        }

        birdMove += new Vector3(speedForward, 0, 0);

        birdMove += new Vector3(0, -force, 0);
        if (isFlapping == true) {
            isFlapping = false;
            birdMove += flyingSpeed;

        }
            transform.position += birdMove *Time.deltaTime;
        
    }

    // update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)){
            isFlapping = true;
        }
  


    }
}


