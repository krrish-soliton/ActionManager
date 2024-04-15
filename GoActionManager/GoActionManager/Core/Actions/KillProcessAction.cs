using GoLib.Common;
using System;
using System.Diagnostics;

namespace GoActionManager
{
    public class KillProcessAction : ActionType
    {
        public KillProcessAction()
        {
            TextInfos.Add(new TextInfo
            {
                HasFileSelection = false,
                Key = "Process",
                Hint = "Enter process name"
            });
        }

        public override string ActionName => "Kill Process";

        public override string ActionDescription => "Kills the specified process.";

        public override GoBool Execute(ActionData actionData)
        {
            if (actionData.Datas.TryGetValue("Process", out string processName))
            {
                var processes = Process.GetProcessesByName(processName);
                try
                {
                    foreach (var process in processes)
                    {
                        process.Kill();
                    }
                }
                catch (Exception ex)
                {
                    return "Unable to kill the process : " + ex;
                }
                return true;
            }
            return "Invalid Process Name";
        }
    }
}
