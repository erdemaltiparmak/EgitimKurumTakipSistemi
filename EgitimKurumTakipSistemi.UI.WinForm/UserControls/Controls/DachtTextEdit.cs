using DevExpress.XtraEditors;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DachtTextEdit : TextEdit , IStatusBarAciklama
    {
        #region Constructor
        public DachtTextEdit()
        {
            //Alana tıklandığında arka plan rengi değiştirildi.
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;

        }

        #endregion

        #region Properties
        //Enter tuşuna basıldığında bir sonraki kontrole geçme özelliği override edilerek default olarak true seçildi.
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; } 
        #endregion

    }
}
