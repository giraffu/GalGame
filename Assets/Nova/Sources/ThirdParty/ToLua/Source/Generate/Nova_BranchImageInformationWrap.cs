﻿// This source code was auto-generated by ToLua#, do not modify it
using System;
using LuaInterface;

public class Nova_BranchImageInformationWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Nova.BranchImageInformation), typeof(System.Object));
		L.RegFunction("New", _CreateNova_BranchImageInformation);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("name", get_name, null);
		L.RegVar("positionX", get_positionX, null);
		L.RegVar("positionY", get_positionY, null);
		L.RegVar("scale", get_scale, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNova_BranchImageInformation(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4)
			{
				string arg0 = ToLua.CheckString(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
				Nova.BranchImageInformation obj = new Nova.BranchImageInformation(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Nova.BranchImageInformation.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.BranchImageInformation obj = (Nova.BranchImageInformation)o;
			string ret = obj.name;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_positionX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.BranchImageInformation obj = (Nova.BranchImageInformation)o;
			float ret = obj.positionX;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index positionX on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_positionY(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.BranchImageInformation obj = (Nova.BranchImageInformation)o;
			float ret = obj.positionY;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index positionY on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.BranchImageInformation obj = (Nova.BranchImageInformation)o;
			float ret = obj.scale;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scale on a nil value");
		}
	}
}

