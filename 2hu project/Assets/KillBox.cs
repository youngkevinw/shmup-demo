using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject.transform.parent.gameObject);
    }
}
