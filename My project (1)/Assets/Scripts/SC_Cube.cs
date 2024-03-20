using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Cube : MonoBehaviour
{
    private Transform transform;

    public float rotationspeed;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    //Today i had onigiri for lunch
    void Update()
    {
        rotationspeed = //good work
            Time.deltaTime;
        transform
            .Rotate(90*
                    rotationspeed, 
                0, 
                0
                );
    }
}
