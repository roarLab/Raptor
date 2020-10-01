﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScaler : Singleton<WorldScaler>
{
    public static int worldScale = 2;

    public static Vector3 WorldToRealPosition(Vector3 worldPos)
    {
        return worldPos / worldScale;
    }
    public static float WorldToRealPosition(float worldPos)
    {
        return worldPos / worldScale;
    }

    public static Vector3 RealToWorldPosition(Vector3 realPos)
    {
        return realPos * worldScale;
    }
    public static float RealToWorldPosition(float realPos)
    {
        return realPos * worldScale;
    }
}
