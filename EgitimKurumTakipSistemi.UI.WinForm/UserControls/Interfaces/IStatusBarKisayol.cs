using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces
{
    interface IStatusBarKisayol : IStatusBarAciklama
    {
        string StatusBarKisayol { get; set; }
        string StatusBarKisayolAciklama { get; set; }

    }
}
