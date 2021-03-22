using DevExpress.XtraEditors;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System.Drawing;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    public class DachtSpinEdit : SpinEdit,IStatusBarAciklama
    {
        public DachtSpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            Properties.EditMask = "d";
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
    }
}
