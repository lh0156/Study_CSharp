namespace HelloCSharpWin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
                메인 함수는 전에 말하였듯 특별한 함수이다.
                윈도우가 이 녀석을 Searching하기 때문이다.
                이 코드는 현재 Form1을 만들어서 띄우는것으로 끝난다.

             */
            ApplicationConfiguration.Initialize();
            Application.Run(new Calculator());
        }
    }
}