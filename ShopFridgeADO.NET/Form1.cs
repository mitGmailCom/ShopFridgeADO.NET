using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShopFridgeADO.NET
{
    public partial class Form1 : Form
    {
        private int NumberCheck { get; set; } = -1;
        private string NameSaller { get; set; } = null;
        private string NameBuyer { get; set; } = null;
        private string Product { get; set; } = null;
        private string CountProduct { get; set; } = null;
        List<int> Receipt = new List<int>();
        List<int> Saled = new List<int>();
        List<int> Buyed = new List<int>();
        List<List<string>> ListCreatingTable = new List<List<string>>();
        //private string[] tempMas = new string[6];
        //private List<string> tempMas = new List<string>();

        private string connectionString = null;
        private SqlConnection conn = null;
        private SqlDataAdapter dAdapter = null;
        private DataSet dataset = null;
        private SqlCommandBuilder commBuild = null;
        private DataTable dtProduct;
        private DataTable dtProductReceipt;
        private DataTable dtProductBalanceSaller;
        private DataTable dtProductBalanceCustomers;
        private DataTable dtSales;
        private DataTable CreatingTable;


        private string partQuerySales = @"insert into Sales(IdProduct, NumberCheck, DateSale, NameSaller, NameBuyer, CountPurchase) values (@idprod, @numbch, @date, @names, @nameb, @count)";
        private string partQueryProductBalanceSaller = @"insert into ProductBalance(IdProduct, Balance, DateProductBalance) values (@idprodbs, @cols, @dates)";
        private string partQueryProductBalanceCustomer = @"insert into ProductBalanceCustomers(IdProduct, BalanceCustomers, DateBalanceCustomers) values (@idprodbc, @colc, @datec)";


        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionShopFriedges"].ConnectionString;
            conn = new SqlConnection();
            dAdapter = new SqlDataAdapter();
            conn.ConnectionString = connectionString;
            CreatingTable = new DataTable();
            CreatingTable.Columns.Add("IdProduct");
            CreatingTable.Columns.Add("NumberCheck");
            CreatingTable.Columns.Add("Date");
            CreatingTable.Columns.Add("Saller");
            CreatingTable.Columns.Add("Buyer");
            CreatingTable.Columns.Add("Count");
        }

        // Загрузка данных в DataSet
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string sql = null;
            // проверка на наличие записей в таблице продажи, если есть взять последнее значение,private string NameBuyer { get; set; } если нет присвоить 1
            try
            {
                //SqlConnection conn = new SqlConnection(connectionString);
                dataset = new DataSet();
                sql = "select * from Product; select IdProduct, sum(CountProduct) as 'CountReceipt' from ProductReceipt group by IdProduct; select IdProduct, sum(CountPurchase) as CountPurchase, NumberCheck from Sales group by IdProduct, NumberCheck; select IdProduct, sum(Balance) as CountSaller from ProductBalance group by IdProduct; select IdProduct, sum(BalanceCustomers) as CountCustomer from ProductBalanceCustomers group by IdProduct";
                dAdapter = new SqlDataAdapter(sql, conn);
                dataGridView1.DataSource = null;
                commBuild = new SqlCommandBuilder(dAdapter);
                dAdapter.Fill(dataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error");
            }
            finally
            {
            }

            dtProduct = dataset.Tables[0];
            dtProductReceipt = dataset.Tables[1];
            if (dataset.Tables[2].Rows.Count > 0)
                dtSales = dataset.Tables[2];

            if (dataset.Tables[3].Rows.Count > 0)
                dtProductBalanceSaller = dataset.Tables[3];

            if (dataset.Tables[4].Rows.Count > 0)
                dtProductBalanceCustomers = dataset.Tables[4];

            if (listBoxProduct.Items.Count != 0)
                listBoxProduct.Items.Clear();
            for (int i = 0; i < dtProduct.Rows.Count; i++)
            {
                listBoxProduct.Items.Add(dtProduct.Rows[i][2].ToString());
            }
        }



        private void btnShowProducts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataset.Tables[0];
        }



        private void btnShowReceipt_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataset.Tables[1];
        }



        private void btnLoadToDB_Click(object sender, EventArgs e)
        {
            bool flagRollback = false;
            conn = new SqlConnection(connectionString);
            SqlCommand comm = conn.CreateCommand();
            SqlTransaction tran = null;
            try
            {
                conn.Open();
                //tran = conn.BeginTransaction();
                ////comm = conn.CreateCommand();
                //comm.Transaction = tran;

                for (int i = 0; i < ListCreatingTable.Count; i++)
                {
                    tran = conn.BeginTransaction();
                    //comm = conn.CreateCommand();
                    comm.Transaction = tran;

                    comm.CommandText = partQuerySales;
                    comm.Parameters.AddWithValue("@idprod", ListCreatingTable[i][0].ToString());
                    comm.Parameters.AddWithValue("@numbch", ListCreatingTable[i][1].ToString());
                    comm.Parameters.AddWithValue("@date", ListCreatingTable[i][2].ToString());
                    comm.Parameters.AddWithValue("@names", ListCreatingTable[i][3].ToString());
                    comm.Parameters.AddWithValue("@nameb", ListCreatingTable[i][4].ToString());
                    comm.Parameters.AddWithValue("@count", ListCreatingTable[i][5].ToString());
                    comm.ExecuteNonQuery();

                    comm.CommandText = partQueryProductBalanceSaller;
                    comm.Parameters.AddWithValue("@idprodbs", ListCreatingTable[i][0].ToString());
                    comm.Parameters.AddWithValue("@cols", ListCreatingTable[i][5].ToString());
                    comm.Parameters.AddWithValue("@dates", ListCreatingTable[i][2].ToString());
                    comm.ExecuteNonQuery();

                    comm.CommandText = partQueryProductBalanceCustomer;
                    comm.Parameters.AddWithValue("@idprodbc", ListCreatingTable[i][0].ToString());
                    comm.Parameters.AddWithValue("@colc", ListCreatingTable[i][5].ToString());
                    comm.Parameters.AddWithValue("@datec", ListCreatingTable[i][2].ToString());
                    comm.ExecuteNonQuery();

                    int sum = 0;
                    for (int j = 0; j < dtProductReceipt.Rows.Count; j++)
                    {
                        for (int k = 0; k < CreatingTable.Rows.Count; k++)
                        {
                            if (dtProductReceipt.Rows[j][0].ToString() == CreatingTable.Rows[k][0].ToString())
                                sum += Int32.Parse(CreatingTable.Rows[k][5].ToString());
                        }
                        if (dtProductBalanceSaller.Rows.Count != 0)
                        {
                            if (dtProductBalanceSaller.Rows.Count > j)
                            {
                                if (dtProductReceipt.Rows[j][0].ToString() == dtProductBalanceSaller.Rows[j][0].ToString())
                                {
                                    int tempRes = Int32.Parse(dtProductReceipt.Rows[j][1].ToString()) - Int32.Parse(dtProductBalanceSaller.Rows[j][1].ToString());
                                    if (tempRes < sum)
                                    {
                                        tran.Rollback();
                                        return;
                                    }
                                }
                            }
                        }
                        sum = 0;
                    }
                    comm.Parameters.Clear();
                    tran.Commit();
                }
                //tran.Commit();
                CreatingTable.Clear();
                CreatingTable = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tran.Rollback();
                CreatingTable.Clear();
                CreatingTable = null;
            }
            finally
            {
                //CreatingTable.Clear();
                CreatingTable = null;
                conn.Close();
            }
        }



        private void btnAddToTable_Click(object sender, EventArgs e)
        {
            List<string> tempMas = new List<string>();
            if (dtSales == null)
                NumberCheck = 1;

            if (dtSales != null)
            {
                if (CreatingTable.Rows.Count != 0)
                    NumberCheck = Int32.Parse(CreatingTable.Rows[CreatingTable.Rows.Count - 1][1].ToString());
                if (CreatingTable.Rows.Count == 0)
                {
                    int res = 0;
                    bool isInt = Int32.TryParse(dtSales.Rows[dtSales.Rows.Count - 1][1].ToString(), out res);
                    if (isInt)
                        NumberCheck = res + 1;
                }
            }
            for (int i = 0; i < dtProduct.Rows.Count; i++)
            {
                if (dtProduct.Rows[i][2].ToString() == listBoxProduct.SelectedItem.ToString())
                    Product = dtProduct.Rows[i][0].ToString();
            }
            NameSaller = txbSaller.Text;
            NameBuyer = txbCustomer.Text;
            CountProduct = txbCountProduct.Text;
            tempMas.Add(Product);
            tempMas.Add(NumberCheck.ToString());
            tempMas.Add(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"));
            tempMas.Add(NameSaller);
            tempMas.Add(NameBuyer);
            tempMas.Add(CountProduct);

            //StringBuilder strB = new StringBuilder();
            //strB.Append(Product);
            //tempMas[0] = strB.ToString();
            //strB.Clear();
            //strB.Append(NumberCheck.ToString());
            //tempMas[1] = strB.ToString();
            //strB.Clear();
            //strB.Append(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"));
            //tempMas[2] = strB.ToString();
            //strB.Clear();
            //strB.Append(NameSaller);
            //tempMas[3] = strB.ToString();
            //strB.Clear();
            //strB.Append(NameBuyer);
            //tempMas[4] = strB.ToString();
            //strB.Clear();
            //strB.Append(CountProduct);
            //tempMas[5] = strB.ToString();
            ListCreatingTable.Add(tempMas);
            
            DataRow newdrow = CreatingTable.NewRow();
            newdrow[0] = Product;
            newdrow[1] = NumberCheck.ToString();
            newdrow[2] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
            newdrow[3] = NameSaller;
            newdrow[4] = NameBuyer;
            newdrow[5] = CountProduct;
            CreatingTable.Rows.Add(newdrow);
            dataGridView1.DataSource = CreatingTable;
        }

        private void btnShowSales_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataset.Tables[2];
        }

        private void btnShowBSaller_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataset.Tables[3];
        }

        private void btnShowBCustomer_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataset.Tables[4];
        }
    }
}
