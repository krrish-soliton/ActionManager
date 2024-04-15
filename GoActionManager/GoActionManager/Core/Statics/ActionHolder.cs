using System.Collections.Generic;

namespace GoActionManager
{
    public static class ActionHolder
    {
        public static List<ActionType> ActionTypes { get; } = new List<ActionType>
        {
            new CopyAction(),
            new MoveAction(),
            new CopyMultipleAction(),
            new MoveMultipleAction(),
            new ExecuteAction(),
            new KillProcessAction()
        };

    }
}
