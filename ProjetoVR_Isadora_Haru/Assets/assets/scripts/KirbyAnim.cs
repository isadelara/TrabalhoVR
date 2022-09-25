using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KirbyAnim : MonoBehaviour
{
    public GameObject pai;
    public Animator anim;
    public GameObject porta;


    private void Start()
    {
        if (Random.value < .5f)
        {
            anim.SetTrigger("move1");
        }
        else
        {
            anim.SetTrigger("move2");
        }
    }
    public void hit() {
        Destroy(porta);
    }
    public void end() {
        Destroy(pai,2);
    }
}