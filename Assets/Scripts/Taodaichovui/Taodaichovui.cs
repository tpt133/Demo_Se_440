using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class Taodaichovui : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //demo lambda
        MoveGameObject(() =>
        {
            Debug.Log("Callback");
        });
        //demo multi thread 1
        Debug.Log("Start call count down");
        StartCoroutine(CountDown());
        Debug.Log("End call count down");


        //demo multi thread 2
        MultiThread02();
    }

    private IEnumerator CountDown()
    {
        Debug.Log("Srart CountDown");
        int countTime = 0;
        for (int i = 0; i < countTime; i++)
        {
            yield return null;
        }
        Debug.Log("End countDown");
    }

    private async void MultiThread02()
    {
        Debug.Log("Start Multi tasks");
        List<UniTask> tasks = new List<UniTask>();
        tasks.Add(TaskA("Move Oject", 2000));
        tasks.Add(TaskA("Scale Oject", 4000));
        await UniTask.WhenAny(tasks);
        Debug.Log("Completed task");
    }
    private async UniTask TaskA(String log, int delay)
    {
        Debug.Log($"Task Start {log}");
        await UniTask.Delay(delay);
        Debug.Log($"Task Done {delay}");
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
