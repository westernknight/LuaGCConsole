

print("demo ")

--字符串分割函数
--传入字符串和分隔符，返回分割后的table
function string.split(str, delimiter)
	if str==nil or str=='' or delimiter==nil then
		return nil
	end
	
    local result = {}
    for match in (str..delimiter):gmatch("(.-)"..delimiter) do
        table.insert(result, match)
    end
    return result
end


function ConnectToServer(ip_port)
	local t = string.split(ip_port,' ')
	if #t <2 then return ("not enough param") end
	GConsoleCore.instance:StartClient(t[1],tonumber(t[2]))
	return ""
end

local connectToServer = DelegateFactory.Func_string_string(ConnectToServer)
GConsole.AddCommand("connect","Connect",connectToServer,"Usage: connect ip port")

function Echo( log )
	print(log)
end
local echo =DelegateFactory.Action_string(Echo)
GConsoleCore.instance.echo = GConsoleCore.instance.echo+echo


function Act( cmd )
	GConsoleCore.instance:Act(cmd);
	return ""
end
local act = DelegateFactory.Func_string_string(Act)
GConsole.AddCommand("act","Act",act,"Usage: act write")


