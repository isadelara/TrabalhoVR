using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveAbre : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Porta"))
        {
            collision.transform.Rotate(new Vector3(0,-95,0));
            Destroy(this);
        }
    }
}
