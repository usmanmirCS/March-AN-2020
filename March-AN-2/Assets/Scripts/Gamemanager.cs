using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SpatialTracking;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    void Start()
    {
        XRDevice.SetTrackingSpaceType(TrackingSpaceType.RoomScale);
    }

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber, LoadSceneMode.Single);
    }
}