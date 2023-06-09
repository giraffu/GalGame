﻿// This source code was auto-generated by ToLua#, do not modify it
using System;
using LuaInterface;

public class Nova_PrefabLoaderWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Nova.PrefabLoader), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("SetPrefab", SetPrefab);
		L.RegFunction("ClearPrefab", ClearPrefab);
		L.RegFunction("GetRestoreData", GetRestoreData);
		L.RegFunction("Restore", Restore);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("luaName", get_luaName, set_luaName);
		L.RegVar("prefabFolder", get_prefabFolder, set_prefabFolder);
		L.RegVar("currentPrefabName", get_currentPrefabName, null);
		L.RegVar("restorableName", get_restorableName, null);
		L.RegVar("priority", get_priority, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPrefab(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Nova.PrefabLoader obj = (Nova.PrefabLoader)ToLua.CheckObject<Nova.PrefabLoader>(L, 1);
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
			Nova.PrefabLoader obj = (Nova.PrefabLoader)ToLua.CheckObject<Nova.PrefabLoader>(L, 1);
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
			Nova.PrefabLoader obj = (Nova.PrefabLoader)ToLua.CheckObject<Nova.PrefabLoader>(L, 1);
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
			Nova.PrefabLoader obj = (Nova.PrefabLoader)ToLua.CheckObject<Nova.PrefabLoader>(L, 1);
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
	static int get_luaName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.PrefabLoader obj = (Nova.PrefabLoader)o;
			string ret = obj.luaName;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index luaName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_prefabFolder(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.PrefabLoader obj = (Nova.PrefabLoader)o;
			string ret = obj.prefabFolder;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index prefabFolder on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currentPrefabName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.PrefabLoader obj = (Nova.PrefabLoader)o;
			string ret = obj.currentPrefabName;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index currentPrefabName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_restorableName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.PrefabLoader obj = (Nova.PrefabLoader)o;
			string ret = obj.restorableName;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index restorableName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_priority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.PrefabLoader obj = (Nova.PrefabLoader)o;
			Nova.RestorablePriority ret = obj.priority;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index priority on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.PrefabLoader obj = (Nova.PrefabLoader)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.luaName = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index luaName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_prefabFolder(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.PrefabLoader obj = (Nova.PrefabLoader)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.prefabFolder = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index prefabFolder on a nil value");
		}
	}
}

