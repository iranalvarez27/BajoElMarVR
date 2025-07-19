using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int sceneNumber;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
