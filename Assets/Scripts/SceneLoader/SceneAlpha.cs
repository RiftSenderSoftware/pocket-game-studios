using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class SceneAlpha : MonoBehaviour
{
    public Image img;
    public GameObject imgGM;
    private Color clr;
    public float fadeTime = 1f;

    public Animator animator;


    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void Start()
    {
        animator.SetBool("StartEnd", true);
        StartCoroutine(startDelay());


    }
    public void EndAnim()
    {
        imgGM.SetActive(true);

        Invoke("TestDebug", 2);
        StartCoroutine(waiter());
    }

    public void TestDebug()
    {
        Debug.Log("Invoke delay 2 sec");
    }
    IEnumerator waiter()
    {
        imgGM.SetActive(true);
        yield return new WaitForSeconds (0);
        animator.SetBool("StartEnd", false);
        
    }

    IEnumerator startDelay()
    {
        

        Debug.Log(animator.GetCurrentAnimatorStateInfo(0).IsName("FadeAnim"));
        yield return new WaitForSeconds(1);
        imgGM.SetActive(false);

    }
}
