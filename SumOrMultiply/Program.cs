using SumOrMultiply.ApplicationPlace;

namespace SumOrMultiply.Main
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ModernMainForm());
        }
    }
}