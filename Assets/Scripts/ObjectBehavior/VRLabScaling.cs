using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLabScaling : MonoBehaviour
{
    public GameObject BuildingIKN;
    [SerializeField] private Vector3 _scaleChange;

    // move camera position / scaling the map
    public void ObjectScale()
    {
        BuildingIKN.transform.localScale = _scaleChange;
    }
}
