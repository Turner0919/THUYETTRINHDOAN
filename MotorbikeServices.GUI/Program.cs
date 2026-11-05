using MotorbikeServices.GUI.Setup.Synthesis;

namespace MotorbikeServices.GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Giữ nguyên dòng khởi tạo cấu hình giao diện của .NET
            ApplicationConfiguration.Initialize();

            // 1. Tạo luồng riêng (Thread) để mở FormLogin thứ 2
            System.Threading.Thread secondLoginThread = new System.Threading.Thread(() =>
            {
                Application.Run(new frmlogin());
            });

            secondLoginThread.SetApartmentState(System.Threading.ApartmentState.STA);
            secondLoginThread.Start();

            Application.Run(new frmlogin());
        }
    }
}