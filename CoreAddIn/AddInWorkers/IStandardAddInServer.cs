using Inventor;
using System.Runtime.InteropServices;

namespace CoreAddIn
{
    [ComVisible(true)]
    [Guid(Globals.g_simpleAddInInterfaceID)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IStandardAddInServer
    {
        object Automation { get; }
        UserInterfaceEvents m_uiEvents { get; set; }

        void Activate(ApplicationAddInSite addInSiteObject, bool firstTime);
        ButtonDefinition button_template(string display_text, string internal_name, string icon_path);
        void Deactivate();
        void ExecuteCommand(int commandID);
    }
}