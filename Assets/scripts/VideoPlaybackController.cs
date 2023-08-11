// using UnityEngine;
// using UnityEngine.Video;
// using UnityEngine.XR.Interaction.Toolkit;

// public class VideoPlayerController : MonoBehaviour
// {
//     public VideoPlayer videoPlayer;
//     public XRController rightController; // The right hand controller of your Pico 4 VR headset
//     public float videoSeekSpeed = 10f;

//     private bool isPlaying = false;

//     private void Start()
//     {
//         videoPlayer.Stop(); // Ensure the video starts paused
//     }

//     private void Update()
//     {
//         // Play/Pause video with the trigger button
//         if (rightController.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerButtonValue) && triggerButtonValue)
//         {
//             if (!isPlaying)
//             {
//                 videoPlayer.Play();
//                 isPlaying = true;
//             }
//             else
//             {
//                 videoPlayer.Pause();
//                 isPlaying = false;
//             }
//         }

//         // Seek video with the joystick/touchpad
//         if (rightController.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue))
//         {
//             float seekAmount = primary2DAxisValue.x * Time.deltaTime * videoSeekSpeed;
//             videoPlayer.time += seekAmount;
//         }
//     }
// }
