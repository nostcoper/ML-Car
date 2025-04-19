using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;
using UnityEngine.Events;

public class Road : MonoBehaviour
{
    public SplineContainer spline;
    public int numberOfCheckpoints = 10;
    public Vector3 checkpointScale = new Vector3(2.0f, 2.0f, 2.0f);
    public List<Transform> checkpoints = new List<Transform>();
    public GameObject checkPointPrefab;

    void Start()
    {
        GenerateCheckpoints();
    }

void GenerateCheckpoints()
{
    for (int i = 0; i < numberOfCheckpoints; i++)
    {
        float t = i / (float)(numberOfCheckpoints - 1);
        
        Vector3 position = spline.EvaluatePosition(t);
        Vector3 tangent = spline.EvaluateTangent(t);
        Quaternion orientation = Quaternion.LookRotation(tangent);
        
        GameObject checkpointObject = Instantiate(checkPointPrefab);
        checkpointObject.name = $"Checkpoint{i + 1}";
        Transform checkpoint = checkpointObject.transform;
        
        checkpoint.position = position;
        checkpoint.rotation = orientation;
        checkpoint.localScale = checkpointScale;
        
        checkpoint.SetParent(transform);

        checkpoints.Add(checkpoint);

    }
}
}
