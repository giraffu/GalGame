﻿// This source code was auto-generated by ToLua#, do not modify it
using System;
using LuaInterface;

public class Nova_RectTransformAnimationPropertyWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Nova.RectTransformAnimationProperty), typeof(System.Object));
		L.RegFunction("New", _CreateNova_RectTransformAnimationProperty);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("value", get_value, set_value);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNova_RectTransformAnimationProperty(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckObject(L, 1, typeof(UnityEngine.RectTransform));
				UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 2);
				UnityEngine.Vector2 arg2 = ToLua.ToVector2(L, 3);
				Nova.RectTransformAnimationProperty obj = new Nova.RectTransformAnimationProperty(arg0, arg1, arg2);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 4)
			{
				UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckObject(L, 1, typeof(UnityEngine.RectTransform));
				UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 2);
				UnityEngine.Vector2 arg2 = ToLua.ToVector2(L, 3);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
				Nova.RectTransformAnimationProperty obj = new Nova.RectTransformAnimationProperty(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 5)
			{
				UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckObject(L, 1, typeof(UnityEngine.RectTransform));
				UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 2);
				UnityEngine.Vector2 arg2 = ToLua.ToVector2(L, 3);
				UnityEngine.Vector2 arg3 = ToLua.ToVector2(L, 4);
				UnityEngine.Vector2 arg4 = ToLua.ToVector2(L, 5);
				Nova.RectTransformAnimationProperty obj = new Nova.RectTransformAnimationProperty(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 6)
			{
				UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckObject(L, 1, typeof(UnityEngine.RectTransform));
				UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 2);
				UnityEngine.Vector2 arg2 = ToLua.ToVector2(L, 3);
				UnityEngine.Vector2 arg3 = ToLua.ToVector2(L, 4);
				UnityEngine.Vector2 arg4 = ToLua.ToVector2(L, 5);
				bool arg5 = LuaDLL.luaL_checkboolean(L, 6);
				Nova.RectTransformAnimationProperty obj = new Nova.RectTransformAnimationProperty(arg0, arg1, arg2, arg3, arg4, arg5);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Nova.RectTransformAnimationProperty.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.RectTransformAnimationProperty obj = (Nova.RectTransformAnimationProperty)o;
			float ret = obj.value;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index value on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.RectTransformAnimationProperty obj = (Nova.RectTransformAnimationProperty)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.value = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index value on a nil value");
		}
	}
}

