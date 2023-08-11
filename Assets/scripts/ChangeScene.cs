using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.InputSystem;



public class ChangeScene : MonoBehaviour

{
   
    public VideoPlayer videoPlayer;
    private double savedPlaybackTime;
    public GameObject tester;
    public ToggleObject toggleObjectReference;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        
    }

    // Call this method before leaving the scene with the 360 video
    public void SavePlaybackTime()
    {
        savedPlaybackTime = videoPlayer.time;
    }
    // Call this method when returning to the 360 video scene
    public void ResumePlayback()
    {
        videoPlayer.time = savedPlaybackTime;
        videoPlayer.Play();
    }
    public void MoveToScene(int sceneID)
    {
        // toggleObjectReference.SavePlaybackTime();
        SceneManager.LoadScene(sceneID);
        
        // if (sceneID==1)
        // {
            
        //     SavePlaybackTime();
        //     SceneManager.LoadScene(sceneID);
        // }
        // else if (sceneID==0)
        // {
        //     ResumePlayback();
        //     SceneManager.LoadScene(sceneID);
        // }
        // else
        // {
        //     SceneManager.LoadScene(sceneID);
        // }
        
    }

    // public void MoveToScene(int sceneID)
    // {
    //     StartCoroutine(LoadSceneAsync(sceneID));
    // }

    // private IEnumerator LoadSceneAsync(int sceneID)
    // {
    //     SavePlaybackTime();
    //     AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneID);
    //     while (!asyncLoad.isDone)
    //     {
    //         yield return null;
    //     }

    //     if (sceneID == 0)
    //     {
    //         ResumePlayback();
    //     }
    // }
}

