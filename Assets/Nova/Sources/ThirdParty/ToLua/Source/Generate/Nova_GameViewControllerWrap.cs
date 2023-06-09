﻿// This source code was auto-generated by ToLua#, do not modify it
using System;
using LuaInterface;

public class Nova_GameViewControllerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Nova.GameViewController), typeof(Nova.ViewControllerBase));
		L.RegFunction("ShowUI", ShowUI);
		L.RegFunction("HideUI", HideUI);
		L.RegFunction("SwitchDialogueBox", SwitchDialogueBox);
		L.RegFunction("Step", Step);
		L.RegFunction("AbortAnimation", AbortAnimation);
		L.RegFunction("TryClickLink", TryClickLink);
		L.RegFunction("GetRestoreData", GetRestoreData);
		L.RegFunction("Restore", Restore);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("currentDialogueBox", get_currentDialogueBox, set_currentDialogueBox);
		L.RegVar("uiActive", get_uiActive, null);
		L.RegVar("autoDelay", get_autoDelay, set_autoDelay);
		L.RegVar("fastForwardDelay", get_fastForwardDelay, set_fastForwardDelay);
		L.RegVar("restorableName", get_restorableName, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowUI(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				Nova.GameViewController obj = (Nova.GameViewController)ToLua.CheckObject<Nova.GameViewController>(L, 1);
				obj.ShowUI();
				return 0;
			}
			else if (count == 2)
			{
				Nova.GameViewController obj = (Nova.GameViewController)ToLua.CheckObject<Nova.GameViewController>(L, 1);
				System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 2);
				obj.ShowUI(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Nova.GameViewController.ShowUI");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HideUI(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				Nova.GameViewController obj = (Nova.GameViewController)ToLua.CheckObject<Nova.GameViewController>(L, 1);
				obj.HideUI();
				return 0;
			}
			else if (count == 2)
			{
				Nova.GameViewController obj = (Nova.GameViewController)ToLua.CheckObject<Nova.GameViewController>(L, 1);
				System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 2);
				obj.HideUI(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Nova.GameViewController.HideUI");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SwitchDialogueBox(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Nova.GameViewController obj = (Nova.GameViewController)ToLua.CheckObject<Nova.GameViewController>(L, 1);
				Nova.DialogueBoxController arg0 = (Nova.DialogueBoxController)ToLua.CheckObject<Nova.DialogueBoxController>(L, 2);
				obj.SwitchDialogueBox(arg0);
				return 0;
			}
			else if (count == 3)
			{
				Nova.GameViewController obj = (Nova.GameViewController)ToLua.CheckObject<Nova.GameViewController>(L, 1);
				Nova.DialogueBoxController arg0 = (Nova.DialogueBoxController)ToLua.CheckObject<Nova.DialogueBoxController>(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				obj.SwitchDialogueBox(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Nova.GameViewController.SwitchDialogueBox");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Step(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Nova.GameViewController obj = (Nova.GameViewController)ToLua.CheckObject<Nova.GameViewController>(L, 1);
			obj.Step();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AbortAnimation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Nova.GameViewController obj = (Nova.GameViewController)ToLua.CheckObject<Nova.GameViewController>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.AbortAnimation(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TryClickLink(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Nova.GameViewController obj = (Nova.GameViewController)ToLua.CheckObject<Nova.GameViewController>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Camera arg1 = (UnityEngine.Camera)ToLua.CheckObject(L, 3, typeof(UnityEngine.Camera));
			bool o = obj.TryClickLink(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
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
			Nova.GameViewController obj = (Nova.GameViewController)ToLua.CheckObject<Nova.GameViewController>(L, 1);
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
			Nova.GameViewController obj = (Nova.GameViewController)ToLua.CheckObject<Nova.GameViewController>(L, 1);
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
	static int get_currentDialogueBox(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.GameViewController obj = (Nova.GameViewController)o;
			Nova.DialogueBoxController ret = obj.currentDialogueBox;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index currentDialogueBox on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uiActive(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.GameViewController obj = (Nova.GameViewController)o;
			bool ret = obj.uiActive;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index uiActive on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autoDelay(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.GameViewController obj = (Nova.GameViewController)o;
			float ret = obj.autoDelay;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoDelay on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fastForwardDelay(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.GameViewController obj = (Nova.GameViewController)o;
			float ret = obj.fastForwardDelay;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fastForwardDelay on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_restorableName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.GameViewController obj = (Nova.GameViewController)o;
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
	static int set_currentDialogueBox(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.GameViewController obj = (Nova.GameViewController)o;
			Nova.DialogueBoxController arg0 = (Nova.DialogueBoxController)ToLua.CheckObject<Nova.DialogueBoxController>(L, 2);
			obj.currentDialogueBox = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index currentDialogueBox on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autoDelay(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.GameViewController obj = (Nova.GameViewController)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.autoDelay = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoDelay on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fastForwardDelay(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.GameViewController obj = (Nova.GameViewController)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.fastForwardDelay = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fastForwardDelay on a nil value");
		}
	}
}

