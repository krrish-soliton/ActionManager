using GoLib.Common;
using System;
using System.IO;

namespace GoActionManager
{
    public class CopyAction : ActionType
    {
        public CopyAction()
        {
            TextInfos.Add(new TextInfo()
            {
                HasFileSelection = true,
                Key = "Source",
                Hint = "Select source file"
            });
            TextInfos.Add(new TextInfo()
            {
                HasFileSelection = true,
                Key = "Destination",
                Hint = "Select destination file",
                IsSave = true
            });
        }

        public override string ActionName => "Copy Single File";

        public override string ActionDescription => "Copies single file to defined location";

        public override GoBool Execute(ActionData actionData)
        {
            if (actionData.ActionName != ActionName) return "Invalid Action";
            if (!actionData.Datas.TryGetValue("Source", out string source) || source.IsNullOrEmpty() || !File.Exists(source))
            {
                return "Invalid Source file";
            }

            if (!actionData.Datas.TryGetValue("Destination", out string destination) || destination.IsNullOrEmpty())
            {
                return "Invalid Destination file";
            }
            try
            {
                File.Copy(source, destination, true);
            }
            catch (Exception ex)
            {
                return "Error copying : " + ex.Message;
            }
            return true;
        }
    }
}
