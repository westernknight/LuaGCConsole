#region 模块信息
/*----------------------------------------------------------------
// Copyright (C) 2015 广州，蓝弧
//
// 模块名：ConfigFileReader
// 创建者：张嘉俊
// 修改者列表：
// 创建日期：10/29/2015
// 模块描述：
//----------------------------------------------------------------*/
#endregion


using UnityEngine;
using System.Collections;
using System.IO;

public class ConfigFileReader
{

    public static string FilePath(string path, string filename)
    {
        string temppath = path;
        if (!path.Contains(Application.streamingAssetsPath))
        {
            temppath = System.IO.Path.Combine(Application.streamingAssetsPath, path);
        }
        string filePath = System.IO.Path.Combine(temppath, filename);
        return FilePath(filePath);
    }

    public static string FilePath(string filePath)
    {
#if UNITY_STANDALONE  || UNITY_EDITOR
        if (! File.Exists(filePath))
        {
            Debug.LogWarning("Couldn't open file " + filePath);
            return "";
        }
        filePath = "file://" + filePath;

#endif
        WWW w = new WWW(filePath);
        float preTime = Time.realtimeSinceStartup;
        while (!w.isDone)
        {
            var tempTime = Time.realtimeSinceStartup - preTime;
            if (tempTime > 10)
            {
                Debug.LogError("time to load file was too long ");
                break;
            }
        }
        return w.text;


    }
}


