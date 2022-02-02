using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presentation : MonoBehaviour
{
    public int speed=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1)*14*Time.deltaTime ;
        }
    }
}
