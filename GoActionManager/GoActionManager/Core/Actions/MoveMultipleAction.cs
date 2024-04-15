using GoLib.Common;
using System;
using System.IO;

namespace GoActionManager
{
    public class MoveMultipleAction : ActionType
    {
        public MoveMultipleAction()
        {
            TextInfos.Add(new TextInfo()
            {
                HasFileSelection = true,
                Key = "Source",
                IsMultiSelect = true,
                Hint = "Source files separated by |"
            });
            TextInfos.Add(new TextInfo()
            {
                HasFileSelection = true,
                Key = "Destination",
                Hint = "Select destination folder",
                IsFolder = true
            });
        }

        public override string ActionName => "Move Multiple files";

        public override string ActionDescription => "Moves multiple files to defined location";

        public override GoBool Execute(ActionData actionData)
        {
            if (actionData.ActionName != ActionName) return "Invalid Action";
            if (!actionData.Datas.TryGetValue("Source", out string source) || source.IsNullOrEmpty())
            {
                return "Invalid Source files";
            }

            if (!actionData.Datas.TryGetValue("Destination", out string destination) || destination.IsNullOrEmpty())
            {
                return "Invalid Destination files";
            }
            try
            {
                if (File.Exists(destination))
                {
                    destination = Path.GetDirectoryName(destination);
                }
                if (!Directory.Exists(destination))
                {
                    return "Invalid Directory";
                }
                string[] files = source.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string file in files)
                {
                    string destFile = Path.Combine(destination, Path.GetFileName(file));
                    if (File.Exists(destFile)) File.Delete(destFile);
                    File.Move(file, destFile);
                }
            }
            catch (Exception ex)
            {
                return "Error copying : " + ex.Message;
            }
            return true;
        }
    }
}
