using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsController : MonoBehaviour
{
    public void ResetScene()
    {
        SceneManager.LoadScene(Constants.FOREST);
    }
}
