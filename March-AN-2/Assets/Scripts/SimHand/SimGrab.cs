using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimGrab : MonoBehaviour
{
    public GameObject m_touchingObject;
    public GameObject m_heldObject;

    private void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<Rigidbody>())
        {
            m_touchingObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(m_touchingObject == other.gameObject)
        {
            m_touchingObject = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            if(m_touchingObject)
            {
                Grab();
            }
        }
            if(Input.GetKeyUp(KeyCode.Mouse1))
            {
                if(m_heldObject)
                {
                    Release();
                }
            }
    }

    void Grab()
    {
        if(m_touchingObject.GetComponent<Rigidbody>().mass > 10)
        {
            return;
        }

        m_heldObject = m_touchingObject;
        m_heldObject.GetComponent<Rigidbody>().isKinematic = true;
        m_heldObject.transform.SetParent(transform);
    }

    void Release()
    {
        m_heldObject.transform.SetParent(null);
        m_heldObject.GetComponent<Rigidbody>().isKinematic = false;
        m_heldObject = null;
    }
}
