using GoLib.Common;
using System.Collections.Generic;

namespace GoActionManager
{
    public abstract class ActionType
    {
        public abstract string ActionName { get; }

        public abstract string ActionDescription { get; }

        public List<TextInfo> TextInfos { get; } = new List<TextInfo>();

        public abstract GoBool Execute(ActionData actionData);

        public override string ToString() => ActionName;
    }
}
