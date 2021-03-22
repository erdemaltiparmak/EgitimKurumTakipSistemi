using DevExpress.XtraEditors;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    [ToolboxItem(true)]

    public class DachtSimpleButton : SimpleButton,IStatusBarAciklama
    {
        public DachtSimpleButton()
        {
            Appearance.BackColor = Color.Maroon;

        }

        public string StatusBarAciklama { get; set; }
    }
}
