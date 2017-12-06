using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalDatabaseProjectStephenWaldron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }// end Form1 constructor

        private void DecadeSubmit_Click(object sender, EventArgs e)
        {
            string DecadeVal;
            int DecadeLowValue = 0, DecadeHighValue = 0;
            DecadeVal = DecadeComboBox.SelectedItem.ToString();
            switch (DecadeVal)
            {
                case "1970":
                    DecadeLowValue = 1970;
                    DecadeHighValue = DecadeLowValue + 9;
                    break;
                case "1980":
                    DecadeLowValue = 1980;
                    DecadeHighValue = DecadeLowValue + 9;
                    break;
                case "1990":
                    DecadeLowValue = 1990;
                    DecadeHighValue = DecadeLowValue + 9;
                    break;
                case "2000":
                    DecadeLowValue = 2000;
                    DecadeHighValue = DecadeLowValue + 9;
                    break;
                case "2010":
                    DecadeLowValue = 2010;
                    DecadeHighValue = DecadeLowValue + 9;
                    break;
            }// end switch

            string connectionString =
                "Data Source=LAPTOP-SECF3OTP\\SQLEXPRESS;Initial Catalog=MOVIE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (IDbConnection cxn = new SqlConnection(connectionString))
            {
                using (IDbCommand cmd = cxn.CreateCommand())
                {
                    //  set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    //  set the name of the sproc to call
                    cmd.CommandText = "[dbo].[GetDateInformation]";

                    //  add our parameter
                    IDbDataParameter p1 = cmd.CreateParameter();
                    p1.ParameterName = "DateLowRange";
                    p1.Value = DecadeLowValue;
                    cmd.Parameters.Add(p1);
                    IDbDataParameter p2 = cmd.CreateParameter();
                    p2.ParameterName = "DateHighRange";
                    p2.Value = DecadeHighValue;
                    cmd.Parameters.Add(p2);

                    //  open the connection
                    cxn.Open();

                    //  execute the query and return a data reader ...
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                if(i % 2 == 0)
                                {
                                    DecadeListBox.Items.Add("Film Title: " + dr.GetValue(i));
                                }// end i % 2 == 0 if check
                                if(i % 2 == 1)
                                {
                                    
                                    string DateValue = dr.GetValue(i).ToString();
                                    string TestValue = DateValue.Substring(1, 1);
                                    if (TestValue.Equals("/"))
                                    {
                                        DateValue = DateValue.Substring(0, 9);
                                    }// end TestValue if check
                                    else
                                    {
                                        DateValue = DateValue.Substring(0, 10);
                                    }// end else
                                    DecadeListBox.Items.Add("Film Release Date: " + DateValue);
                                    DecadeListBox.Items.Add("");
                                }// end i % 2 == 1 if check
                            }// end for loop
                        }// end while loop
                    }// end using IDataReader
                }// end using IDbCommand
            }// end using IDbConnection
        }// end DecadeSubmit_Click method

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOVIEDataSet.GetAllData' table. You can move, or remove it, as needed.
            this.getAllDataTableAdapter.Fill(this.mOVIEDataSet.GetAllData);

        }// end Form1_Load method

        private void ActorSubmit_Click(object sender, EventArgs e)
        {
            string ActorFirstName, ActorLastName;
            ActorFirstName = ActorFName.Text;
            ActorLastName = ActorLName.Text;
            string connectionString =
                "Data Source=LAPTOP-SECF3OTP\\SQLEXPRESS;Initial Catalog=MOVIE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (IDbConnection cxn = new SqlConnection(connectionString))
            {
                using (IDbCommand cmd = cxn.CreateCommand())
                {
                    //  set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    //  set the name of the sproc to call
                    cmd.CommandText = "[dbo].[GetActorInformation]";

                    //  add our parameter
                    IDbDataParameter p1 = cmd.CreateParameter();
                    p1.ParameterName = "ActorFName";
                    p1.Value = ActorFirstName;
                    cmd.Parameters.Add(p1);
                    IDbDataParameter p2 = cmd.CreateParameter();
                    p2.ParameterName = "ActorLName";
                    p2.Value = ActorLastName;
                    cmd.Parameters.Add(p2);

                    //  open the connection
                    cxn.Open();

                    //  execute the query and return a data reader ...
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                if(i % 5 == 0)
                                {
                                    ActorListBox.Items.Add("Actor Name: " + dr.GetValue(i) + " " + dr.GetValue(i + 1));
                                }// end i % 5 == 0 if check
                                if(i % 5 == 2)
                                {
                                    ActorListBox.Items.Add("Character Name: " + dr.GetValue(i));
                                }// end i % 5 == 2 if check
                                if(i % 5 == 3)
                                {
                                    ActorListBox.Items.Add("Film Title: " + dr.GetValue(i));
                                }// end i % 5 == 3 if check
                                if(i % 5 == 4)
                                {
                                    string DateValue = dr.GetValue(i).ToString();
                                    string TestValue = DateValue.Substring(1, 1);
                                    if (TestValue.Equals("/"))
                                    {
                                        DateValue = DateValue.Substring(0, 9);
                                    }// end TestValue if check
                                    else
                                    {
                                        DateValue = DateValue.Substring(0, 10);
                                    }// end else
                                    ActorListBox.Items.Add("Film Release Date: " + DateValue);
                                    ActorListBox.Items.Add("");
                                }// end i % 5 == 4 if check
                            }// end for loop
                        }// end while loop
                    }// end using IDataReader
                }// end using IDbCommand
            }// end using IDbConnection
        }// end ActorSubmit_Click method

        private void ActorClear_Click(object sender, EventArgs e)
        {
            ActorFName.Clear();
            ActorLName.Clear();
            ActorListBox.Items.Clear();
        }// end Actor_Clear method

        private void ProducerSubmit_Click(object sender, EventArgs e)
        {
            string ProducerFirstName, ProducerLastName;
            ProducerFirstName = ProducerFName.Text;
            ProducerLastName = ProducerLName.Text;
            string connectionString =
                "Data Source=LAPTOP-SECF3OTP\\SQLEXPRESS;Initial Catalog=MOVIE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (IDbConnection cxn = new SqlConnection(connectionString))
            {
                using (IDbCommand cmd = cxn.CreateCommand())
                {
                    //  set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    //  set the name of the sproc to call
                    cmd.CommandText = "[dbo].[GetProducerInformation]";

                    //  add our parameter
                    IDbDataParameter p1 = cmd.CreateParameter();
                    p1.ParameterName = "ProducerFName";
                    p1.Value = ProducerFirstName;
                    cmd.Parameters.Add(p1);
                    IDbDataParameter p2 = cmd.CreateParameter();
                    p2.ParameterName = "ProducerLName";
                    p2.Value = ProducerLastName;
                    cmd.Parameters.Add(p2);

                    //  open the connection
                    cxn.Open();

                    //  execute the query and return a data reader ...
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                if (i % 4 == 0)
                                {
                                    ProducerListBox.Items.Add("Producer Name: " + dr.GetValue(i) + " " + dr.GetValue(i + 1));
                                }// end i % 4 == 0 if check
                                if (i % 4 == 2)
                                {
                                    ProducerListBox.Items.Add("Film Title: " + dr.GetValue(i));
                                }// end i % 4 == 2 if check
                                if (i % 4 == 3)
                                {
                                    string DateValue = dr.GetValue(i).ToString();
                                    string TestValue = DateValue.Substring(1, 1);
                                    if (TestValue.Equals("/"))
                                    {
                                        DateValue = DateValue.Substring(0, 9);
                                    }// end TestValue if check
                                    else
                                    {
                                        DateValue = DateValue.Substring(0, 10);
                                    }// end else
                                    ProducerListBox.Items.Add("Film Release Date: " + DateValue);
                                    ProducerListBox.Items.Add("");
                                }// end i % 4 == 3 if check
                            }// end for loop
                        }// end while loop
                    }// end using IDataReader
                }// end using IDbCommand
            }// end using IDbConnection
        }// end ProducerSubmit_Click method

        private void ProducerClear_Click(object sender, EventArgs e)
        {
            ProducerFName.Clear();
            ProducerLName.Clear();
            ProducerListBox.Items.Clear();
        }// end ProducerClear_Click method

        private void RatingSubmit_Click(object sender, EventArgs e)
        {
            int RatingIndex;
            string RatingValue = "";
            RatingIndex = RatingComboBox.SelectedIndex;
            switch (RatingIndex)
            {
                case 0:
                    RatingValue = "G";
                    break;
                case 1:
                    RatingValue = "PG";
                    break;
                case 2:
                    RatingValue = "PG-13";
                    break;
                case 3:
                    RatingValue = "R";
                    break;
            }// end switch case

            string connectionString =
                "Data Source=LAPTOP-SECF3OTP\\SQLEXPRESS;Initial Catalog=MOVIE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (IDbConnection cxn = new SqlConnection(connectionString))
            {
                using (IDbCommand cmd = cxn.CreateCommand())
                {
                    //  set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    //  set the name of the sproc to call
                    cmd.CommandText = "[dbo].[GetRatingInformation]";

                    //  add our parameter
                    IDbDataParameter p1 = cmd.CreateParameter();
                    p1.ParameterName = "RatingValue";
                    p1.Value = RatingValue;
                    cmd.Parameters.Add(p1);

                    //  open the connection
                    cxn.Open();

                    //  execute the query and return a data reader ...
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                RatingListBox.Items.Add("Film Title: " + dr.GetValue(i));
                                RatingListBox.Items.Add("");
                            }// end for loop
                        }// end while loop
                    }// end using IDataReader
                }// end using IDbCommand
            }// end using IDbConnection
        }// end RatingSubmit_Click method

        private void RatingClear_Click(object sender, EventArgs e)
        {
            RatingListBox.Items.Clear();
        }// end RatingClear_Click method

        private void GenreSubmit_Click(object sender, EventArgs e)
        {
            string GenreSelected;
            GenreSelected = GenreComboBox.SelectedItem.ToString();

            string connectionString =
                "Data Source=LAPTOP-SECF3OTP\\SQLEXPRESS;Initial Catalog=MOVIE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (IDbConnection cxn = new SqlConnection(connectionString))
            {
                using (IDbCommand cmd = cxn.CreateCommand())
                {
                    //  set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    //  set the name of the sproc to call
                    cmd.CommandText = "[dbo].[GetGenreInformation]";

                    //  add our parameter
                    IDbDataParameter p1 = cmd.CreateParameter();
                    p1.ParameterName = "GenreValue";
                    p1.Value = GenreSelected;
                    cmd.Parameters.Add(p1);

                    //  open the connection
                    cxn.Open();

                    //  execute the query and return a data reader ...
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                GenreListBox.Items.Add("Film Title: " + dr.GetValue(i));
                                GenreListBox.Items.Add("");
                            }// end for loop
                        }// end while loop
                    }// end using IDataReader
                }// end using IDbCommand
            }// end using IDbConnection
        }// end GenreSubmit_Click method

        private void GenreClear_Click(object sender, EventArgs e)
        {
            GenreListBox.Items.Clear();
        }// end GenreClear_Click method

        private void CharacterSubmit_Click(object sender, EventArgs e)
        {
            string CharacterValue;
            CharacterValue = CharacterFName.Text;

            string connectionString =
                "Data Source=LAPTOP-SECF3OTP\\SQLEXPRESS;Initial Catalog=MOVIE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (IDbConnection cxn = new SqlConnection(connectionString))
            {
                using (IDbCommand cmd = cxn.CreateCommand())
                {
                    //  set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    //  set the name of the sproc to call
                    cmd.CommandText = "[dbo].[GetCharacterInformation]";

                    //  add our parameter
                    IDbDataParameter p1 = cmd.CreateParameter();
                    p1.ParameterName = "CharacterFNameValue";
                    p1.Value = CharacterValue;
                    cmd.Parameters.Add(p1);

                    //  open the connection
                    cxn.Open();

                    //  execute the query and return a data reader ...
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                if (i % 5 == 0)
                                {
                                    CharacterListBox.Items.Add("Actor Name: " + dr.GetValue(i) + " " + dr.GetValue(i + 1));
                                }// end i % 4 == 0 if check
                                if (i % 5 == 2)
                                {
                                    CharacterListBox.Items.Add("Character Name: " + dr.GetValue(i));
                                }// end i % 4 == 2 if check
                                if (i % 5 == 3)
                                {
                                    CharacterListBox.Items.Add("Film Title: " + dr.GetValue(i));
                                }// end i % 4 == 3 if check
                                if (i % 5 == 4)
                                {
                                    string DateValue = dr.GetValue(i).ToString();
                                    string TestValue = DateValue.Substring(1, 1);
                                    if (TestValue.Equals("/"))
                                    {
                                        DateValue = DateValue.Substring(0, 9);
                                    }// end TestValue if check
                                    else
                                    {
                                        DateValue = DateValue.Substring(0, 10);
                                    }// end else
                                    CharacterListBox.Items.Add("Film Release Date: " + DateValue);
                                    CharacterListBox.Items.Add("");
                                }// end i % 5 == 4 if check
                            }// end for loop
                        }// end while loop
                    }// end using IDataReader
                }// end using IDbCommand
            }// end using IDbConnection
        }// end CharacterSubmit_Click method

        private void CharacterClear_Click(object sender, EventArgs e)
        {
            CharacterFName.Clear();
            CharacterListBox.Items.Clear();
        }// end CharacterClear_Click method

        private void DecadeClear_Click(object sender, EventArgs e)
        {
            DecadeListBox.Items.Clear();
        }// end DecadeClear_Click method

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }// end dataGridView1_CellContentClick method
    }// end Form1 class
}// end namespace