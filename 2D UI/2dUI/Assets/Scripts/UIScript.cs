using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIScript : MonoBehaviour
{
  public void MySceneLoader(int sceneIndex){
            SceneManager.LoadScene(sceneIndex);
            Debug.Log("Scene is Loaded");
  }
}
