using DevExpress.XtraEditors;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System.ComponentModel;
using System.Drawing;


namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    [ToolboxItem(true)]

    public class DachtPictureEdit: PictureEdit,IStatusBarKisayol
    {
        public DachtPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.NullText = "Öğe Bulunamadı.";
            Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            Properties.ShowMenu = false;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisayol { get; set; } = "F4 :";
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
    }
}
