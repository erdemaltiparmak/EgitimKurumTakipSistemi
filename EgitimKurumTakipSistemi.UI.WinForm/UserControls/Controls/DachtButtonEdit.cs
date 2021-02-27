using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System.Drawing;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    class DachtButtonEdit : ButtonEdit, IStatusBarAciklama
    {
        public DachtButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightBlue;
        }
        //public override bool EnterMoveNextControl { get; set; } = true;
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string StatusBarKisayol { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string StatusBarKisayolAciklama { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
