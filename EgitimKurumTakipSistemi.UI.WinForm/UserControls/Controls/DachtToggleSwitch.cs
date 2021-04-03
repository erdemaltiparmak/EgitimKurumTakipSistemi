using DevExpress.XtraEditors;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    public class DachtToggleSwitch : ToggleSwitch,IStatusBarAciklama
    {
        public DachtToggleSwitch()
        {
            Name = "tglDurum";
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; } = "Kullanım Durumunu Seçiniz";
    }
}
