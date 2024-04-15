using System.Collections.Generic;

namespace GoActionManager
{
    public class ActionData
    {
        public string ActionName { get; set; }

        public Dictionary<string, string> Datas { get; } = new Dictionary<string, string>();

        public void SetData(string key, string value) => Datas[key] = value;

        public void Reset() => Datas.Clear();
    }
}
