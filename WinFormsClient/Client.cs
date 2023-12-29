using Grpc.Net.Client;
using System.Data;

namespace WinFormsClient
{
	public partial class Client : Form
	{
		private readonly TextBox[] textBoxes;
		public Client()
		{
			InitializeComponent();
			textBoxes = [textBoxEdit1, textBoxEdit2, textBoxEdit3, textBoxEdit4, textBoxEdit5];
		}

		private void JSONtoGrid(string json)
		{
			clientDataSet.Clear();
			BindingSource currentBindingSource = (BindingSource)dataGridView1.DataSource;
			dataGridView1.DataSource = null;
			char[] charsToTrim = ['\'', ' ', ',', '{'];
			int start = json.IndexOf('[');
			json = json.Substring(start + 1, json.IndexOf(']') - start - 1);
			string[] rows = json.Split('}');
			for (int i = 0; i < rows.Length - 1; i++)
			{
				string[] cells = rows[i].Trim(charsToTrim).Split(',');
				currentBindingSource.AddNew();
				DataRowView rowView = (DataRowView)currentBindingSource.Current;
				for (int j = 0; j < cells.Length; j++)
				{
					string[] cell = cells[j].Split(':');
					rowView[j] = cell[1].Trim('\"');
				}
			}
			currentBindingSource.EndEdit();
			dataGridView1.DataSource = currentBindingSource;
		}

		private void buttonInternal(string arguments)
		{
			using var channel = GrpcChannel.ForAddress("https://localhost:7124");
			var client = new Greeter.GreeterClient(channel);
			var reply = client.SayHello(new HelloRequest { Name = arguments });
			if (reply.Message != null)
			{
				textBoxView.Text = reply.Message;
				JSONtoGrid(reply.Message);
			}
			else
				textBoxView.Text = "Service error!";
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			BindingSource source = (BindingSource)dataGridView1.DataSource;
			buttonInternal(source.DataMember + " Add " + textBoxEdit2.Text + " " + textBoxEdit3.Text + " "
							+ textBoxEdit4.Text + " " + textBoxEdit5.Text);
		}

		private void buttonChange_Click(object sender, EventArgs e)
		{
			BindingSource source = (BindingSource)dataGridView1.DataSource;
			buttonInternal(source.DataMember + " Change " + textBoxEdit1.Text + " " + textBoxEdit2.Text + " "
							+ textBoxEdit3.Text + " " + textBoxEdit4.Text + " " + textBoxEdit5.Text);
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			BindingSource source = (BindingSource)dataGridView1.DataSource;
			buttonInternal(source.DataMember + " Delete " + textBoxEdit1.Text);
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
			buttonInternal("Provider");
		}

		private void buttonIncome_Click(object sender, EventArgs e)
		{
			buttonAdd.Enabled = true;
			buttonChange.Enabled = true;
			buttonDelete.Enabled = true;
			for (int i = 2; i < textBoxes.Length; i++)
				textBoxes[i].ReadOnly = false;
			dataGridView1.DataSource = IncomeBindingSource;
			buttonInternal("Income");
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
			buttonInternal("Product");
		}
	}
}