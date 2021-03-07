using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System;
using System.ComponentModel;
using System.Drawing;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    [ToolboxItem(true)]
    class DachtButtonEdit : ButtonEdit, IStatusBarKisayol
    {
        private long? _id;

        public DachtButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightBlue;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisayol { get; set; } = "F4 :";
        public string StatusBarKisayolAciklama { get; set; }

        #region Events
        [Browsable(false)]
        public long? Id
        {
            get => _id;
            set
            {
                var oldValue = _id;
                var newValue = value;
                if (oldValue == newValue) return;
                _id = value;
                IdChanged?.Invoke(this, new IdChangedEventArgs(oldValue, newValue));
            }
        }


        public event EventHandler<IdChangedEventArgs> IdChanged;

    }

    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(long? oldValue, long? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
        public long? OldValue { get; }
        public long? NewValue { get; }
    } 
    #endregion
}
