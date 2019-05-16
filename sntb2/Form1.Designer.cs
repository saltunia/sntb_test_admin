namespace sntb2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sntbDataSet = new sntb2.sntbDataSet();
            this.protokolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new sntb2.sntbDataSetTableAdapters.TableAdapterManager();
            this.view_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_1TableAdapter = new sntb2.sntbDataSetTableAdapters.View_1TableAdapter();
            this.newTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newTestTableAdapter = new sntb2.sntbDataSetTableAdapters.NewTestTableAdapter();
            this.queriesTableAdapter1 = new sntb2.sntbDataSetTableAdapters.QueriesTableAdapter();
            this.createTestTableAdapter1 = new sntb2.sntbDataSetTableAdapters.CreateTestTableAdapter();
            this.createTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.protokolTableAdapter = new sntb2.sntbDataSetTableAdapters.protokolTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coluser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldoljn_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpredpr_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpr1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltest_time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_reg_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protokolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.sntbDataSet;
            this.view1BindingSource.CurrentChanged += new System.EventHandler(this.view1BindingSource_CurrentChanged);
            // 
            // sntbDataSet
            // 
            this.sntbDataSet.DataSetName = "sntbDataSet";
            this.sntbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // protokolBindingSource
            // 
            this.protokolBindingSource.DataMember = "protokol";
            this.protokolBindingSource.DataSource = this.sntbDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.answersTableAdapter = null;
            this.tableAdapterManager.authorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.biblio_docTableAdapter = null;
            this.tableAdapterManager.biblio_lecTableAdapter = null;
            this.tableAdapterManager.bil_testTableAdapter = null;
            this.tableAdapterManager.bil_voprTableAdapter = null;
            this.tableAdapterManager.bilTableAdapter = null;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.course_materialsTableAdapter = null;
            this.tableAdapterManager.courses_usersTableAdapter = null;
            this.tableAdapterManager.coursesTableAdapter = null;
            this.tableAdapterManager.doc_authorTableAdapter = null;
            this.tableAdapterManager.doc_categTableAdapter = null;
            this.tableAdapterManager.doc_glavaTableAdapter = null;
            this.tableAdapterManager.doc_razrTableAdapter = null;
            this.tableAdapterManager.doc_sdanTableAdapter = null;
            this.tableAdapterManager.doc_soglTableAdapter = null;
            this.tableAdapterManager.doc_temaTableAdapter = null;
            this.tableAdapterManager.doc_utvTableAdapter = null;
            this.tableAdapterManager.doljnostTableAdapter = null;
            this.tableAdapterManager.ed_groupsTableAdapter = null;
            this.tableAdapterManager.glava_punktTableAdapter = null;
            this.tableAdapterManager.izdatTableAdapter = null;
            this.tableAdapterManager.lecture_testsTableAdapter = null;
            this.tableAdapterManager.lecturesTableAdapter = null;
            this.tableAdapterManager.logsTableAdapter = null;
            this.tableAdapterManager.newtable1TableAdapter = null;
            this.tableAdapterManager.newtableTableAdapter = null;
            this.tableAdapterManager.NewTestTableAdapter = null;
            this.tableAdapterManager.osenkaTableAdapter = null;
            this.tableAdapterManager.predprTableAdapter = null;
            this.tableAdapterManager.prog_test_docTableAdapter = null;
            this.tableAdapterManager.prog_testTableAdapter = null;
            this.tableAdapterManager.progTableAdapter = null;
            this.tableAdapterManager.promtest_infoTableAdapter = null;
            this.tableAdapterManager.protokolTableAdapter = null;
            this.tableAdapterManager.questionsTableAdapter = null;
            this.tableAdapterManager.razrabTableAdapter = null;
            this.tableAdapterManager.shifrTableAdapter = null;
            this.tableAdapterManager.status_ed_groupsTableAdapter = null;
            this.tableAdapterManager.systemTableAdapter = null;
            this.tableAdapterManager.Table_1TableAdapter = null;
            this.tableAdapterManager.temaTableAdapter = null;
            this.tableAdapterManager.tematica_ed_groupsTableAdapter = null;
            this.tableAdapterManager.tematica_temaTableAdapter = null;
            this.tableAdapterManager.testsTableAdapter = null;
            this.tableAdapterManager.tip_voprTableAdapter = null;
            this.tableAdapterManager.truthTableAdapter = null;
            this.tableAdapterManager.ttableTableAdapter = null;
            this.tableAdapterManager.type_docTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sntb2.sntbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_NeActivTableAdapter = null;
            this.tableAdapterManager.user_progTableAdapter = null;
            this.tableAdapterManager.users_groupsTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.utverdTableAdapter = null;
            this.tableAdapterManager.vopr_progTableAdapter = null;
            this.tableAdapterManager.vopr_protTableAdapter = null;
            this.tableAdapterManager.vopr_punktTableAdapter = null;
            this.tableAdapterManager.vopr_temaTableAdapter = null;
            // 
            // view_1BindingSource
            // 
            this.view_1BindingSource.DataMember = "View_1";
            this.view_1BindingSource.DataSource = this.sntbDataSet;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // newTestBindingSource
            // 
            this.newTestBindingSource.DataMember = "NewTest";
            this.newTestBindingSource.DataSource = this.sntbDataSet;
            // 
            // newTestTableAdapter
            // 
            this.newTestTableAdapter.ClearBeforeFill = true;
            // 
            // createTestTableAdapter1
            // 
            this.createTestTableAdapter1.ClearBeforeFill = true;
            // 
            // createTestBindingSource
            // 
            this.createTestBindingSource.DataMember = "CreateTest";
            this.createTestBindingSource.DataSource = this.sntbDataSet;
            // 
            // protokolTableAdapter
            // 
            this.protokolTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(964, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Для авторизации двойным щелчком мыши выберите свою фамилию";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Stardust";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.view1BindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1077, 642);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluser_id,
            this.colid,
            this.colpass,
            this.colname,
            this.coldoljn_name,
            this.colpredpr_name,
            this.colExpr1,
            this.coltest_time,
            this.coluser_reg_date});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // coluser_id
            // 
            this.coluser_id.FieldName = "user_id";
            this.coluser_id.Name = "coluser_id";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colpass
            // 
            this.colpass.FieldName = "pass";
            this.colpass.Name = "colpass";
            this.colpass.OptionsColumn.ReadOnly = true;
            // 
            // colname
            // 
            this.colname.Caption = "Ф.И.О.";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.ReadOnly = true;
            this.colname.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // coldoljn_name
            // 
            this.coldoljn_name.Caption = "Должность";
            this.coldoljn_name.FieldName = "doljn_name";
            this.coldoljn_name.Name = "coldoljn_name";
            this.coldoljn_name.OptionsColumn.ReadOnly = true;
            this.coldoljn_name.Visible = true;
            this.coldoljn_name.VisibleIndex = 1;
            // 
            // colpredpr_name
            // 
            this.colpredpr_name.Caption = "Подразделение";
            this.colpredpr_name.FieldName = "predpr_name";
            this.colpredpr_name.Name = "colpredpr_name";
            this.colpredpr_name.OptionsColumn.ReadOnly = true;
            this.colpredpr_name.Visible = true;
            this.colpredpr_name.VisibleIndex = 2;
            // 
            // colExpr1
            // 
            this.colExpr1.Caption = "Название теста";
            this.colExpr1.FieldName = "Expr1";
            this.colExpr1.Name = "colExpr1";
            this.colExpr1.OptionsColumn.ReadOnly = true;
            this.colExpr1.Visible = true;
            this.colExpr1.VisibleIndex = 3;
            // 
            // coltest_time
            // 
            this.coltest_time.Caption = "Время тестирования";
            this.coltest_time.FieldName = "test_time";
            this.coltest_time.Name = "coltest_time";
            this.coltest_time.OptionsColumn.ReadOnly = true;
            this.coltest_time.Visible = true;
            this.coltest_time.VisibleIndex = 4;
            // 
            // coluser_reg_date
            // 
            this.coluser_reg_date.Caption = "Дата регистрации";
            this.coluser_reg_date.FieldName = "user_reg_date";
            this.coluser_reg_date.Name = "coluser_reg_date";
            this.coluser_reg_date.OptionsColumn.ReadOnly = true;
            this.coluser_reg_date.Visible = true;
            this.coluser_reg_date.VisibleIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(9, 701);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(170, 39);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Приступить к тестированию";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 750);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Stardust";
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пользователи";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protokolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sntbDataSet sntbDataSet;
        private sntbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource view_1BindingSource;
        private sntbDataSetTableAdapters.View_1TableAdapter view_1TableAdapter;
        private System.Windows.Forms.BindingSource newTestBindingSource;
        private sntbDataSetTableAdapters.NewTestTableAdapter newTestTableAdapter;
        private sntbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private sntbDataSetTableAdapters.CreateTestTableAdapter createTestTableAdapter1;
        private System.Windows.Forms.BindingSource createTestBindingSource;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private System.Windows.Forms.BindingSource protokolBindingSource;
        private sntbDataSetTableAdapters.protokolTableAdapter protokolTableAdapter;
        private System.Windows.Forms.Label label1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_id;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colpass;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coldoljn_name;
        private DevExpress.XtraGrid.Columns.GridColumn colpredpr_name;
        private DevExpress.XtraGrid.Columns.GridColumn colExpr1;
        private DevExpress.XtraGrid.Columns.GridColumn coltest_time;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_reg_date;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

