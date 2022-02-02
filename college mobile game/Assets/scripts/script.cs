using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class script : MonoBehaviour
{
    public static script instance;

    public GameObject num;  
    public static NavMeshAgent agent;
    Animator animator;
    public GameObject[] position_array;

    int count = 0;
    int current_position_number = 0;
    void Awake()
    {
        instance = this;
        agent = GetComponent<NavMeshAgent>();
        agent.transform.position = num.transform.position;
        animator = GetComponent<Animator>();
        animator.SetBool("run", true);
    }
   
    void Update()
    {
        //new_position();
        agentmove();
    }

    int random_number()
    {
        return Random.Range(1, 7);
    }


    void new_position()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            int dice_number = random_number();
            int temp = 0;

            if (dice_number != 6)
            {
                print("dice:" + dice_number);
            }
            // after opening of player move with count of device
            if (dice_number != 6 && count == 1)
            {
                temp = dice_number;
                print("dice:" + dice_number);
                int current_temp = current_position_number;
                for (int i = current_temp; i < current_temp + temp; i++)
                {
                    current_position_number++;
                    num = position_array[current_position_number - 1];
                    agentmove();
                }
            }
            // for opening of player
            else if (dice_number == 6)
            {
               // print("dice:" + dice_number);
                count = 1;
                while (temp < 18 && dice_number <= 6)
                {
                    temp += dice_number;
                    //print("temp:" + temp);
                    if (dice_number == 6)
                    {
                        if (Input.GetKeyDown(KeyCode.W))
                        {
                           // print("print w");
                            dice_number = random_number();
                        }
                    }
                    else
                        break;
                }
                if (temp == 18)
                {
                    temp = 0;
                }

                int current_temp = current_position_number;
                print("current temp" + current_temp);
                for (int i = current_temp; i < current_temp + temp; i++)
                {
                    current_position_number++;
                    print("current pos" + current_position_number);
                    num = position_array[current_position_number - 1];
                    agentmove();
                    StartCoroutine(Delay_in_move(50f));
                }
            }
        }
    }


    void agentmove()
    {
        agent.SetDestination(num.transform.position);
        if (agent.transform.position.x == num.transform.position.x)
        {
            animator.SetBool("run", false);
        }
    }

    IEnumerator Delay_in_move(float time)
    {
        print("delay");
        yield return new WaitForSeconds(time);
    }
}
