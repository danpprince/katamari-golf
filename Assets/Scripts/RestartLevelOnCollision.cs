using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;
    public GameObject katamari;
    private bool shouldRestart = false;
    private string capturedTag = "";
    private KatamariMovement km;
    private Rigidbody rb;
    
    private void Update()
    {
        if (capturedTag == strTag && shouldRestart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        capturedTag = collider.tag;
        shouldRestart = true;
    }
}
