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
        

        if (Input.GetKey(KeyCode.D))
        {
            Test0.transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Test0.transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
                }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Test0.transform.position += new Vector3(0, 50, 0) * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Test0.transform.position += new Vector3(0, 50, 0) * Time.deltaTime;
        }



    }
}
