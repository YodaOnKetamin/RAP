using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    GameObject TestO;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.D))
        {
            TestO.transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            TestO.transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
        }
      
    }
}
