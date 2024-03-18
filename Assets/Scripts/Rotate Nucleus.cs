using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateNucleus : MonoBehaviour
{
    public GameObject nucleus;
    private float rotateSpeed = 180f;
    // Start is called before the first frame update
    public void rotateLeft()
    {
        nucleus.transform.Rotate(Vector3.up* rotateSpeed * Time.deltaTime);
    }

    }
