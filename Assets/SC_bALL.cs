using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_bALL : MonoBehaviour
{
    private Transform _transform;
    public bool thisvarshowsifanobjectisgrounded; //check if an object is afloat or not
    void Start()
    {
        _transform = GetComponent<Transform>();
        var distanceToGroundFromPlayerCharacter = GetComponent<Collider>().bounds.extents.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    bool checkifanobjectisafloatornot()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1);
    }
}
