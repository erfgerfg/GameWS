using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform FolowObj;
    private Vector3 deltaPos;

    void Start()
    {
        deltaPos = transform.position - FolowObj.position;
    }
    void Update()
    {
        transform.position = FolowObj.position + deltaPos;
    }
}
