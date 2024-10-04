using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PeuImporte : MonoBehaviour
{

    [SerializeField] private float m_Threshold;

    Vector3 m_Origin;
    CharacterController m_CharacterController;

    float Awake()
    {
        Debug.Log("Awake");
        m_CharacterController = GetComponent<CharacterController>();
        return 0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bonswar");
        m_Origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    void FixedUpdate()
    {
        if (transform.position.y < m_Threshold) {
            Debug.Log("LLLLL");
            Respawn();
        }
    }

    private void Respawn() {
        enabled = false;
        transform.position = m_Origin;
        enabled = true;
    }
}
