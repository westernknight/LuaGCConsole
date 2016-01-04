using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class LuaManagerWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("DoFile", DoFile),
			new LuaMethod("RefreshLua", RefreshLua),
			new LuaMethod("New", _CreateLuaManager),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("mgr", get_mgr, set_mgr),
			new LuaField("isUseLua", get_isUseLua, set_isUseLua),
			new LuaField("instance", get_instance, set_instance),
		};

		LuaScriptMgr.RegisterLib(L, "LuaManager", typeof(LuaManager), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaManager(IntPtr L)
	{
		LuaDLL.luaL_error(L, "LuaManager class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(LuaManager);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mgr(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaManager obj = (LuaManager)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mgr");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mgr on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.mgr);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isUseLua(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaManager obj = (LuaManager)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isUseLua");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isUseLua on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isUseLua);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_instance(IntPtr L)
	{
		LuaScriptMgr.Push(L, LuaManager.instance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mgr(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaManager obj = (LuaManager)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mgr");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mgr on a nil value");
			}
		}

		obj.mgr = (LuaScriptMgr)LuaScriptMgr.GetNetObject(L, 3, typeof(LuaScriptMgr));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isUseLua(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		LuaManager obj = (LuaManager)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isUseLua");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isUseLua on a nil value");
			}
		}

		obj.isUseLua = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_instance(IntPtr L)
	{
		LuaManager.instance = (LuaManager)LuaScriptMgr.GetUnityObject(L, 3, typeof(LuaManager));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoFile(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		LuaManager obj = (LuaManager)LuaScriptMgr.GetUnityObjectSelf(L, 1, "LuaManager");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		obj.DoFile(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefreshLua(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaManager obj = (LuaManager)LuaScriptMgr.GetUnityObjectSelf(L, 1, "LuaManager");
		obj.RefreshLua();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object arg0 = LuaScriptMgr.GetLuaObject(L, 1) as Object;
		Object arg1 = LuaScriptMgr.GetLuaObject(L, 2) as Object;
		bool o = arg0 == arg1;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

