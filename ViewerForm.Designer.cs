namespace DashboardNextPrevTab {
    partial class ViewerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dashboardViewer = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.imageCollection = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.AllowMaximizeDashboardItems = false;
            this.dashboardViewer.AllowPrintDashboard = false;
            this.dashboardViewer.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.dashboardViewer.Appearance.Options.UseBackColor = true;
            this.dashboardViewer.DashboardSource = new System.Uri("Dashboards\\SalesDashboard.xml", System.UriKind.Relative);
            this.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer.Location = new System.Drawing.Point(0, 0);
            this.dashboardViewer.Name = "dashboardViewer";
            this.dashboardViewer.Size = new System.Drawing.Size(1016, 564);
            this.dashboardViewer.TabIndex = 0;
            this.dashboardViewer.CustomizeDashboardTitle += new DevExpress.DashboardWin.CustomizeDashboardTitleEventHandler(this.DashboardViewerCustomizeDashboardTitle);
            this.dashboardViewer.SelectedTabPageChanged += new DevExpress.DashboardCommon.SelectedTabPageChangedEventHandler(this.DashboardViewerSelectedTabPageChanged);
            // 
            // imageCollection
            // 
            this.imageCollection.Add("Next", "image://svgimages/arrows/next.svg");
            this.imageCollection.Add("Prev", "image://svgimages/arrows/prev.svg");
            this.imageCollection.Add("ShowCaption", "image://svgimages/diagramicons/snap to grid.svg");
            this.imageCollection.Add("Slideshow", "image://svgimages/icon builder/business_presentation.svg");
            this.imageCollection.Add("showcaption", "image://svgimages/dashboards/showcaption.svg");
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 564);
            this.Controls.Add(this.dashboardViewer);
            this.Name = "ViewerForm";
            this.Text = "Dashboard Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardViewer dashboardViewer;
        private DevExpress.Utils.SvgImageCollection imageCollection;
    }
}

