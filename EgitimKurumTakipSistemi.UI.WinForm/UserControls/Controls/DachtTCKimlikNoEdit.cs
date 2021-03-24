using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DachtTCKimlikNoEdit : DachtTextEdit
    {
        public DachtTCKimlikNoEdit()
        {
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d?\d?\d?\d?\d?\d?\d?\d?";
            Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            StatusBarAciklama = "TC Kimlik No Giriniz";
        }
        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
