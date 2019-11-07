using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject player;
    public Vector3 offset = new Vector3(7 , 3 , -7);
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
 //