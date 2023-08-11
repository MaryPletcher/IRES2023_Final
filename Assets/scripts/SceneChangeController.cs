// using UnityEngine;
// using UnityEngine.SceneManagement;
// using UnityEngine.XR;
// using UnityEngine.XR.Interaction.Toolkit;

// public class SceneChangeController : MonoBehaviour
// {
//     public XRControllerInteractor xrController;
//     public string nextSceneName;

//     private bool buttonPressed;

//     private void Awake()
//     {
//         xrController = GetComponent<XRControllerInteractor>();
//     }

//     private void Update()
//     {
//         // Check if the button is pressed on the controller
//         if (xrController.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out buttonPressed) && buttonPressed)
//         {
//             // Call the function to change the scene
//             ChangeScene();
//         }
//     }

//     private void ChangeScene()
//     {
//         // Load the next scene based on the nextSceneName variable
//         SceneManager.LoadScene(nextSceneName);
//     }
// }
