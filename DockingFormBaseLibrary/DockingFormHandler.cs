using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockingFormBaseLibrary
{
    public static class DockingFormHandler
    {

        public static void HandleParentHwnd<TForm>() where TForm : DockableForm, new()
        {

            var form = new TForm();

            if (Environment.GetCommandLineArgs() is [_, var handle, ..] && int.TryParse(handle, out var handleInt))
            {
                form.DockOnHandle(new(handleInt));
            }

            Application.Run(form);
        }
    }
}
