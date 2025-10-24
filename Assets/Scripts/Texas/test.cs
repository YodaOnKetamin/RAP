using JetBrains.Annotations;
using System;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField]
    GameObject Test0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.D))
        {
            Test0.transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
        }
    }
}
