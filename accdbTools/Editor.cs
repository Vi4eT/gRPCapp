using System.Data;

namespace accdbTools
{
	public partial class Editor : Form
    {
		public string JSONfile = Directory.GetCurrentDirectory().Replace("accdbTools\\bin\\Debug\\net8.0-windows", "Table.json");
		private BindingSource? currentBindingSource;
		private dynamic? currentTableAdapter;
		private dynamic? currentTable;
		private readonly TextBox[] textBoxes;
		public Editor()
        {
            InitializeComponent();
			textBoxes = [textBoxEdit1, textBoxEdit2, textBoxEdit3, textBoxEdit4, textBoxEdit5];
		}

		public void SetCurrentTable(string tableName)
		{
			switch (tableName)
			{
				case "Provider":
					currentBindingSource = ProviderBindingSource;
					currentTableAdapter = ProviderTableAdapter;
					currentTable = TestDBDataSet.Provider;
					break;
				case "Income":
					currentBindingSource = IncomeBindingSource;
					currentTableAdapter = IncomeTableAdapter;
					currentTable = TestDBDataSet.Income;
					break;
				case "Product":
					currentBindingSource = ProductBindingSource;
					currentTableAdapter = ProductTableAdapter;
					currentTable = TestDBDataSet.Product;
					break;
			}
		}

		public string GridToJSON()
		{
			string json = "{\"" + currentBindingSource!.DataMember + "\":[";
			currentTableAdapter!.Fill(currentTable);
			currentBindingSource.MoveFirst();
			for (int i = 0; i < currentBindingSource.Count; i++)
			{
				json += "{";
				DataRowView rowView = (DataRowView)currentBindingSource.Current;
				DataRow row = rowView.Row;
				foreach (DataColumn c in row.Table.Columns)
				{
					json += "\"" + c.ColumnName + "\":";
					string str = Convert.ToString(row[c.ColumnName])!;
					if (row[c.ColumnName].GetType().Name == "Int32")
						json += str;
					else
						json += "\"" + str + "\"";
					json += c.Equals(row.Table.Columns[row.Table.Columns.Count - 1]) ? "}" : ",";
				}
				currentBindingSource.MoveNext();
				json += (i + 1 < currentBindingSource.Count) ? "," : "]}";
			}
			return json;
		}

		public void SaveJSON()
		{
			textBoxView.Text = GridToJSON();
			StreamWriter sw = new(JSONfile);
			sw.Write(textBoxView.Text);
			sw.Close();
		}

		public void EditTable(string[] args)
		{
			currentTableAdapter!.Fill(currentTable);
			DataRowView rowView = (DataRowView)currentBindingSource!.Current;
			switch (args[1])
			{
				case "Add":
					rowView = (DataRowView)currentBindingSource.AddNew();
					for (int i = 1; i < rowView.Row.Table.Columns.Count && i + 1 < args.Length; i++)
						rowView[i] = args[i + 1];
					break;
				case "Change":
					currentBindingSource.Filter = rowView.Row.Table.Columns[0].ColumnName + "=" + args[2];
					rowView = (DataRowView)currentBindingSource.Current;
					for (int i = 1; i < rowView.Row.Table.Columns.Count && i + 2 < args.Length; i++)
						rowView[i] = args[i + 2];
					break;
				case "Delete":
					currentBindingSource.Filter = rowView.Row.Table.Columns[0].ColumnName + "=" + args[2];
					currentBindingSource.Remove(currentBindingSource.Current);
					break;
			}
			currentBindingSource.EndEdit();
			currentTableAdapter.Update(currentTable);
			currentTableAdapter.Fill(currentTable);
			currentBindingSource.Filter = "";
			SaveJSON();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			BindingSource source = (BindingSource)dataGridView1.DataSource;
			EditTable([source.DataMember, "Add", textBoxEdit2.Text, textBoxEdit3.Text, textBoxEdit4.Text, textBoxEdit5.Text]);
		}

		private void buttonChange_Click(object sender, EventArgs e)
		{
			BindingSource source = (BindingSource)dataGridView1.DataSource;
			EditTable([source.DataMember, "Change", textBoxEdit1.Text, textBoxEdit2.Text, textBoxEdit3.Text, 
						textBoxEdit4.Text, textBoxEdit5.Text]);
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			BindingSource source = (BindingSource)dataGridView1.DataSource;
			EditTable([source.DataMember, "Delete", textBoxEdit1.Text]);
		}

		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			for (int i = 0; i < dataGridView1.Columns.Count; i++)
				textBoxes[i].Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[i].Value);
		}

		private void buttonProvider_Click(object sender, EventArgs e)
		{
			buttonAdd.Enabled = true;
			buttonChange.Enabled = true;
			buttonDelete.Enabled = true;
			for (int i = 2; i < textBoxes.Length; i++)
			{
				textBoxes[i].ReadOnly = true;
				textBoxes[i].Text = "";
			}
			dataGridView1.DataSource = ProviderBindingSource;
			SetCurrentTable("Provider");
			SaveJSON();
		}

		private void buttonIncome_Click(object sender, EventArgs e)
		{
			buttonAdd.Enabled = true;
			buttonChange.Enabled = true;
			buttonDelete.Enabled = true;
			for (int i = 2; i < textBoxes.Length; i++)
				textBoxes[i].ReadOnly = false;
			dataGridView1.DataSource = IncomeBindingSource;
			SetCurrentTable("Income");
			SaveJSON();
		}

		private void buttonProduct_Click(object sender, EventArgs e)
		{
			buttonAdd.Enabled = true;
			buttonChange.Enabled = true;
			buttonDelete.Enabled = true;
			for (int i = 2; i < textBoxes.Length; i++)
			{
				textBoxes[i].ReadOnly = true;
				textBoxes[i].Text = "";
			}
			dataGridView1.DataSource = ProductBindingSource;
			SetCurrentTable("Product");
			SaveJSON();
		}
	}
}