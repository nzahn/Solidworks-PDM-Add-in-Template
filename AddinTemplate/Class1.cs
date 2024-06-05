using System.Windows.Forms;
using System.Runtime.InteropServices;
using EPDM.Interop.epdm;

namespace AddinTemplate
{
    [Guid("553C3249-903A-4217-BCF8-95F0CD7548E0")]
    [ComVisible(true)]
    public class Class1 : IEdmAddIn5
    {
        public void GetAddInInfo(ref EdmAddInInfo poInfo, IEdmVault5 poVault, IEdmCmdMgr5 poCmdMgr)
        {
            //Specify information to display in the add-in's Properties dialog box
            poInfo.mbsAddInName = "C# Add-in";
            poInfo.mbsCompany = "My Company";
            poInfo.mbsDescription = "Menu add-in that shows a message box.";
            poInfo.mlAddInVersion = 1;

            //Specify the minimum required version of SolidWorks PDM Professional
            poInfo.mlRequiredVersionMajor = 6;
            poInfo.mlRequiredVersionMinor = 4;

            // Register a menu command
            poCmdMgr.AddCmd(1, "C# Add-in", (int)EdmMenuFlags.EdmMenu_Nothing);

        }

        public void OnCmd(ref EdmCmd poCmd, ref EdmCmdData[] ppoData)
        {

            // Handle the menu command
            if (poCmd.meCmdType == EdmCmdType.EdmCmd_Menu)
            {
                if (poCmd.mlCmdID == 1)
                {
                    System.Windows.Forms.MessageBox.Show("C# Add-in");
                }
            }
        }

    }
}
