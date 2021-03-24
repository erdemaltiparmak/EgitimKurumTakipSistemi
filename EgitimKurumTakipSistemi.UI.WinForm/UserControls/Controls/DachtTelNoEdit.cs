using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DachtTelNoEdit:DachtTextEdit
    {
        public DachtTelNoEdit()
        {
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            Properties.Mask.EditMask = @"0(\d?\d?\d?)-\d?\d?\d?-\d?\d?\d?\d?";
            Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            StatusBarAciklama = "Telefon No Giriniz";
        }
    }
}
