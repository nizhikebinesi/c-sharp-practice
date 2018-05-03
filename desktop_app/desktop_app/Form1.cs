using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;

using InvestmentLib;

// имя файла как field
namespace desktop_app
{
    public partial class Form1 : Form
    {
        // todo!
        //private string filesample = "D:\some-projects\c-sharp-practice\desktop_app\desktop_app\bin\Debug\another_sample.txt";

        private CultureInfo ci = ReadWriteTools.ci;

        public Form1()
        {
            InitializeComponent();
            foreach(Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, ci);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //anotherProjectsLink = new LinkLabel();
            //anotherProjectsLink.Links.Add(0, 100, "https://github.com/nizhikebinesi");

            this.tabPage1.Text = "Sources";
            this.tabPage2.Text = "Answers";

            int n = 2;
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[n];
            for (int i = 0; i < n; i++)
            {
                columns[i] = new DataGridViewTextBoxColumn();
            }
            columns[0].HeaderText = "Profit";
            columns[0].Name = "Profit";
            columns[1].HeaderText = "Prob";
            columns[1].Name = "Prob";

            this.assetsGrid.Columns.AddRange(columns);

            // this.assetsGrid.Rows.Add();

            int m = 2;
            DataGridViewTextBoxColumn[] columns1 = new DataGridViewTextBoxColumn[n];
            for (int i = 0; i < m; i++)
            {
                columns1[i] = new DataGridViewTextBoxColumn();
            }
            columns1[0].HeaderText = "Current capital";
            columns1[0].Name = "Current capital";
            columns1[1].HeaderText = "Expected capital";
            columns1[1].Name = "Expected capital";

            this.answerGridView.Columns.AddRange(columns1);
        }

        private Tranche readTranche()
        {
            Tranche tranche;// = new Tranche();

            decimal capital = Decimal.Parse(capitalTextBox.Text, ci);
            int period = int.Parse(periodTextBox.Text, ci);
            if (period < 1)
            {
                throw new ArgumentException();
            }

            
            var assets = new List<Asset>();
            for (int i = 0; i < assetsGrid.Rows.Count - 1; i++)
            {
                //var profit = Decimal.Parse(assetsGrid.Rows[i].Cells["Profit"].ToString(), ci);
                //var prob = Decimal.Parse(assetsGrid.Rows[i].Cells["Prob"].ToString(), ci);

                decimal profit = Decimal.Parse(
                            assetsGrid[0, i].Value.ToString(),
                            ci
                       );
                decimal prob = Decimal.Parse(
                             assetsGrid[1, i].Value.ToString(),
                             ci
                        );

                //System.Console.WriteLine(prob);

                assets.Add(new Asset(profit, prob));
            }

            tranche = new Tranche(capital, period, assets);

            return tranche;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MouseEventArgs eventargs = e as MouseEventArgs;
            Button button1 = sender as Button;
            // displays which mouse button I used
            //MessageBox.Show(eventargs.Button.ToString());
            // displays the name of the button I clicked
            //MessageBox.Show(button1.Name.ToString());
            // changes the text of the button
            //if (button1.Text == "I've changed")
            //{
            //    button1.Text = "Hey, I'm old right now!";
            //} else
            //button1.Text = "I've changed";

            try
            {
                Tranche tranche = readTranche();

                InvestmentPlan plan = EasySolve.solve(tranche);

                //var plan = tranche.assets[0].profit.ToString() + " " + tranche.assets[0].prob.ToString();

                this.answerBox.Text = plan.GetFinalProfit().ToString(ci);


                /*
                 * foreach (var asset in tranche.assets)
                    {
                        assetsGrid.Rows.Add(
                asset.profit.ToString(ci), asset.prob.ToString(ci));
            }
            assetsGrid.Visible = true;
                 */
                this.answerGridView.Rows.Clear();
                foreach (var x in plan.plan)
                {
                    this.answerGridView.Rows.Add(x.Item1.ToString(ci), x.Item2.ToString());
                }
                setRowNumber(this.answerGridView);
                this.answerGridView.Visible = true;

                this.answerBox.TabStop = false;
                this.tabControl1.SelectedTab = this.tabPage2;
                this.tabPage2.Visible = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString(ci);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void uploadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.DefaultExt = "*.*";
            fd.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void assetsNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MouseEventArgs eventargs = e as MouseEventArgs;
            Button button1 = sender as Button;

            
            string filename = filenameBox.Text;
            if (filename != "")
            {
                Tranche tranche = ReadWriteTools.ReadConditionFromTextFile(filename);
                

                capitalTextBox.Text = tranche.capital.ToString(ci);
                periodTextBox.Text = tranche.period.ToString(ci);

                assetsGrid.Rows.Clear();
                foreach (var asset in tranche.assets)
                {
                    assetsGrid.Rows.Add(/*this.assetsGrid.Rows.Count,*/ asset.profit.ToString(ci), asset.prob.ToString(ci));
                }
                setRowNumber(this.assetsGrid);
                assetsGrid.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            if (!assetsGrid.Visible)
            {
                assetsGrid.Visible = true;
            }
            this.assetsGrid.Rows.Add(/*this.assetsGrid.Rows.Count*/);
            setRowNumber(this.assetsGrid);
        }

        private void removeRow_Click(object sender, EventArgs e)
        {
            if (assetsGrid.Visible)
            {
                if (assetsGrid.Rows.Count > 1)
                {
                    if (assetsGrid.CurrentRow.Index < assetsGrid.Rows.Count - 1)
                    {
                        assetsGrid.Rows.RemoveAt(assetsGrid.CurrentRow.Index);
                    }
                } else
                {
                    assetsGrid.Visible = false;
                }
                setRowNumber(this.assetsGrid);
            }
        }
    }
}
