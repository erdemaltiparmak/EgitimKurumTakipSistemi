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

namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls.GridControls
{
    public class DachtGridControl:GridControl
    {
        protected override BaseView CreateDefaultView()
        {

            var view = DachtHelper.Cast<DachtGridView>(CreateView("DachtGridView"));

            var idColumn = new DachtGridColumn{Caption = "ID",FieldName = "ID"};
            var kodColumn = new DachtGridColumn {Caption = "Kod", FieldName = "Kod"};

            idColumn.OptionsColumn.AllowEdit = false;
            idColumn.OptionsColumn.ShowInCustomizationForm = false;

            kodColumn.OptionsColumn.AllowEdit = false;
            kodColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            kodColumn.AppearanceCell.Options.UseTextOptions = true;

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
            public override BaseView CreateView(GridControl grid)
            {
                return new DachtGridView(grid);
            }
            public override string ViewName =>  DachtGridView.GridName;

        }
    }

     
    public class DachtGridView:GridView
    {
        public DachtGridView(GridControl ownerGrid) : base(ownerGrid){ }
        public DachtGridView() { }
      
        #region Properties
        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
        public static string GridName { get => "DachtGridView"; }
       #endregion

    

        #region Overriden
        protected override BaseViewAppearanceCollection CreateAppearances()
    {
        var kPrimaryColor = Color.Maroon;
        var kPrimaryFontFamily = new FontFamily("Tahoma");

        Appearance.ViewCaption.ForeColor = kPrimaryColor;
        Appearance.HeaderPanel.ForeColor = kPrimaryColor;
        Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
        Appearance.FooterPanel.ForeColor = kPrimaryColor;
        Appearance.FooterPanel.Font = new Font(kPrimaryFontFamily, 8.25f, FontStyle.Bold);

        OptionsMenu.EnableColumnMenu = false;
        OptionsMenu.EnableFooterMenu = false;
        OptionsMenu.EnableGroupPanelMenu = false;

        OptionsNavigation.EnterMoveNextColumn = true;

        OptionsPrint.AutoWidth = false;
        OptionsPrint.PrintFooter = false;
        OptionsPrint.PrintGroupFooter = false;

        OptionsView.ShowViewCaption = true;
        OptionsView.ShowGroupPanel = false;
        OptionsView.ShowAutoFilterRow = true;
        OptionsView.ColumnAutoWidth = false;
        OptionsView.RowAutoHeight = true;
        OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;
        
        
      
        return base.CreateAppearances();

    }
        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);
            if(column.ColumnEdit!=null)
            {
                var cellHorizontalAlignment = column.AppearanceCell.TextOptions.HAlignment;

                if (column.ColumnEdit.GetType()==typeof(RepositoryItemDateEdit))
                {
                    cellHorizontalAlignment = HorzAlignment.Center;
                    DachtHelper.Cast<RepositoryItemDateEdit>(column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
                }
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
