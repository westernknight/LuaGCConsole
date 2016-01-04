

print("demo ")
function Start(  )
	print("demo start")
end



function RefreshLua( param )
	LuaManager.instance:RefreshLua()
	return "Refresh Lua sucess"
end

local refreshlua =DelegateFactory.Func_string_string(RefreshLua)
GConsole.AddCommand("refreshlua","Refresh Lua",refreshlua,"")





function ChangeSex( param )
	return "dd"
end

local changesex =DelegateFactory.Func_string_string(ChangeSex)
GConsole.AddCommand("changesex","Change the Sex",changesex,"Usage: changesex [value between 0 and 1]")







