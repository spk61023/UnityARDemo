using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Method Called");
    }

    // Update is called once per frame
    // void Update()
    // {
    //     Debug.Log("Update Method Called");
    // }

    // logic for changing scene goes here
    public void GetNewScene(string sceneName)
    {
        Debug.Log("GetNewScene Method Called, sceneName passed : "+ sceneName);
        // pass value to change the scene
        SceneManager.LoadScene(sceneName);
    }
}
