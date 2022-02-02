using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imagebox : MonoBehaviour
{
    bool down = false;
    public int rotate_speed = 5;
    float max = 0;
    float min = 0;
  bool triggered = false;
    int random_ladder_move = 0, random_snake_move=0, random_push_move=0;
    private void Awake()
    {
       
    }

    void Start()
    {
        max = transform.position.y + 0.3f;
        min = transform.position.y - 0.2f;
    }

    void Update()
    {
        if (!triggered)
        {
            translate();
            rotate();
        }
            
    }
    private void translate()
    {
        if (!down)
        {
            transform.position -= new Vector3(0, 0.002f, 0);
            if (transform.position.y <= min)
            {
                down = true;
            }
        }
        if (down)
        {
            transform.position += new Vector3(0, 0.002f, 0);
            if (transform.position.y >= max)
            {
                down = false;
            }
        }
    }
    private void rotate()
    {
        transform.Rotate(Vector3.up * rotate_speed * Time.deltaTime);
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///
    //Collider SCRIPT//

    string[] Options = new string[] { "ladder", "snake", "push" };
    private void OnTriggerEnter(Collider other)
    {
        print(script.instance.num);
        float distance = Vector3.Distance(script.instance.num.transform.position, transform.position);
        print(distance);
        if (distance < 1 && other.gameObject.tag == "Player")
        {
            triggered = true;

            image_box_option_move();
        }
    }

    string random(string[] Options)
    {
        return Options[Random.Range(0, Options.Length)];
    }

    void image_box_option_move()
    { string ans = random(Options);
        print(ans);
        if(ans.Equals("ladder"))
            {
           random_ladder_move= Random.Range(1, Random.Range(3, 10));
            print(random_ladder_move);
        }
       else if (ans.Equals("snake"))
        {
            random_snake_move = Random.Range(1, Random.Range(3, 10));
            print(random_ladder_move);
        }
        else if (ans.Equals("push"))
        { random_push_move = Random.Range(1, Random.Range(3, 10));
            print(random_ladder_move);
        }


    }


}
