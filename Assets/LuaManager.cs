using UnityEngine;
using System.Collections;
using LuaInterface;
using System.IO;
using System;

public class LuaManager : MonoBehaviour {

    LuaScriptMgr mgr;
    LuaState l;
    public bool isUseLua;
	// Use this for initialization
	void Start () {
        if (isUseLua)
        {
            mgr = new LuaScriptMgr();
            mgr.Start();
            LuaState l = mgr.lua;
            string readToEnd = ConfigFileReader.FilePath(Path.Combine(Application.streamingAssetsPath, "LuaFile/LuaManager.lua"));
            mgr.DoString(readToEnd);

            LuaFunction func = mgr.GetLuaFunction("Start");
            int top = func.BeginPCall();
            IntPtr L = func.GetLuaState();
            func.PCall(top, 0);
            func.EndPCall(top);
           
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
