﻿// This source code was auto-generated by ToLua#, do not modify it
using System;
using LuaInterface;

public class Nova_NovaAnimationWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Nova.NovaAnimation), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("StopAll", StopAll);
		L.RegFunction("IsPlayingAny", IsPlayingAny);
		L.RegFunction("GetTotalDuration", GetTotalDuration);
		L.RegFunction("GetTotalTimeRemaining", GetTotalTimeRemaining);
		L.RegFunction("Do", Do);
		L.RegFunction("Play", Play);
		L.RegFunction("Pause", Pause);
		L.RegFunction("Stop", Stop);
		L.RegFunction("DebugPrintEntriesAll", DebugPrintEntriesAll);
		L.RegFunction("DebugPrintEntries", DebugPrintEntries);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("type", get_type, set_type);
		L.RegVar("isPlaying", get_isPlaying, null);
		L.RegVar("isStopped", get_isStopped, null);
		L.RegVar("totalDuration", get_totalDuration, null);
		L.RegVar("totalTimeRemaining", get_totalTimeRemaining, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopAll(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Nova.NovaAnimation.StopAll();
				return 0;
			}
			else if (count == 1)
			{
				Nova.AnimationType arg0 = (Nova.AnimationType)ToLua.CheckObject(L, 1, typeof(Nova.AnimationType));
				Nova.NovaAnimation.StopAll(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Nova.NovaAnimation.StopAll");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsPlayingAny(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				bool o = Nova.NovaAnimation.IsPlayingAny();
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 1)
			{
				Nova.AnimationType arg0 = (Nova.AnimationType)ToLua.CheckObject(L, 1, typeof(Nova.AnimationType));
				bool o = Nova.NovaAnimation.IsPlayingAny(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Nova.NovaAnimation.IsPlayingAny");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTotalDuration(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				float o = Nova.NovaAnimation.GetTotalDuration();
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else if (count == 1)
			{
				Nova.AnimationType arg0 = (Nova.AnimationType)ToLua.CheckObject(L, 1, typeof(Nova.AnimationType));
				float o = Nova.NovaAnimation.GetTotalDuration(arg0);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Nova.NovaAnimation.GetTotalDuration");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTotalTimeRemaining(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				float o = Nova.NovaAnimation.GetTotalTimeRemaining();
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else if (count == 1)
			{
				Nova.AnimationType arg0 = (Nova.AnimationType)ToLua.CheckObject(L, 1, typeof(Nova.AnimationType));
				float o = Nova.NovaAnimation.GetTotalTimeRemaining(arg0);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Nova.NovaAnimation.GetTotalTimeRemaining");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Do(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Nova.NovaAnimation obj = (Nova.NovaAnimation)ToLua.CheckObject<Nova.NovaAnimation>(L, 1);
				Nova.IAnimationProperty arg0 = (Nova.IAnimationProperty)ToLua.CheckObject<Nova.IAnimationProperty>(L, 2);
				Nova.AnimationEntry o = obj.Do(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				Nova.NovaAnimation obj = (Nova.NovaAnimation)ToLua.CheckObject<Nova.NovaAnimation>(L, 1);
				Nova.IAnimationProperty arg0 = (Nova.IAnimationProperty)ToLua.CheckObject<Nova.IAnimationProperty>(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				Nova.AnimationEntry o = obj.Do(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4)
			{
				Nova.NovaAnimation obj = (Nova.NovaAnimation)ToLua.CheckObject<Nova.NovaAnimation>(L, 1);
				Nova.IAnimationProperty arg0 = (Nova.IAnimationProperty)ToLua.CheckObject<Nova.IAnimationProperty>(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				Nova.AnimationEntry.EasingFunction arg2 = (Nova.AnimationEntry.EasingFunction)ToLua.CheckDelegate<Nova.AnimationEntry.EasingFunction>(L, 4);
				Nova.AnimationEntry o = obj.Do(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 5)
			{
				Nova.NovaAnimation obj = (Nova.NovaAnimation)ToLua.CheckObject<Nova.NovaAnimation>(L, 1);
				Nova.IAnimationProperty arg0 = (Nova.IAnimationProperty)ToLua.CheckObject<Nova.IAnimationProperty>(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				Nova.AnimationEntry.EasingFunction arg2 = (Nova.AnimationEntry.EasingFunction)ToLua.CheckDelegate<Nova.AnimationEntry.EasingFunction>(L, 4);
				int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
				Nova.AnimationEntry o = obj.Do(arg0, arg1, arg2, arg3);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Nova.NovaAnimation.Do");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Nova.NovaAnimation obj = (Nova.NovaAnimation)ToLua.CheckObject<Nova.NovaAnimation>(L, 1);
			obj.Play();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Pause(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Nova.NovaAnimation obj = (Nova.NovaAnimation)ToLua.CheckObject<Nova.NovaAnimation>(L, 1);
			obj.Pause();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Stop(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Nova.NovaAnimation obj = (Nova.NovaAnimation)ToLua.CheckObject<Nova.NovaAnimation>(L, 1);
			obj.Stop();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DebugPrintEntriesAll(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Nova.NovaAnimation.DebugPrintEntriesAll();
				return 0;
			}
			else if (count == 1)
			{
				Nova.AnimationType arg0 = (Nova.AnimationType)ToLua.CheckObject(L, 1, typeof(Nova.AnimationType));
				Nova.NovaAnimation.DebugPrintEntriesAll(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Nova.NovaAnimation.DebugPrintEntriesAll");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DebugPrintEntries(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Nova.NovaAnimation obj = (Nova.NovaAnimation)ToLua.CheckObject<Nova.NovaAnimation>(L, 1);
			obj.DebugPrintEntries();
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
	static int get_type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.NovaAnimation obj = (Nova.NovaAnimation)o;
			Nova.AnimationType ret = obj.type;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index type on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isPlaying(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.NovaAnimation obj = (Nova.NovaAnimation)o;
			bool ret = obj.isPlaying;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isPlaying on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isStopped(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.NovaAnimation obj = (Nova.NovaAnimation)o;
			bool ret = obj.isStopped;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isStopped on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_totalDuration(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.NovaAnimation obj = (Nova.NovaAnimation)o;
			float ret = obj.totalDuration;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index totalDuration on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_totalTimeRemaining(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.NovaAnimation obj = (Nova.NovaAnimation)o;
			float ret = obj.totalTimeRemaining;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index totalTimeRemaining on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.NovaAnimation obj = (Nova.NovaAnimation)o;
			Nova.AnimationType arg0 = (Nova.AnimationType)ToLua.CheckObject(L, 2, typeof(Nova.AnimationType));
			obj.type = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index type on a nil value");
		}
	}
}

