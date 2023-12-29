namespace WinFormsClient
{
    partial class Client
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			textBoxView = new TextBox();
			buttonAdd = new Button();
			textBoxEdit1 = new TextBox();
			buttonDelete = new Button();
			buttonChange = new Button();
			textBoxEdit2 = new TextBox();
			textBoxEdit3 = new TextBox();
			textBoxEdit4 = new TextBox();
			textBoxEdit5 = new TextBox();
			buttonProvider = new Button();
			buttonIncome = new Button();
			buttonProduct = new Button();
			dataGridView1 = new DataGridView();
			ProviderBindingSource = new BindingSource(components);
			clientDataSet = new ClientDataSet();
			IncomeBindingSource = new BindingSource(components);
			ProductBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)ProviderBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)clientDataSet).BeginInit();
			((System.ComponentModel.ISupportInitialize)IncomeBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)ProductBindingSource).BeginInit();
			SuspendLayout();
			// 
			// textBoxView
			// 
			textBoxView.Location = new Point(16, 30);
			textBoxView.Margin = new Padding(4, 5, 4, 5);
			textBoxView.Multiline = true;
			textBoxView.Name = "textBoxView";
			textBoxView.Size = new Size(510, 686);
			textBoxView.TabIndex = 1;
			textBoxView.TabStop = false;
			// 
			// buttonAdd
			// 
			buttonAdd.Enabled = false;
			buttonAdd.Location = new Point(1132, 30);
			buttonAdd.Margin = new Padding(4, 5, 4, 5);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(100, 50);
			buttonAdd.TabIndex = 4;
			buttonAdd.Text = "Add new";
			buttonAdd.UseVisualStyleBackColor = true;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// textBoxEdit1
			// 
			textBoxEdit1.Location = new Point(614, 108);
			textBoxEdit1.Margin = new Padding(4, 5, 4, 5);
			textBoxEdit1.Name = "textBoxEdit1";
			textBoxEdit1.ReadOnly = true;
			textBoxEdit1.Size = new Size(159, 27);
			textBoxEdit1.TabIndex = 7;
			textBoxEdit1.TabStop = false;
			// 
			// buttonDelete
			// 
			buttonDelete.Enabled = false;
			buttonDelete.Location = new Point(1348, 30);
			buttonDelete.Margin = new Padding(4, 5, 4, 5);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(100, 50);
			buttonDelete.TabIndex = 6;
			buttonDelete.Text = "Delete";
			buttonDelete.UseVisualStyleBackColor = true;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// buttonChange
			// 
			buttonChange.Enabled = false;
			buttonChange.Location = new Point(1240, 30);
			buttonChange.Margin = new Padding(4, 5, 4, 5);
			buttonChange.Name = "buttonChange";
			buttonChange.Size = new Size(100, 50);
			buttonChange.TabIndex = 5;
			buttonChange.Text = "Change";
			buttonChange.UseVisualStyleBackColor = true;
			buttonChange.Click += buttonChange_Click;
			// 
			// textBoxEdit2
			// 
			textBoxEdit2.Location = new Point(781, 108);
			textBoxEdit2.Margin = new Padding(4, 5, 4, 5);
			textBoxEdit2.Name = "textBoxEdit2";
			textBoxEdit2.Size = new Size(159, 27);
			textBoxEdit2.TabIndex = 8;
			// 
			// textBoxEdit3
			// 
			textBoxEdit3.Location = new Point(948, 108);
			textBoxEdit3.Margin = new Padding(4, 5, 4, 5);
			textBoxEdit3.Name = "textBoxEdit3";
			textBoxEdit3.Size = new Size(159, 27);
			textBoxEdit3.TabIndex = 9;
			// 
			// textBoxEdit4
			// 
			textBoxEdit4.Location = new Point(1115, 108);
			textBoxEdit4.Margin = new Padding(4, 5, 4, 5);
			textBoxEdit4.Name = "textBoxEdit4";
			textBoxEdit4.Size = new Size(159, 27);
			textBoxEdit4.TabIndex = 10;
			// 
			// textBoxEdit5
			// 
			textBoxEdit5.Location = new Point(1282, 108);
			textBoxEdit5.Margin = new Padding(4, 5, 4, 5);
			textBoxEdit5.Name = "textBoxEdit5";
			textBoxEdit5.Size = new Size(159, 27);
			textBoxEdit5.TabIndex = 11;
			// 
			// buttonProvider
			// 
			buttonProvider.Location = new Point(544, 30);
			buttonProvider.Margin = new Padding(4, 5, 4, 5);
			buttonProvider.Name = "buttonProvider";
			buttonProvider.Size = new Size(110, 50);
			buttonProvider.TabIndex = 1;
			buttonProvider.Text = "Provider";
			buttonProvider.UseVisualStyleBackColor = true;
			buttonProvider.Click += buttonProvider_Click;
			// 
			// buttonIncome
			// 
			buttonIncome.Location = new Point(662, 30);
			buttonIncome.Margin = new Padding(4, 5, 4, 5);
			buttonIncome.Name = "buttonIncome";
			buttonIncome.Size = new Size(110, 50);
			buttonIncome.TabIndex = 2;
			buttonIncome.Text = "Income";
			buttonIncome.UseVisualStyleBackColor = true;
			buttonIncome.Click += buttonIncome_Click;
			// 
			// buttonProduct
			// 
			buttonProduct.Location = new Point(780, 30);
			buttonProduct.Margin = new Padding(4, 5, 4, 5);
			buttonProduct.Name = "buttonProduct";
			buttonProduct.Size = new Size(110, 50);
			buttonProduct.TabIndex = 3;
			buttonProduct.Text = "Product";
			buttonProduct.UseVisualStyleBackColor = true;
			buttonProduct.Click += buttonProduct_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(544, 162);
			dataGridView1.Margin = new Padding(4, 5, 4, 5);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(904, 555);
			dataGridView1.TabIndex = 51;
			dataGridView1.RowEnter += dataGridView1_RowEnter;
			// 
			// ProviderBindingSource
			// 
			ProviderBindingSource.DataMember = "Provider";
			ProviderBindingSource.DataSource = clientDataSet;
			// 
			// clientDataSet
			// 
			clientDataSet.DataSetName = "ClientDataSet";
			clientDataSet.Namespace = "http://tempuri.org/ClientDataSet.xsd";
			clientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// IncomeBindingSource
			// 
			IncomeBindingSource.DataMember = "Income";
			IncomeBindingSource.DataSource = clientDataSet;
			// 
			// ProductBindingSource
			// 
			ProductBindingSource.DataMember = "Product";
			ProductBindingSource.DataSource = clientDataSet;
			// 
			// Client
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1461, 739);
			Controls.Add(buttonProduct);
			Controls.Add(buttonIncome);
			Controls.Add(buttonProvider);
			Controls.Add(textBoxEdit5);
			Controls.Add(textBoxEdit4);
			Controls.Add(textBoxEdit3);
			Controls.Add(textBoxEdit2);
			Controls.Add(buttonChange);
			Controls.Add(buttonDelete);
			Controls.Add(textBoxEdit1);
			Controls.Add(buttonAdd);
			Controls.Add(dataGridView1);
			Controls.Add(textBoxView);
			Margin = new Padding(4, 5, 4, 5);
			Name = "Client";
			Text = "Client";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)ProviderBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)clientDataSet).EndInit();
			((System.ComponentModel.ISupportInitialize)IncomeBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)ProductBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.TextBox textBoxView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxEdit1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
		private System.Windows.Forms.TextBox textBoxEdit2;
		private System.Windows.Forms.TextBox textBoxEdit3;
		private System.Windows.Forms.TextBox textBoxEdit4;
		private System.Windows.Forms.TextBox textBoxEdit5;
		private System.Windows.Forms.Button buttonProvider;
		private System.Windows.Forms.Button buttonIncome;
		private System.Windows.Forms.Button buttonProduct;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource ProviderBindingSource;
		private ClientDataSet clientDataSet;
		private System.Windows.Forms.BindingSource IncomeBindingSource;
		private System.Windows.Forms.BindingSource ProductBindingSource;
	}
}

