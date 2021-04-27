
namespace EgitimKurumTakipSistemi.UI.WinForm.UserControls.Controls.NavigatorControls
{
    partial class InsertUpdateNavControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertUpdateNavControl));
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.ImageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Buttons.Append.ImageIndex = 6;
            this.controlNavigator1.Buttons.CancelEdit.Visible = false;
            this.controlNavigator1.Buttons.Edit.Visible = false;
            this.controlNavigator1.Buttons.EndEdit.Visible = false;
            this.controlNavigator1.Buttons.First.ImageIndex = 1;
            this.controlNavigator1.Buttons.ImageList = this.ImageCollection1;
            this.controlNavigator1.Buttons.Last.ImageIndex = 4;
            this.controlNavigator1.Buttons.Next.ImageIndex = 3;
            this.controlNavigator1.Buttons.NextPage.ImageIndex = 5;
            this.controlNavigator1.Buttons.NextPage.Visible = false;
            this.controlNavigator1.Buttons.Prev.ImageIndex = 2;
            this.controlNavigator1.Buttons.PrevPage.ImageIndex = 0;
            this.controlNavigator1.Buttons.PrevPage.Visible = false;
            this.controlNavigator1.Buttons.Remove.ImageIndex = 7;
            this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator1.Location = new System.Drawing.Point(0, 0);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.Size = new System.Drawing.Size(597, 26);
            this.controlNavigator1.TabIndex = 0;
            this.controlNavigator1.Text = "controlNavigator1";
            // 
            // ImageCollection1
            // 
            this.ImageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImageCollection1.ImageStream")));
            this.ImageCollection1.Images.SetKeyName(0, "doubleprev_16x16.png");
            this.ImageCollection1.Images.SetKeyName(1, "first_16x16.png");
            this.ImageCollection1.Images.SetKeyName(2, "prev_16x16.png");
            this.ImageCollection1.Images.SetKeyName(3, "next_16x16.png");
            this.ImageCollection1.Images.SetKeyName(4, "last_16x16.png");
            this.ImageCollection1.Images.SetKeyName(5, "doublenext_16x16.png");
            this.ImageCollection1.InsertImage(global::EgitimKurumTakipSistemi.UI.WinForm.Properties.Resources.additem_16x16, "additem_16x16", typeof(global::EgitimKurumTakipSistemi.UI.WinForm.Properties.Resources), 6);
            this.ImageCollection1.Images.SetKeyName(6, "additem_16x16");
            this.ImageCollection1.InsertImage(global::EgitimKurumTakipSistemi.UI.WinForm.Properties.Resources.deletelist_16x16, "deletelist_16x16", typeof(global::EgitimKurumTakipSistemi.UI.WinForm.Properties.Resources), 7);
            this.ImageCollection1.Images.SetKeyName(7, "deletelist_16x16");
            // 
            // InsertUpdateNavControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlNavigator1);
            this.Name = "InsertUpdateNavControl";
            this.Size = new System.Drawing.Size(597, 26);
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.Utils.ImageCollection ImageCollection1;
    }
}
