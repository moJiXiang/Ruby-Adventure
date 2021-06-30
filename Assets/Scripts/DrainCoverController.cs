using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrainCoverController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void EnterMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        RubyController player = collision.gameObject.GetComponent<RubyController>();

        if (player != null)
        {
            EnterMainScene();
        }
    }
}
