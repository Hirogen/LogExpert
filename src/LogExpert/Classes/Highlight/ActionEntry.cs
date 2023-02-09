using System;

namespace LogExpert.Classes.Highlight
{
    [Serializable]
    public class ActionEntry
    {
        #region Fields

        public string ActionParam { get; set; }
        
        public string PluginName { get; set; }

        #endregion

        #region Public methods

        public ActionEntry Copy()
        {
            ActionEntry e = new ActionEntry();
            e.PluginName = PluginName;
            e.ActionParam = ActionParam;
            return e;
        }

        #endregion
    }
}