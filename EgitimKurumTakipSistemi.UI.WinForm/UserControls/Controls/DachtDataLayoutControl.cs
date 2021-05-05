using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DachtDataLayoutControl : DataLayoutControl
    {
        public DachtDataLayoutControl()
        {
            OptionsFocus.EnableAutoTabOrder = false;
        }
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyLayoutControlImplementor(this);
        }
    }

    internal class MyLayoutControlImplementor : LayoutControlImplementor
    {
        public MyLayoutControlImplementor(ILayoutControlOwner controlOwner) : base(controlOwner)
        {
        }
        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var layoutItem = base.CreateLayoutItem(parent);
            layoutItem.AppearanceItemCaption.ForeColor = Color.Maroon;
            return layoutItem;
        }
        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var layoutGroup = base.CreateLayoutGroup(parent);

            layoutGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            //1
            layoutGroup.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = System.Windows.Forms.SizeType.Absolute;
            layoutGroup.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 200;
            //2
            layoutGroup.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = System.Windows.Forms.SizeType.Percent;
            layoutGroup.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 100;
            //3
            layoutGroup.OptionsTableLayoutGroup.AddColumn();
            layoutGroup.OptionsTableLayoutGroup.ColumnDefinitions[2].SizeType = System.Windows.Forms.SizeType.Absolute;
            layoutGroup.OptionsTableLayoutGroup.ColumnDefinitions[2].Width = 99;

            layoutGroup.OptionsTableLayoutGroup.RowDefinitions.Clear();

            for (int i = 0; i < 10; i++)
            {
                layoutGroup.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = i != 9 ? System.Windows.Forms.SizeType.Absolute : System.Windows.Forms.SizeType.Percent,
                    Height= i !=9 ? 24 : 100
                });
            }


            return layoutGroup;
        }
    }
}
