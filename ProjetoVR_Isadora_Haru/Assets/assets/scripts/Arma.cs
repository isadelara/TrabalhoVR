using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public void Fire()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            var target = hit.transform.parent.gameObject;
            if (target != null)
            {
                var anim = target.GetComponent<Animator>();
                if (anim != null)
                {
                    anim.SetTrigger("end");
                }
            }
        }
    }

}
