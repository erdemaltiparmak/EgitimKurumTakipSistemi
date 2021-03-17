using DevExpress.XtraEditors;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System.ComponentModel;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DachtFilterControlEdit : FilterControl, IStatusBarAciklama
    {
        public DachtFilterControlEdit()
        {
            //Gruplama yapma ikonu
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz";
    }
}
