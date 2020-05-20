using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitGun : MonoBehaviour
{
    public GameObject m_prefabBit;
    public Transform m_spawn;
    public float m_shootForce;

    void TriggerDown()
    {
        GameObject bit = Instantiate(m_prefabBit, m_spawn.position, m_spawn.rotation);

        bit.GetComponent<Rigidbody>().AddForce(m_spawn.forward * m_shootForce);

        Destroy(bit, 5f);
    }
}
