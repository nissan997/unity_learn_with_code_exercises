using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if animals get out of the view of player destroy them
        if(transform.position.z > 30)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < -10)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
