using Teigha.Runtime;
using HostMgd.ApplicationServices;

namespace PhoneHolder.View
{
    public class Commands
    {
        [CommandMethod("CreatePhoneHolder")]
        public void RunMainForm()
        {
            HostMgd.ApplicationServices.Application.ShowModalDialog(new MainForm());
        }
    }
}
