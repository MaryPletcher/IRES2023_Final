using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Video;

public class ToggleObject : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private bool isPlaying = true;
    public double savedPlaybackTime;

    public InputActionReference toggleReference = null;

    private void Awake()
    {
        toggleReference.action.started += Toggle;
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // void Start()
    // {
    //     videoPlayer = GetComponent<VideoPlayer>();
    // }

    // private void Update()
    // {
    //     SavePlaybackTime();
    // }

    // private void OnEnable() 
    // {
    //     ResumePlayback();
    // }

    // // Call this method before leaving the scene with the 360 video
    // public void SavePlaybackTime()
    // {
    //     savedPlaybackTime = videoPlayer.time;
    // }

    // // Call this method when returning to the 360 video scene
    // public void ResumePlayback()
    // {
    //     videoPlayer.time = savedPlaybackTime;
    //     videoPlayer.Play();
    // }

    

    private void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }

     private void Toggle(InputAction.CallbackContext context)
    {
        if (!isPlaying)
            {
                videoPlayer.Play();
                isPlaying = true;
            }
            else
            {
                videoPlayer.Pause();
                isPlaying = false;
            }

        bool isActive = !gameObject.activeSelf;
        gameObject.SetActive(isActive);
    }
}
