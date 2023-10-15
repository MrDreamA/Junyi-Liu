using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class right : MonoBehaviour
{
    public void OnRight(int a)
    {
        SceneManager.LoadScene(a);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
