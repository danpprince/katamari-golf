using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelWithButton : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyRestart))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
