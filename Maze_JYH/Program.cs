using System;
using System.Windows.Forms;

namespace Maze_JYH
{
    public class Program
    {

        [STAThread]
        static void Main()
        {
            if (!IsDuplicated())
                RunApplication();
           
        }


        private static bool IsDuplicated()
        {
            try
            {
                int processCount = 0;

                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();

                foreach (System.Diagnostics.Process p in processes)
                {

                    if (AppDomain.CurrentDomain.FriendlyName.Equals(p.ProcessName + ".exe"))
                        processCount++;

                    // 중복 프로세스 탐지함
                    if (processCount > 1)
                    {
                        MessageBox.Show("프로그램이 이미 실행중입니다.", "중복 오류");
                        return true;
                    }
                }

                // 중복 프로세스 없음
                return false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AC");
                return true;
            }
        }



        private static void RunApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
