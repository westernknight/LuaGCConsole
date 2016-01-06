using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class GConsoleCoreWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("StartServer", StartServer),
			new LuaMethod("StartClient", StartClient),
			new LuaMethod("Act", Act),
			new LuaMethod("Echo", Echo),
			new LuaMethod("New", _CreateGConsoleCore),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("instance", get_instance, set_instance),
			new LuaField("isServer", get_isServer, set_isServer),
			new LuaField("port", get_port, set_port),
			new LuaField("echo", get_echo, set_echo),
			new LuaField("act", get_act, set_act),
		};

		LuaScriptMgr.RegisterLib(L, "GConsoleCore", typeof(GConsoleCore), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGConsoleCore(IntPtr L)
	{
		LuaDLL.luaL_error(L, "GConsoleCore class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(GConsoleCore);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_instance(IntPtr L)
	{
		LuaScriptMgr.Push(L, GConsoleCore.instance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isServer(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsoleCore obj = (GConsoleCore)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isServer");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isServer on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isServer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_port(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsoleCore obj = (GConsoleCore)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name port");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index port on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.port);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_echo(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsoleCore obj = (GConsoleCore)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name echo");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index echo on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.echo);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_act(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsoleCore obj = (GConsoleCore)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name act");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index act on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.act);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_instance(IntPtr L)
	{
		GConsoleCore.instance = (GConsoleCore)LuaScriptMgr.GetUnityObject(L, 3, typeof(GConsoleCore));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isServer(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsoleCore obj = (GConsoleCore)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isServer");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isServer on a nil value");
			}
		}

		obj.isServer = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_port(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsoleCore obj = (GConsoleCore)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name port");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index port on a nil value");
			}
		}

		obj.port = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_echo(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsoleCore obj = (GConsoleCore)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name echo");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index echo on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.echo = (Action<string>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<string>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.echo = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_act(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsoleCore obj = (GConsoleCore)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name act");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index act on a nil value");
			}
		}

		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			obj.act = (Action<string>)LuaScriptMgr.GetNetObject(L, 3, typeof(Action<string>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			obj.act = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartServer(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GConsoleCore obj = (GConsoleCore)LuaScriptMgr.GetUnityObjectSelf(L, 1, "GConsoleCore");
		obj.StartServer();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartClient(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		GConsoleCore obj = (GConsoleCore)LuaScriptMgr.GetUnityObjectSelf(L, 1, "GConsoleCore");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		obj.StartClient(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Act(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GConsoleCore obj = (GConsoleCore)LuaScriptMgr.GetUnityObjectSelf(L, 1, "GConsoleCore");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		obj.Act(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Echo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GConsoleCore obj = (GConsoleCore)LuaScriptMgr.GetUnityObjectSelf(L, 1, "GConsoleCore");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		obj.Echo(arg0);
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

