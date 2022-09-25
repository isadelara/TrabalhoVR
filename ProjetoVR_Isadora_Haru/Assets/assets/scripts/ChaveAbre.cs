using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveAbre : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Porta"))
        {
            other.transform.Rotate(new Vector3(0, -105, 0));
            GetComponent<MeshRenderer>().enabled = false;
            Destroy(this);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
    }
}
