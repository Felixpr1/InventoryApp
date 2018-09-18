namespace InventoryManagement.Presentation
{
    partial class frmInventoryManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryManagementForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.frmHomeControl1 = new InventoryManagement.Presentation.frmHomeControl();
            this.frmAddComputer1 = new InventoryManagement.Presentation.frmAddComputer();
            this.frmDeleteForm1 = new InventoryManagement.Presentation.frmDeleteForm();
            this.frmModifyComputer1 = new InventoryManagement.Presentation.frmModifyComputer();
            this.seeComputer1 = new InventoryManagement.Presentation.SeeComputer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSee);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 1080);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "              Borrar Datos";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 40D;
            this.btnDelete.IsTab = true;
            this.btnDelete.Location = new System.Drawing.Point(0, 522);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(23)))));
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(318, 107);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "              Borrar Datos";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.Black;
            this.btnDelete.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSee
            // 
            this.btnSee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnSee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnSee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSee.BorderRadius = 0;
            this.btnSee.ButtonText = "              Ver Datos";
            this.btnSee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSee.DisabledColor = System.Drawing.Color.Gray;
            this.btnSee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSee.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSee.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSee.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSee.Iconimage")));
            this.btnSee.Iconimage_right = null;
            this.btnSee.Iconimage_right_Selected = null;
            this.btnSee.Iconimage_Selected = null;
            this.btnSee.IconMarginLeft = 0;
            this.btnSee.IconMarginRight = 0;
            this.btnSee.IconRightVisible = true;
            this.btnSee.IconRightZoom = 0D;
            this.btnSee.IconVisible = true;
            this.btnSee.IconZoom = 40D;
            this.btnSee.IsTab = true;
            this.btnSee.Location = new System.Drawing.Point(0, 415);
            this.btnSee.Margin = new System.Windows.Forms.Padding(5);
            this.btnSee.Name = "btnSee";
            this.btnSee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnSee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnSee.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(23)))));
            this.btnSee.selected = false;
            this.btnSee.Size = new System.Drawing.Size(318, 107);
            this.btnSee.TabIndex = 4;
            this.btnSee.Text = "              Ver Datos";
            this.btnSee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSee.Textcolor = System.Drawing.Color.Black;
            this.btnSee.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // btnModify
            // 
            this.btnModify.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModify.BorderRadius = 0;
            this.btnModify.ButtonText = "              Modificar Datos";
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.DisabledColor = System.Drawing.Color.Gray;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModify.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModify.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModify.Iconimage")));
            this.btnModify.Iconimage_right = null;
            this.btnModify.Iconimage_right_Selected = null;
            this.btnModify.Iconimage_Selected = null;
            this.btnModify.IconMarginLeft = 0;
            this.btnModify.IconMarginRight = 0;
            this.btnModify.IconRightVisible = true;
            this.btnModify.IconRightZoom = 0D;
            this.btnModify.IconVisible = true;
            this.btnModify.IconZoom = 40D;
            this.btnModify.IsTab = true;
            this.btnModify.Location = new System.Drawing.Point(0, 308);
            this.btnModify.Margin = new System.Windows.Forms.Padding(5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnModify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnModify.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(23)))));
            this.btnModify.selected = false;
            this.btnModify.Size = new System.Drawing.Size(318, 107);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "              Modificar Datos";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Textcolor = System.Drawing.Color.Black;
            this.btnModify.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "              Añadir Computadora";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 40D;
            this.btnAdd.IsTab = true;
            this.btnAdd.Location = new System.Drawing.Point(0, 201);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(23)))));
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(318, 107);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "              Añadir Computadora";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.Black;
            this.btnAdd.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "              Inicio";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 40D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(0, 94);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(23)))));
            this.btnHome.selected = true;
            this.btnHome.Size = new System.Drawing.Size(318, 107);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "              Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.Black;
            this.btnHome.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(23)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 94);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblMinimize);
            this.panel2.Controls.Add(this.lblClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(318, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1602, 94);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventario";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.Location = new System.Drawing.Point(1547, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(25, 20);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = " - ";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimized_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1572, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 20);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = " X ";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmHomeControl1
            // 
            this.frmHomeControl1.Location = new System.Drawing.Point(318, 94);
            this.frmHomeControl1.Name = "frmHomeControl1";
            this.frmHomeControl1.Size = new System.Drawing.Size(1599, 986);
            this.frmHomeControl1.TabIndex = 2;
            // 
            // frmAddComputer1
            // 
            this.frmAddComputer1.Location = new System.Drawing.Point(318, 94);
            this.frmAddComputer1.Name = "frmAddComputer1";
            this.frmAddComputer1.Size = new System.Drawing.Size(1602, 986);
            this.frmAddComputer1.TabIndex = 3;
            // 
            // frmDeleteForm1
            // 
            this.frmDeleteForm1.Location = new System.Drawing.Point(315, 94);
            this.frmDeleteForm1.Name = "frmDeleteForm1";
            this.frmDeleteForm1.Size = new System.Drawing.Size(1602, 983);
            this.frmDeleteForm1.TabIndex = 4;
            // 
            // frmModifyComputer1
            // 
            this.frmModifyComputer1.Location = new System.Drawing.Point(315, 94);
            this.frmModifyComputer1.Name = "frmModifyComputer1";
            this.frmModifyComputer1.Size = new System.Drawing.Size(1602, 983);
            this.frmModifyComputer1.TabIndex = 5;
            // 
            // seeComputer1
            // 
            this.seeComputer1.Location = new System.Drawing.Point(315, 94);
            this.seeComputer1.Name = "seeComputer1";
            this.seeComputer1.Size = new System.Drawing.Size(1602, 983);
            this.seeComputer1.TabIndex = 6;
            // 
            // frmInventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.seeComputer1);
            this.Controls.Add(this.frmModifyComputer1);
            this.Controls.Add(this.frmDeleteForm1);
            this.Controls.Add(this.frmAddComputer1);
            this.Controls.Add(this.frmHomeControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventoryManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Managment";
            this.Load += new System.EventHandler(this.InventoryManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSee;
        private Bunifu.Framework.UI.BunifuFlatButton btnModify;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private frmHomeControl frmHomeControl1;
        private frmAddComputer frmAddComputer1;
        private frmDeleteForm frmDeleteForm1;
        private frmModifyComputer frmModifyComputer1;
        private SeeComputer seeComputer1;
    }
}