using DevExpress.XtraEditors;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    public class DachtCheckEdit : CheckEdit, IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public DachtCheckEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Transparent;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
    }
}
