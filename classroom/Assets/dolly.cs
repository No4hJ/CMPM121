using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class dolly : MonoBehaviour
{
    public float speed;
    public float pathposition;
    public CinemachineTrackedDolly cinemachineTrackedDolly;
    public CinemachineVirtualCamera currentCamera;
    // Start is called before the first frame update
    void Start()
    {
        cinemachineTrackedDolly = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
        pathposition = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        cinemachineTrackedDolly.m_PathPosition += speed;
    }
}
