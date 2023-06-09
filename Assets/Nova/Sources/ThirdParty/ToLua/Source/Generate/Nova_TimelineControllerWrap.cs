﻿// This source code was auto-generated by ToLua#, do not modify it
using System;
using LuaInterface;

public class Nova_TimelineControllerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Nova.TimelineController), typeof(Nova.PrefabLoader));
		L.RegFunction("SetPrefab", SetPrefab);
		L.RegFunction("ClearPrefab", ClearPrefab);
		L.RegFunction("GetRestoreData", GetRestoreData);
		L.RegFunction("Restore", Restore);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("playableDirector", get_playableDirector, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPrefab(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Nova.TimelineController obj = (Nova.TimelineController)ToLua.CheckObject<Nova.TimelineController>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.SetPrefab(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearPrefab(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Nova.TimelineController obj = (Nova.TimelineController)ToLua.CheckObject<Nova.TimelineController>(L, 1);
			obj.ClearPrefab();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRestoreData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Nova.TimelineController obj = (Nova.TimelineController)ToLua.CheckObject<Nova.TimelineController>(L, 1);
			Nova.IRestoreData o = obj.GetRestoreData();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Restore(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Nova.TimelineController obj = (Nova.TimelineController)ToLua.CheckObject<Nova.TimelineController>(L, 1);
			Nova.IRestoreData arg0 = (Nova.IRestoreData)ToLua.CheckObject<Nova.IRestoreData>(L, 2);
			obj.Restore(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_playableDirector(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.TimelineController obj = (Nova.TimelineController)o;
			UnityEngine.Playables.PlayableDirector ret = obj.playableDirector;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index playableDirector on a nil value");
		}
	}
}

