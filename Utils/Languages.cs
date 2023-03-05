namespace MyApp.Utils
{
    internal class Languages
    {
        public static void Set(string Name)
        {
            MyApp.Resources.Languages.RUS.ResourceManager.GetObject(Name);
        }
    }
}
