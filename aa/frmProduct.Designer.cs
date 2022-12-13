
namespace aa
{
    partial class frmProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinMáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttEdit = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCuaHangMayTinhDataSet = new aa.QLCuaHangMayTinhDataSet();
            this.txtGb = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMMT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thongTinMayTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinMayTinhTableAdapter = new aa.QLCuaHangMayTinhDataSetTableAdapters.ThongTinMayTinhTableAdapter();
            this.nhaCungCapTableAdapter = new aa.QLCuaHangMayTinhDataSetTableAdapters.NhaCungCapTableAdapter();
            this.maMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCuaHangMayTinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinMayTinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýThôngTinToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýThôngTinToolStripMenuItem
            // 
            this.quảnLýThôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.thôngTinKháchHàngToolStripMenuItem,
            this.thôngTinNhânViênToolStripMenuItem,
            this.thôngTinMáToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.quảnLýThôngTinToolStripMenuItem.Name = "quảnLýThôngTinToolStripMenuItem";
            this.quảnLýThôngTinToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.quảnLýThôngTinToolStripMenuItem.Text = "Quản lý thông tin";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.quảnLýToolStripMenuItem.Text = "Nhà cung cấp";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.thôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHàngToolStripMenuItem_Click);
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            this.thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            this.thôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.thôngTinNhânViênToolStripMenuItem.Text = "Nhân viên";
            this.thôngTinNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNhânViênToolStripMenuItem_Click);
            // 
            // thôngTinMáToolStripMenuItem
            // 
            this.thôngTinMáToolStripMenuItem.Name = "thôngTinMáToolStripMenuItem";
            this.thôngTinMáToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.thôngTinMáToolStripMenuItem.Text = "Máy tính";
            this.thôngTinMáToolStripMenuItem.Click += new System.EventHandler(this.thôngTinMáToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bánToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.thôngTinToolStripMenuItem.Text = "Hóa đơn";
            // 
            // bánToolStripMenuItem
            // 
            this.bánToolStripMenuItem.Name = "bánToolStripMenuItem";
            this.bánToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.bánToolStripMenuItem.Text = "Bán";
            this.bánToolStripMenuItem.Click += new System.EventHandler(this.bánToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.bttDelete);
            this.groupBox1.Controls.Add(this.bttEdit);
            this.groupBox1.Controls.Add(this.bttAdd);
            this.groupBox1.Controls.Add(this.bttRefresh);
            this.groupBox1.Location = new System.Drawing.Point(669, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(30, 140);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 3;
            this.bttDelete.Text = "Xóa";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttEdit
            // 
            this.bttEdit.Location = new System.Drawing.Point(30, 100);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(75, 23);
            this.bttEdit.TabIndex = 2;
            this.bttEdit.Text = "Sửa";
            this.bttEdit.UseVisualStyleBackColor = true;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(30, 60);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 23);
            this.bttAdd.TabIndex = 1;
            this.bttAdd.Text = "Thêm Mới";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttRefresh
            // 
            this.bttRefresh.Location = new System.Drawing.Point(30, 20);
            this.bttRefresh.Name = "bttRefresh";
            this.bttRefresh.Size = new System.Drawing.Size(75, 23);
            this.bttRefresh.TabIndex = 0;
            this.bttRefresh.Text = "Làm Mới";
            this.bttRefresh.UseVisualStyleBackColor = true;
            this.bttRefresh.Click += new System.EventHandler(this.bttRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtGb);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.txtMMT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox2.Location = new System.Drawing.Point(0, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 182);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin máy tính";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.nhaCungCapBindingSource;
            this.comboBox1.DisplayMember = "MaNCC";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(453, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "MaNCC";
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.qLCuaHangMayTinhDataSet;
            // 
            // qLCuaHangMayTinhDataSet
            // 
            this.qLCuaHangMayTinhDataSet.DataSetName = "QLCuaHangMayTinhDataSet";
            this.qLCuaHangMayTinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtGb
            // 
            this.txtGb.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGb.Location = new System.Drawing.Point(453, 93);
            this.txtGb.Name = "txtGb";
            this.txtGb.Size = new System.Drawing.Size(138, 22);
            this.txtGb.TabIndex = 4;
            this.txtGb.Text = "0";
            this.txtGb.TextChanged += new System.EventHandler(this.txtGb_TextChanged);
            this.txtGb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGb_KeyPress);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(153, 93);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(138, 22);
            this.txtTen.TabIndex = 2;
            // 
            // txtMMT
            // 
            this.txtMMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMMT.Location = new System.Drawing.Point(153, 38);
            this.txtMMT.Name = "txtMMT";
            this.txtMMT.Size = new System.Drawing.Size(138, 22);
            this.txtMMT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá Bán(VNĐ)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã NCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên MT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã MT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMTDataGridViewTextBoxColumn,
            this.tenmtDataGridViewTextBoxColumn,
            this.maNCCDataGridViewTextBoxColumn,
            this.giabanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thongTinMayTinhBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 247);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // thongTinMayTinhBindingSource
            // 
            this.thongTinMayTinhBindingSource.DataMember = "ThongTinMayTinh";
            this.thongTinMayTinhBindingSource.DataSource = this.qLCuaHangMayTinhDataSet;
            // 
            // thongTinMayTinhTableAdapter
            // 
            this.thongTinMayTinhTableAdapter.ClearBeforeFill = true;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // maMTDataGridViewTextBoxColumn
            // 
            this.maMTDataGridViewTextBoxColumn.DataPropertyName = "MaMT";
            this.maMTDataGridViewTextBoxColumn.HeaderText = "Mã MT";
            this.maMTDataGridViewTextBoxColumn.Name = "maMTDataGridViewTextBoxColumn";
            this.maMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenmtDataGridViewTextBoxColumn
            // 
            this.tenmtDataGridViewTextBoxColumn.DataPropertyName = "tenmt";
            this.tenmtDataGridViewTextBoxColumn.HeaderText = "Tên MT";
            this.tenmtDataGridViewTextBoxColumn.Name = "tenmtDataGridViewTextBoxColumn";
            this.tenmtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "Mã NCC";
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            this.maNCCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giabanDataGridViewTextBoxColumn
            // 
            this.giabanDataGridViewTextBoxColumn.DataPropertyName = "giaban";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.giabanDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.giabanDataGridViewTextBoxColumn.HeaderText = "Giá Bán (VNĐ)";
            this.giabanDataGridViewTextBoxColumn.Name = "giabanDataGridViewTextBoxColumn";
            this.giabanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Máy Tính";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCuaHangMayTinhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinMayTinhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinMáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttEdit;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtGb;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMMT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLCuaHangMayTinhDataSet qLCuaHangMayTinhDataSet;
        private System.Windows.Forms.BindingSource thongTinMayTinhBindingSource;
        private QLCuaHangMayTinhDataSetTableAdapters.ThongTinMayTinhTableAdapter thongTinMayTinhTableAdapter;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private QLCuaHangMayTinhDataSetTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabanDataGridViewTextBoxColumn;
    }
}