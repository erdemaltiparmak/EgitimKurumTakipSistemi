using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using EgitimKurumTakipSistemi.UI.WinForm.UserControls.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimKurumTakipSistemi.Common.Helper;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraGrid.Registrator;
using System.ComponentModel;

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls.GridControls
{
    [ToolboxItem(true)]
    public class DachtGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {

            var view = DachtHelper.Cast<DachtGridView>(CreateView("DachtGridView"));
            var kPrimaryColor = Color.Maroon;
            var kPrimaryFontFamily = new FontFamily("Tahoma");

            view.Appearance.ViewCaption.ForeColor = kPrimaryColor;
            view.Appearance.HeaderPanel.ForeColor = kPrimaryColor;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.FooterPanel.ForeColor = kPrimaryColor;
            view.Appearance.FooterPanel.Font = new Font(kPrimaryFontFamily, 8.25f, FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;

            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;


            var idColumn = new DachtGridColumn { Caption = "ID", FieldName = "ID" };
            var kodColumn = new DachtGridColumn { Caption = "Kod", FieldName = "Kod" };

            idColumn.OptionsColumn.AllowEdit = false;
            idColumn.OptionsColumn.ShowInCustomizationForm = false;
            kodColumn.OptionsColumn.AllowEdit = false;
            kodColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            kodColumn.AppearanceCell.Options.UseTextOptions = true;
            kodColumn.Visible = true;
            view.Columns.AddRange(new DachtGridColumn[] { idColumn, kodColumn });
            return view;
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new DachtGridInfoRegistrator());
        }

        private class DachtGridInfoRegistrator : GridInfoRegistrator
        {
            public override BaseView CreateView(GridControl grid) => new DachtGridView(grid);

            public override string ViewName => "DachtGridView";

        }
    }


    public class DachtGridView : GridView
    {
        public DachtGridView(GridControl ownerGrid) : base(ownerGrid) { }
        public DachtGridView() { }

        #region Properties
        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
        #endregion



        #region Overriden

        protected override void OnColumnChangedCore(GridColumn column)
        {

            base.OnColumnChangedCore(column);


            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                DachtHelper.Cast<RepositoryItemDateEdit>(column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }


        }

        protected override GridColumnCollection CreateColumnCollection()
        {
            return new DachtGridColumnCollection(this);

        }

        #endregion

        #region Privates
        private class DachtGridColumnCollection : GridColumnCollection
        {
            public DachtGridColumnCollection(ColumnView view) : base(view)
            {
            }
            protected override GridColumn CreateColumn()
            {
                DachtGridColumn column = new DachtGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
        #endregion
    }
    public class DachtGridColumn : GridColumn, IStatusBarKisayol
    {
        #region Properties
        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
        #endregion
    }


}
