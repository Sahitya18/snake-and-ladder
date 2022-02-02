using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

   public Transform player;
    public float smooth = 0.125f;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredpos = player.position + offset;
        Vector3  smoothpos = Vector3.Lerp(transform.position, desiredpos, smooth);
        transform.position = smoothpos;
        transform.LookAt(player);
    }
}
