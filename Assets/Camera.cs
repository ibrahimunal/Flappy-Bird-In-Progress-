using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update




    void Start()
    {
   

    }
   void FixedUpdate()
    {
        transform.position += new Vector3(GetComponent<FBird>().speedForward*Time.deltaTime,0,0);
    }



    // Update is called once per frame
     void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.tag != ("block"))
        {

            float width = ((BoxCollider2D)collision).size.x;
            collision.transform.position += new Vector3(width * 7, 0, 0);
        }
        else  { 

            collision.transform.position += new Vector3(16f,0,0);

        }
    }

}

