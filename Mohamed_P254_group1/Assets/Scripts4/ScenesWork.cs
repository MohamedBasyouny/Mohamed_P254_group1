using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesWork : MonoBehaviour
{
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneloaderName();
        }
        if (Input.GetMouseButtonDown(1))
        {
            SceneloaderIndex();
        }

        if (Input.GetMouseButtonDown(2))
        {
            SceneloaderpublicIndex();
        }
    }
    void SceneloaderName()
    {
        SceneManager.LoadScene("level2");
        print("loaded by name");
    }

    void SceneloaderIndex()
    {
        SceneManager.LoadScene(1);
        print("loaded by index");
    }

    void SceneloaderpublicIndex()
    {
        SceneManager.LoadScene(index);
        print("loaded by public index");
    }
}
