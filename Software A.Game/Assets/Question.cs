using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Question : MonoBehaviour
{

    [SerializeField] private AudioSource x;
    [SerializeField] private AudioSource y;


    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            x.Play();
            StartCoroutine(waitForSound());
            

        }
        else if (Input.GetKey(KeyCode.B))
        {
            y.Play();
            StartCoroutine(waitForSoundCorrectAnswer());
            

        }
        else if (Input.GetKey(KeyCode.C))
        {
            x.Play();
            StartCoroutine(waitForSound());
            

        }

        
    }

    IEnumerator waitForSound()
    {
        while (x.isPlaying)
        {
            yield return null;
        }
        SceneManager.LoadScene("GameOver");
    }

    IEnumerator waitForSoundCorrectAnswer()
    {
        while (y.isPlaying)
        {
            yield return null;
        }
        SceneManager.LoadScene("TheEnd");
    }
}