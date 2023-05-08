using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load1 : MonoBehaviour
{
    public void Loadscene(string scene1)
    {
        SceneManager.LoadScene(scene1);
    }
}