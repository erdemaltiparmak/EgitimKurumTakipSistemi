using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    public class DachtMemoEdit : MemoEdit
    {
        public DachtMemoEdit()
        {
            base.Properties.Appearance.BackColor = Color.LightCyan;
            base.Properties.MaxLength = 500;
        }
    }
}
