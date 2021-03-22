using DevExpress.XtraEditors;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DachtMemoEdit : MemoEdit, IStatusBarAciklama
    {
        public DachtMemoEdit()
        {
            base.Properties.Appearance.BackColor = Color.LightCyan;
            base.Properties.MaxLength = 500;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; } = "Not Giriniz";
    }
}
