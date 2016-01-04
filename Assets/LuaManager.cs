using UnityEngine;
using System.Collections;
using LuaInterface;
using System.IO;
using System;

public class LuaManager : MonoBehaviour
{

    public LuaScriptMgr mgr;
    LuaState l;
    public bool isUseLua;
    public static LuaManager instance;

    void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start()
    {
        if (isUseLua)
        {
            mgr = new LuaScriptMgr();
            mgr.Start();
            LuaState l = mgr.lua;
            string readToEnd = ConfigFileReader.FilePath(Path.Combine(Application.streamingAssetsPath, "LuaFile/LuaManager.lua"));
            mgr.DoString(readToEnd);
        }

    }

    public void DoFile(string luafile)
    {
        string readToEnd = ConfigFileReader.FilePath(Path.Combine(Application.streamingAssetsPath, "LuaFile/" + luafile + ".lua"));
        mgr.DoString(readToEnd);
    }
    public void RefreshLua()
    {
        if (isUseLua)
        {
            StartCoroutine(DelayCloseLua());
        }
    }
    IEnumerator DelayCloseLua()
    {
        yield return new WaitForEndOfFrame();
        mgr.Destroy();
        mgr = new LuaScriptMgr();
        mgr.Start();
        LuaState l = mgr.lua;
        string readToEnd = ConfigFileReader.FilePath(Path.Combine(Application.streamingAssetsPath, "LuaFile/LuaManager.lua"));
        mgr.DoString(readToEnd);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            RefreshLua();
        }
    }
}
