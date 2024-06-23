using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject ocean;
    [SerializeField] private float wavePower = 2f;

    private Material _oceanMat;

    private void Start()
    {
        SetValue();
    }

    private void SetValue()
    {
        _oceanMat = ocean.GetComponent<Renderer>().sharedMaterial;
    }
}
