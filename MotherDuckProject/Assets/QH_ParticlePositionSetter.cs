using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QH_ParticlePositionSetter : MonoBehaviour
{
    void Update()
    {
        Transform duckPos = GetComponentInParent<Duck>().transform;
        transform.position = new Vector3(duckPos.position.x, duckPos.position.y + 0.7f, duckPos.position.z);
    }
}
