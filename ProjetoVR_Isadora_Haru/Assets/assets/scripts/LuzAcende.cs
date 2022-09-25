using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzAcende : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Light>().range = 1;

    }
    public void ligadesligaLuz()
    {
        GetComponent<Light>().range = 10;
    }
}
