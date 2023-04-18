using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLabScaling : MonoBehaviour
{
    public Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // move camera position / scaling the map
    public void MovePosition()
    {
        tr.scale += 1f;

    }
}
