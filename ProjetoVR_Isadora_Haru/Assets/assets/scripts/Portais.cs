using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portais : MonoBehaviour
{
    public string finalScene = "";
    public void portalErrado() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void portalCerto()
    {
        SceneManager.LoadScene(finalScene);
    }

}
