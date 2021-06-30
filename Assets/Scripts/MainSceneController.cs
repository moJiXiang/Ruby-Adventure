using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject ruby = GameObject.Find("Ruby");
        Debug.Log("Ruby: ", ruby);
    }
}
