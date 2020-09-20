﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcuLogger : Singleton<OcuLogger>
{
    //verbose
    public void Logv(string message)
    {
        print(message);
    }

    //warning
    public void Logw(string message)
    {
        Debug.LogWarning(message);
    }

    //error
    public void Loge(string message)
    {
        Debug.LogError(message);
    }
}
