using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    [ToolboxItem(true)]
     public class DachtEMailTextEdit:DachtTextEdit
    {
        public DachtEMailTextEdit()
        {
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            Properties.Mask.EditMask = @"((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
            Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
        }
    }
}
