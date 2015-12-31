using System;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class GConsoleWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("RemoveCommand", RemoveCommand),
			new LuaMethod("AddCommand", AddCommand),
			new LuaMethod("Eval", Eval),
			new LuaMethod("GetSuggestionItems", GetSuggestionItems),
			new LuaMethod("Print", Print),
			new LuaMethod("print", print),
			new LuaMethod("New", _CreateGConsole),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("instance", get_instance, set_instance),
			new LuaField("outputUnityLog", get_outputUnityLog, set_outputUnityLog),
			new LuaField("outputStackTrace", get_outputStackTrace, set_outputStackTrace),
			new LuaField("allowEmptyOutput", get_allowEmptyOutput, set_allowEmptyOutput),
			new LuaField("newlineAfterCommandOutput", get_newlineAfterCommandOutput, set_newlineAfterCommandOutput),
			new LuaField("Color", get_Color, set_Color),
		};

		LuaScriptMgr.RegisterLib(L, "GConsole", typeof(GConsole), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGConsole(IntPtr L)
	{
		LuaDLL.luaL_error(L, "GConsole class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(GConsole);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_instance(IntPtr L)
	{
		LuaScriptMgr.Push(L, GConsole.instance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_outputUnityLog(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsole obj = (GConsole)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name outputUnityLog");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index outputUnityLog on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.outputUnityLog);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_outputStackTrace(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsole obj = (GConsole)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name outputStackTrace");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index outputStackTrace on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.outputStackTrace);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_allowEmptyOutput(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsole obj = (GConsole)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name allowEmptyOutput");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index allowEmptyOutput on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.allowEmptyOutput);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_newlineAfterCommandOutput(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsole obj = (GConsole)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name newlineAfterCommandOutput");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index newlineAfterCommandOutput on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.newlineAfterCommandOutput);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Color(IntPtr L)
	{
		LuaScriptMgr.Push(L, GConsole.Color);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_instance(IntPtr L)
	{
		GConsole.instance = (GConsole)LuaScriptMgr.GetUnityObject(L, 3, typeof(GConsole));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_outputUnityLog(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsole obj = (GConsole)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name outputUnityLog");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index outputUnityLog on a nil value");
			}
		}

		obj.outputUnityLog = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_outputStackTrace(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsole obj = (GConsole)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name outputStackTrace");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index outputStackTrace on a nil value");
			}
		}

		obj.outputStackTrace = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_allowEmptyOutput(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsole obj = (GConsole)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name allowEmptyOutput");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index allowEmptyOutput on a nil value");
			}
		}

		obj.allowEmptyOutput = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_newlineAfterCommandOutput(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		GConsole obj = (GConsole)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name newlineAfterCommandOutput");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index newlineAfterCommandOutput on a nil value");
			}
		}

		obj.newlineAfterCommandOutput = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Color(IntPtr L)
	{
		LuaTypes funcType = LuaDLL.lua_type(L, 3);

		if (funcType != LuaTypes.LUA_TFUNCTION)
		{
			GConsole.Color = (Func<string,string,string>)LuaScriptMgr.GetNetObject(L, 3, typeof(Func<string,string,string>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.ToLuaFunction(L, 3);
			GConsole.Color = (param0, param1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				LuaScriptMgr.Push(L, param1);
				func.PCall(top, 2);
				object[] objs = func.PopValues(top);
				func.EndPCall(top);
				return (string)objs[0];
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveCommand(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GConsole obj = (GConsole)LuaScriptMgr.GetUnityObjectSelf(L, 1, "GConsole");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		bool o = obj.RemoveCommand(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddCommand(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		Func<string,string> arg2 = null;
		LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

		if (funcType3 != LuaTypes.LUA_TFUNCTION)
		{
			 arg2 = (Func<string,string>)LuaScriptMgr.GetNetObject(L, 3, typeof(Func<string,string>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			arg2 = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, param0);
				func.PCall(top, 1);
				object[] objs = func.PopValues(top);
				func.EndPCall(top);
				return (string)objs[0];
			};
		}

		string arg3 = LuaScriptMgr.GetLuaString(L, 4);
		bool o = GConsole.AddCommand(arg0,arg1,arg2,arg3);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Eval(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = GConsole.Eval(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSuggestionItems(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		List<GConsoleItem> o = GConsole.GetSuggestionItems(arg0);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Print(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = GConsole.Print(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int print(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = GConsole.print(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
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

