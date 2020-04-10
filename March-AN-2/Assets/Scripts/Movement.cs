using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float m_speed;
   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * m_speed * Time.deltaTime);
    }
}