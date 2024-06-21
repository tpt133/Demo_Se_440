using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taodaichovui : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MoveGameObject(() =>
        {
            Debug.Log("Callback");
        });
    }
    private void MoveGameObject(Action callback)
    {
        Debug.Log(" Move Game Object completed");
        callback.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
