using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QH_ParticlePositionSetter : MonoBehaviour
{
    void Update()
    {
        transform.position = GetComponentInParent<Duck>().transform.position;
    }
}
