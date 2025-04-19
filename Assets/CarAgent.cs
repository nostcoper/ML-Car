using UnityEngine;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;

public class CarAgent : MonoBehaviour
{

    Rigidbody rb;

    LayerMask TrackMask;
    public Transform InitialPoint;
    public float AngleY;
    public float MaxVelocity;


    public bool ManualMode;

    [Header("Checkpoints")]
    public Transform[] Checkpoints;
    public int nextCheckPointId;

    [Header("Laps Setting")]
    public int CurrentLap;
    public int TotalLap = 3;


    private float timeWithoutCheckPoint = 0f;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
