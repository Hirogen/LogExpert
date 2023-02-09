namespace JsonColumnizer
{
    public class JsonColumn
    {
        #region cTor

        public JsonColumn(string name)
        {
            Name = name;
        }

        #endregion

        #region Properties

        public string Name { get; }

        #endregion
    }
}