using GoLib.Common;
using System;
using System.IO;

namespace GoActionManager
{
    public class MoveAction : ActionType
    {
        public MoveAction()
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

        public override string ActionName => "Move Single File";

        public override string ActionDescription => "Moves single file to defined location";

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
                if (File.Exists(destination)) File.Delete(destination);
                File.Move(source, destination);
            }
            catch (Exception ex)
            {
                return "Error moving : " + ex.Message;
            }
            return true;
        }
    }
}
