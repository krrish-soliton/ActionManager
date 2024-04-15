using GoLib.Common;
using System;
using System.Diagnostics;
using System.IO;

namespace GoActionManager
{
    public class ExecuteAction : ActionType
    {
        public ExecuteAction()
        {
            TextInfos.Add(new TextInfo
            {
                HasFileSelection = true,
                Hint = "Select a file or executable",
                Key = "Source"
            });
        }

        public override string ActionName => "Execute File";

        public override string ActionDescription => "Executes a file as a process";

        public override GoBool Execute(ActionData actionData)
        {
            if (!actionData.Datas.TryGetValue("Source", out string source))
            {
                return "Invalid File to execute";
            }
            try
            {
                Process.Start(source);
            }
            catch (Exception ex)
            {
                return "Unable to execute : " + ex;
            }
            return true;
        }
    }
}
