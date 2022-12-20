using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethod 
{
    private const float dotThreshold = 0.95f;

    public static bool IsFacingTarget(this Transform transform,Transform target)
    {
        var vectotToTarget = target.position - transform.position;
        vectotToTarget.Normalize();

        float dot = Vector3.Dot(transform.forward, vectotToTarget);

        return dot >= dotThreshold;
    }
}
