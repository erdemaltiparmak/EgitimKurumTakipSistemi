using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using System;
using System.ComponentModel;
using System.Drawing;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DachtButtonEdit : ButtonEdit, IStatusBarKisayol
    {
        private long? _id;

        #region Constructor
        public DachtButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightBlue;
        }
        #endregion

        #region Properties
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisayol { get; set; } = "F4 :";
        public string StatusBarKisayolAciklama { get; set; }
        #endregion

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
        #endregion

    }

    #region EventArgs
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
