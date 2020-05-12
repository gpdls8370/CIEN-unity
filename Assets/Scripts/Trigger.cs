using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        Debug.Log("왼쪽 구역 진입");
    }

    void OnTriggerExit(UnityEngine.Collider other)
    {
        Debug.Log("왼쪽 구역 나감");
    }

}
