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
                ���� �Լ��� ���� ���Ͽ��� Ư���� �Լ��̴�.
                �����찡 �� �༮�� Searching�ϱ� �����̴�.
                �� �ڵ�� ���� Form1�� ���� ���°����� ������.

             */
            ApplicationConfiguration.Initialize();
            Application.Run(new Calculator());
        }
    }
}