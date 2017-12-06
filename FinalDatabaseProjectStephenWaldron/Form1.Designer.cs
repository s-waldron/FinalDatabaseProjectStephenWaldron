namespace FinalDatabaseProjectStephenWaldron
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getAllDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIEDataSet = new FinalDatabaseProjectStephenWaldron.MOVIEDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ActorClear = new System.Windows.Forms.Button();
            this.ActorListBox = new System.Windows.Forms.ListBox();
            this.ActorSubmit = new System.Windows.Forms.Button();
            this.ActorLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActorFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ProducerListBox = new System.Windows.Forms.ListBox();
            this.ProducerClear = new System.Windows.Forms.Button();
            this.ProducerSubmit = new System.Windows.Forms.Button();
            this.ProducerLName = new System.Windows.Forms.TextBox();
            this.ProducerFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RatingListBox = new System.Windows.Forms.ListBox();
            this.RatingClear = new System.Windows.Forms.Button();
            this.RatingComboBox = new System.Windows.Forms.ComboBox();
            this.RatingSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.GenreListBox = new System.Windows.Forms.ListBox();
            this.GenreClear = new System.Windows.Forms.Button();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.GenreSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DecadeListBox = new System.Windows.Forms.ListBox();
            this.DecadeClear = new System.Windows.Forms.Button();
            this.DecadeSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DecadeComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.CharacterListBox = new System.Windows.Forms.ListBox();
            this.CharacterClear = new System.Windows.Forms.Button();
            this.CharacterSubmit = new System.Windows.Forms.Button();
            this.CharacterFName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.getAllDataTableAdapter = new FinalDatabaseProjectStephenWaldron.MOVIEDataSetTableAdapters.GetAllDataTableAdapter();
            this.mOVIEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmReleaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmGenreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmGenreDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 433);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Database Output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actorFirstNameDataGridViewTextBoxColumn,
            this.actorLastNameDataGridViewTextBoxColumn,
            this.characterNameDataGridViewTextBoxColumn,
            this.characterDescriptionDataGridViewTextBoxColumn,
            this.filmTitleDataGridViewTextBoxColumn,
            this.filmDescriptionDataGridViewTextBoxColumn,
            this.filmReleaseDateDataGridViewTextBoxColumn,
            this.filmGenreNameDataGridViewTextBoxColumn,
            this.filmGenreDescriptionDataGridViewTextBoxColumn,
            this.producerFirstNameDataGridViewTextBoxColumn,
            this.producerLastNameDataGridViewTextBoxColumn,
            this.ratingNameDataGridViewTextBoxColumn,
            this.ratingDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getAllDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // getAllDataBindingSource
            // 
            this.getAllDataBindingSource.DataMember = "GetAllData";
            this.getAllDataBindingSource.DataSource = this.mOVIEDataSet;
            // 
            // mOVIEDataSet
            // 
            this.mOVIEDataSet.DataSetName = "MOVIEDataSet";
            this.mOVIEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ActorClear);
            this.tabPage2.Controls.Add(this.ActorListBox);
            this.tabPage2.Controls.Add(this.ActorSubmit);
            this.tabPage2.Controls.Add(this.ActorLName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ActorFName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search By Actor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ActorClear
            // 
            this.ActorClear.Location = new System.Drawing.Point(116, 64);
            this.ActorClear.Name = "ActorClear";
            this.ActorClear.Size = new System.Drawing.Size(75, 23);
            this.ActorClear.TabIndex = 6;
            this.ActorClear.Text = "Clear";
            this.ActorClear.UseVisualStyleBackColor = true;
            this.ActorClear.Click += new System.EventHandler(this.ActorClear_Click);
            // 
            // ActorListBox
            // 
            this.ActorListBox.FormattingEnabled = true;
            this.ActorListBox.Location = new System.Drawing.Point(13, 115);
            this.ActorListBox.Name = "ActorListBox";
            this.ActorListBox.Size = new System.Drawing.Size(225, 290);
            this.ActorListBox.TabIndex = 5;
            // 
            // ActorSubmit
            // 
            this.ActorSubmit.Location = new System.Drawing.Point(10, 65);
            this.ActorSubmit.Name = "ActorSubmit";
            this.ActorSubmit.Size = new System.Drawing.Size(75, 23);
            this.ActorSubmit.TabIndex = 4;
            this.ActorSubmit.Text = "Submit";
            this.ActorSubmit.UseVisualStyleBackColor = true;
            this.ActorSubmit.Click += new System.EventHandler(this.ActorSubmit_Click);
            // 
            // ActorLName
            // 
            this.ActorLName.Location = new System.Drawing.Point(99, 34);
            this.ActorLName.Name = "ActorLName";
            this.ActorLName.Size = new System.Drawing.Size(100, 20);
            this.ActorLName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Actor Last Name:";
            // 
            // ActorFName
            // 
            this.ActorFName.Location = new System.Drawing.Point(99, 7);
            this.ActorFName.Name = "ActorFName";
            this.ActorFName.Size = new System.Drawing.Size(100, 20);
            this.ActorFName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actor First Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ProducerListBox);
            this.tabPage3.Controls.Add(this.ProducerClear);
            this.tabPage3.Controls.Add(this.ProducerSubmit);
            this.tabPage3.Controls.Add(this.ProducerLName);
            this.tabPage3.Controls.Add(this.ProducerFName);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(787, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search By Producer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ProducerListBox
            // 
            this.ProducerListBox.FormattingEnabled = true;
            this.ProducerListBox.Location = new System.Drawing.Point(7, 96);
            this.ProducerListBox.Name = "ProducerListBox";
            this.ProducerListBox.Size = new System.Drawing.Size(259, 329);
            this.ProducerListBox.TabIndex = 6;
            // 
            // ProducerClear
            // 
            this.ProducerClear.Location = new System.Drawing.Point(116, 66);
            this.ProducerClear.Name = "ProducerClear";
            this.ProducerClear.Size = new System.Drawing.Size(75, 23);
            this.ProducerClear.TabIndex = 5;
            this.ProducerClear.Text = "Clear";
            this.ProducerClear.UseVisualStyleBackColor = true;
            this.ProducerClear.Click += new System.EventHandler(this.ProducerClear_Click);
            // 
            // ProducerSubmit
            // 
            this.ProducerSubmit.Location = new System.Drawing.Point(6, 66);
            this.ProducerSubmit.Name = "ProducerSubmit";
            this.ProducerSubmit.Size = new System.Drawing.Size(75, 23);
            this.ProducerSubmit.TabIndex = 4;
            this.ProducerSubmit.Text = "Submit";
            this.ProducerSubmit.UseVisualStyleBackColor = true;
            this.ProducerSubmit.Click += new System.EventHandler(this.ProducerSubmit_Click);
            // 
            // ProducerLName
            // 
            this.ProducerLName.Location = new System.Drawing.Point(116, 33);
            this.ProducerLName.Name = "ProducerLName";
            this.ProducerLName.Size = new System.Drawing.Size(100, 20);
            this.ProducerLName.TabIndex = 3;
            // 
            // ProducerFName
            // 
            this.ProducerFName.Location = new System.Drawing.Point(117, 7);
            this.ProducerFName.Name = "ProducerFName";
            this.ProducerFName.Size = new System.Drawing.Size(100, 20);
            this.ProducerFName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Producer Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Producer FirstName:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RatingListBox);
            this.tabPage4.Controls.Add(this.RatingClear);
            this.tabPage4.Controls.Add(this.RatingComboBox);
            this.tabPage4.Controls.Add(this.RatingSubmit);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(787, 433);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Search By Rating";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // RatingListBox
            // 
            this.RatingListBox.FormattingEnabled = true;
            this.RatingListBox.Location = new System.Drawing.Point(7, 66);
            this.RatingListBox.Name = "RatingListBox";
            this.RatingListBox.Size = new System.Drawing.Size(249, 355);
            this.RatingListBox.TabIndex = 5;
            // 
            // RatingClear
            // 
            this.RatingClear.Location = new System.Drawing.Point(110, 35);
            this.RatingClear.Name = "RatingClear";
            this.RatingClear.Size = new System.Drawing.Size(75, 23);
            this.RatingClear.TabIndex = 4;
            this.RatingClear.Text = "Clear";
            this.RatingClear.UseVisualStyleBackColor = true;
            this.RatingClear.Click += new System.EventHandler(this.RatingClear_Click);
            // 
            // RatingComboBox
            // 
            this.RatingComboBox.FormattingEnabled = true;
            this.RatingComboBox.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this.RatingComboBox.Location = new System.Drawing.Point(55, 7);
            this.RatingComboBox.Name = "RatingComboBox";
            this.RatingComboBox.Size = new System.Drawing.Size(121, 21);
            this.RatingComboBox.TabIndex = 3;
            this.RatingComboBox.Text = "Select One:";
            // 
            // RatingSubmit
            // 
            this.RatingSubmit.Location = new System.Drawing.Point(10, 36);
            this.RatingSubmit.Name = "RatingSubmit";
            this.RatingSubmit.Size = new System.Drawing.Size(75, 23);
            this.RatingSubmit.TabIndex = 2;
            this.RatingSubmit.Text = "Submit";
            this.RatingSubmit.UseVisualStyleBackColor = true;
            this.RatingSubmit.Click += new System.EventHandler(this.RatingSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rating:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.GenreListBox);
            this.tabPage5.Controls.Add(this.GenreClear);
            this.tabPage5.Controls.Add(this.GenreComboBox);
            this.tabPage5.Controls.Add(this.GenreSubmit);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(787, 433);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Search By Genre";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // GenreListBox
            // 
            this.GenreListBox.FormattingEnabled = true;
            this.GenreListBox.Location = new System.Drawing.Point(7, 64);
            this.GenreListBox.Name = "GenreListBox";
            this.GenreListBox.Size = new System.Drawing.Size(243, 355);
            this.GenreListBox.TabIndex = 4;
            // 
            // GenreClear
            // 
            this.GenreClear.Location = new System.Drawing.Point(116, 33);
            this.GenreClear.Name = "GenreClear";
            this.GenreClear.Size = new System.Drawing.Size(75, 23);
            this.GenreClear.TabIndex = 3;
            this.GenreClear.Text = "Clear";
            this.GenreClear.UseVisualStyleBackColor = true;
            this.GenreClear.Click += new System.EventHandler(this.GenreClear_Click);
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animation",
            "Biography",
            "Comedy",
            "Crime",
            "Drama",
            "Horror"});
            this.GenreComboBox.Location = new System.Drawing.Point(52, 3);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(121, 21);
            this.GenreComboBox.TabIndex = 0;
            this.GenreComboBox.Text = "Select One:";
            // 
            // GenreSubmit
            // 
            this.GenreSubmit.Location = new System.Drawing.Point(10, 34);
            this.GenreSubmit.Name = "GenreSubmit";
            this.GenreSubmit.Size = new System.Drawing.Size(75, 23);
            this.GenreSubmit.TabIndex = 2;
            this.GenreSubmit.Text = "Submit";
            this.GenreSubmit.UseVisualStyleBackColor = true;
            this.GenreSubmit.Click += new System.EventHandler(this.GenreSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Genre:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DecadeListBox);
            this.tabPage6.Controls.Add(this.DecadeClear);
            this.tabPage6.Controls.Add(this.DecadeSubmit);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.DecadeComboBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(787, 433);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Search By Decade";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DecadeListBox
            // 
            this.DecadeListBox.FormattingEnabled = true;
            this.DecadeListBox.Location = new System.Drawing.Point(7, 43);
            this.DecadeListBox.Name = "DecadeListBox";
            this.DecadeListBox.Size = new System.Drawing.Size(256, 381);
            this.DecadeListBox.TabIndex = 4;
            // 
            // DecadeClear
            // 
            this.DecadeClear.Location = new System.Drawing.Point(283, 1);
            this.DecadeClear.Name = "DecadeClear";
            this.DecadeClear.Size = new System.Drawing.Size(75, 23);
            this.DecadeClear.TabIndex = 3;
            this.DecadeClear.Text = "Clear";
            this.DecadeClear.UseVisualStyleBackColor = true;
            this.DecadeClear.Click += new System.EventHandler(this.DecadeClear_Click);
            // 
            // DecadeSubmit
            // 
            this.DecadeSubmit.Location = new System.Drawing.Point(201, 1);
            this.DecadeSubmit.Name = "DecadeSubmit";
            this.DecadeSubmit.Size = new System.Drawing.Size(75, 23);
            this.DecadeSubmit.TabIndex = 2;
            this.DecadeSubmit.Text = "Submit";
            this.DecadeSubmit.UseVisualStyleBackColor = true;
            this.DecadeSubmit.Click += new System.EventHandler(this.DecadeSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Decade:";
            // 
            // DecadeComboBox
            // 
            this.DecadeComboBox.FormattingEnabled = true;
            this.DecadeComboBox.Items.AddRange(new object[] {
            "Select One:",
            "1970",
            "1980",
            "1990",
            "2000",
            "2010"});
            this.DecadeComboBox.Location = new System.Drawing.Point(61, 4);
            this.DecadeComboBox.Name = "DecadeComboBox";
            this.DecadeComboBox.Size = new System.Drawing.Size(121, 21);
            this.DecadeComboBox.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.CharacterListBox);
            this.tabPage7.Controls.Add(this.CharacterClear);
            this.tabPage7.Controls.Add(this.CharacterSubmit);
            this.tabPage7.Controls.Add(this.CharacterFName);
            this.tabPage7.Controls.Add(this.label8);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(787, 433);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Search by Character";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // CharacterListBox
            // 
            this.CharacterListBox.FormattingEnabled = true;
            this.CharacterListBox.Location = new System.Drawing.Point(7, 69);
            this.CharacterListBox.Name = "CharacterListBox";
            this.CharacterListBox.Size = new System.Drawing.Size(270, 355);
            this.CharacterListBox.TabIndex = 4;
            // 
            // CharacterClear
            // 
            this.CharacterClear.Location = new System.Drawing.Point(101, 38);
            this.CharacterClear.Name = "CharacterClear";
            this.CharacterClear.Size = new System.Drawing.Size(75, 23);
            this.CharacterClear.TabIndex = 3;
            this.CharacterClear.Text = "Clear";
            this.CharacterClear.UseVisualStyleBackColor = true;
            this.CharacterClear.Click += new System.EventHandler(this.CharacterClear_Click);
            // 
            // CharacterSubmit
            // 
            this.CharacterSubmit.Location = new System.Drawing.Point(6, 39);
            this.CharacterSubmit.Name = "CharacterSubmit";
            this.CharacterSubmit.Size = new System.Drawing.Size(75, 23);
            this.CharacterSubmit.TabIndex = 2;
            this.CharacterSubmit.Text = "Submit";
            this.CharacterSubmit.UseVisualStyleBackColor = true;
            this.CharacterSubmit.Click += new System.EventHandler(this.CharacterSubmit_Click);
            // 
            // CharacterFName
            // 
            this.CharacterFName.Location = new System.Drawing.Point(101, 7);
            this.CharacterFName.Name = "CharacterFName";
            this.CharacterFName.Size = new System.Drawing.Size(100, 20);
            this.CharacterFName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Character Name:";
            // 
            // getAllDataTableAdapter
            // 
            this.getAllDataTableAdapter.ClearBeforeFill = true;
            // 
            // mOVIEDataSetBindingSource
            // 
            this.mOVIEDataSetBindingSource.DataSource = this.mOVIEDataSet;
            this.mOVIEDataSetBindingSource.Position = 0;
            // 
            // actorFirstNameDataGridViewTextBoxColumn
            // 
            this.actorFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Actor First Name";
            this.actorFirstNameDataGridViewTextBoxColumn.HeaderText = "Actor First Name";
            this.actorFirstNameDataGridViewTextBoxColumn.Name = "actorFirstNameDataGridViewTextBoxColumn";
            // 
            // actorLastNameDataGridViewTextBoxColumn
            // 
            this.actorLastNameDataGridViewTextBoxColumn.DataPropertyName = "Actor Last Name";
            this.actorLastNameDataGridViewTextBoxColumn.HeaderText = "Actor Last Name";
            this.actorLastNameDataGridViewTextBoxColumn.Name = "actorLastNameDataGridViewTextBoxColumn";
            // 
            // characterNameDataGridViewTextBoxColumn
            // 
            this.characterNameDataGridViewTextBoxColumn.DataPropertyName = "Character Name";
            this.characterNameDataGridViewTextBoxColumn.HeaderText = "Character Name";
            this.characterNameDataGridViewTextBoxColumn.Name = "characterNameDataGridViewTextBoxColumn";
            // 
            // characterDescriptionDataGridViewTextBoxColumn
            // 
            this.characterDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Character Description";
            this.characterDescriptionDataGridViewTextBoxColumn.HeaderText = "Character Description";
            this.characterDescriptionDataGridViewTextBoxColumn.Name = "characterDescriptionDataGridViewTextBoxColumn";
            // 
            // filmTitleDataGridViewTextBoxColumn
            // 
            this.filmTitleDataGridViewTextBoxColumn.DataPropertyName = "Film Title";
            this.filmTitleDataGridViewTextBoxColumn.HeaderText = "Film Title";
            this.filmTitleDataGridViewTextBoxColumn.Name = "filmTitleDataGridViewTextBoxColumn";
            // 
            // filmDescriptionDataGridViewTextBoxColumn
            // 
            this.filmDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Film Description";
            this.filmDescriptionDataGridViewTextBoxColumn.HeaderText = "Film Description";
            this.filmDescriptionDataGridViewTextBoxColumn.Name = "filmDescriptionDataGridViewTextBoxColumn";
            // 
            // filmReleaseDateDataGridViewTextBoxColumn
            // 
            this.filmReleaseDateDataGridViewTextBoxColumn.DataPropertyName = "Film Release Date";
            this.filmReleaseDateDataGridViewTextBoxColumn.HeaderText = "Film Release Date";
            this.filmReleaseDateDataGridViewTextBoxColumn.Name = "filmReleaseDateDataGridViewTextBoxColumn";
            // 
            // filmGenreNameDataGridViewTextBoxColumn
            // 
            this.filmGenreNameDataGridViewTextBoxColumn.DataPropertyName = "Film Genre Name";
            this.filmGenreNameDataGridViewTextBoxColumn.HeaderText = "Film Genre Name";
            this.filmGenreNameDataGridViewTextBoxColumn.Name = "filmGenreNameDataGridViewTextBoxColumn";
            // 
            // filmGenreDescriptionDataGridViewTextBoxColumn
            // 
            this.filmGenreDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Film Genre Description";
            this.filmGenreDescriptionDataGridViewTextBoxColumn.HeaderText = "Film Genre Description";
            this.filmGenreDescriptionDataGridViewTextBoxColumn.Name = "filmGenreDescriptionDataGridViewTextBoxColumn";
            // 
            // producerFirstNameDataGridViewTextBoxColumn
            // 
            this.producerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Producer First Name";
            this.producerFirstNameDataGridViewTextBoxColumn.HeaderText = "Producer First Name";
            this.producerFirstNameDataGridViewTextBoxColumn.Name = "producerFirstNameDataGridViewTextBoxColumn";
            // 
            // producerLastNameDataGridViewTextBoxColumn
            // 
            this.producerLastNameDataGridViewTextBoxColumn.DataPropertyName = "Producer Last Name";
            this.producerLastNameDataGridViewTextBoxColumn.HeaderText = "Producer Last Name";
            this.producerLastNameDataGridViewTextBoxColumn.Name = "producerLastNameDataGridViewTextBoxColumn";
            // 
            // ratingNameDataGridViewTextBoxColumn
            // 
            this.ratingNameDataGridViewTextBoxColumn.DataPropertyName = "Rating Name";
            this.ratingNameDataGridViewTextBoxColumn.HeaderText = "Rating Name";
            this.ratingNameDataGridViewTextBoxColumn.Name = "ratingNameDataGridViewTextBoxColumn";
            // 
            // ratingDescriptionDataGridViewTextBoxColumn
            // 
            this.ratingDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Rating Description";
            this.ratingDescriptionDataGridViewTextBoxColumn.HeaderText = "Rating Description";
            this.ratingDescriptionDataGridViewTextBoxColumn.Name = "ratingDescriptionDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 477);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Film Database Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox ActorLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ActorFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProducerLName;
        private System.Windows.Forms.TextBox ProducerFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DecadeComboBox;
        private System.Windows.Forms.Button ActorSubmit;
        private System.Windows.Forms.Button ProducerSubmit;
        private System.Windows.Forms.Button RatingSubmit;
        private System.Windows.Forms.Button GenreSubmit;
        private System.Windows.Forms.Button DecadeSubmit;
        private MOVIEDataSet mOVIEDataSet;
        private System.Windows.Forms.BindingSource getAllDataBindingSource;
        private MOVIEDataSetTableAdapters.GetAllDataTableAdapter getAllDataTableAdapter;
        private System.Windows.Forms.ListBox ActorListBox;
        private System.Windows.Forms.Button ActorClear;
        private System.Windows.Forms.Button ProducerClear;
        private System.Windows.Forms.ListBox ProducerListBox;
        private System.Windows.Forms.ComboBox RatingComboBox;
        private System.Windows.Forms.ListBox RatingListBox;
        private System.Windows.Forms.Button RatingClear;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.BindingSource mOVIEDataSetBindingSource;
        private System.Windows.Forms.ListBox GenreListBox;
        private System.Windows.Forms.Button GenreClear;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button CharacterClear;
        private System.Windows.Forms.Button CharacterSubmit;
        private System.Windows.Forms.TextBox CharacterFName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox CharacterListBox;
        private System.Windows.Forms.Button DecadeClear;
        private System.Windows.Forms.ListBox DecadeListBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmReleaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmGenreNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmGenreDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDescriptionDataGridViewTextBoxColumn;
    }
}

