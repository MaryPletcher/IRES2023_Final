using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;



public class NotificationManager : MonoBehaviour

{
    public GameObject uiObject;
    public float delay = 10f;
    public AudioSource audioSource;
    public AudioClip popSound;
    public GameObject bar;
    public int barTime;
    

    private void Start()
    {
        Debug.Log("status: " + uiObject.activeSelf);
       //uiObject.SetActive(false);
        Invoke("ShowUIObject", delay);

    }

    private void ShowUIObject()
    {
        uiObject.transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(uiObject, new Vector3(0.0015f,0.0015f,0.0015f), 0.3f);
        if (audioSource != null && popSound != null)
            audioSource.PlayOneShot(popSound);
        uiObject.SetActive(true);
        AnimateBar();
        Invoke("MoveToScene", barTime);
        
    }

    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 2.844f, barTime);
    }

    public void MoveToScene()
    {
        SceneManager.LoadScene(1);
    }
}
