using GoLib.Common;
using System;
using System.IO;

namespace GoActionManager
{
    public class CopyMultipleAction : ActionType
    {
        public CopyMultipleAction()
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

        public override string ActionName => "Copy Multiple files";

        public override string ActionDescription => "Copies multiple files to defined location";

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
                    File.Copy(file, Path.Combine(destination, Path.GetFileName(file)), true);
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
