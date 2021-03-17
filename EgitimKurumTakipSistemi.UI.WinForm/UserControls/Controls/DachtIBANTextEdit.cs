using DevExpress.XtraEditors.Mask;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    public class DachtIBANTextEdit : DachtTextEdit
    {
        [ToolboxItem(true)]
        public DachtIBANTextEdit()
        {
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"TR\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d?\ \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "IBAN Numaranızı Giriniz";
        }  

        
    }
}
