namespace MovieManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtMovieID = new TextBox();
            txtMovieTitle = new TextBox();
            txtMovieDirector = new TextBox();
            btnAddMovie = new Button();
            btnUpdateMovie = new Button();
            btnDeleteMovie = new Button();
            btnSaveMovies = new Button();
            btnLoadMovies = new Button();
            label6 = new Label();
            btnViewAllMovies = new Button();
            MOVIES = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 52);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 0;
            label1.Text = "MOVIEID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            label2.Location = new Point(44, 109);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 1;
            label2.Text = "TITLE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            label3.Location = new Point(44, 170);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 2;
            label3.Text = "GENRE";
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(12, 224);
            label4.Name = "label4";
            label4.Size = new Size(176, 78);
            label4.TabIndex = 3;
            label4.Text = "RELEASE DATE";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 318);
            label5.Name = "label5";
            label5.Size = new Size(139, 26);
            label5.TabIndex = 4;
            label5.Text = "DIRECTOR";
            label5.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 167);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(304, 33);
            comboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(189, 247);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(304, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // txtMovieID
            // 
            txtMovieID.Location = new Point(189, 53);
            txtMovieID.Name = "txtMovieID";
            txtMovieID.Size = new Size(304, 31);
            txtMovieID.TabIndex = 7;
            // 
            // txtMovieTitle
            // 
            txtMovieTitle.Location = new Point(189, 108);
            txtMovieTitle.Name = "txtMovieTitle";
            txtMovieTitle.Size = new Size(304, 31);
            txtMovieTitle.TabIndex = 8;
            // 
            // txtMovieDirector
            // 
            txtMovieDirector.Location = new Point(189, 313);
            txtMovieDirector.Name = "txtMovieDirector";
            txtMovieDirector.Size = new Size(304, 31);
            txtMovieDirector.TabIndex = 9;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddMovie.Location = new Point(159, 383);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(112, 61);
            btnAddMovie.TabIndex = 10;
            btnAddMovie.Text = "Add Movie";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // btnUpdateMovie
            // 
            btnUpdateMovie.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdateMovie.Location = new Point(277, 383);
            btnUpdateMovie.Name = "btnUpdateMovie";
            btnUpdateMovie.Size = new Size(112, 61);
            btnUpdateMovie.TabIndex = 11;
            btnUpdateMovie.Text = "Update Movie";
            btnUpdateMovie.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeleteMovie.Location = new Point(395, 383);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(112, 61);
            btnDeleteMovie.TabIndex = 12;
            btnDeleteMovie.Text = "Delete Movie";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            btnDeleteMovie.Click += btnDeleteMovie_Click_1;
            // 
            // btnSaveMovies
            // 
            btnSaveMovies.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSaveMovies.Location = new Point(591, 392);
            btnSaveMovies.Name = "btnSaveMovies";
            btnSaveMovies.Size = new Size(112, 61);
            btnSaveMovies.TabIndex = 13;
            btnSaveMovies.Text = "SAVE";
            btnSaveMovies.UseVisualStyleBackColor = true;
            // 
            // btnLoadMovies
            // 
            btnLoadMovies.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLoadMovies.Location = new Point(686, 328);
            btnLoadMovies.Name = "btnLoadMovies";
            btnLoadMovies.Size = new Size(112, 34);
            btnLoadMovies.TabIndex = 14;
            btnLoadMovies.Text = "LOAD ALL";
            btnLoadMovies.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(177, 9);
            label6.Name = "label6";
            label6.Size = new Size(450, 32);
            label6.TabIndex = 15;
            label6.Text = "MOVIE MANAGEMENT SYSTEM";
            // 
            // btnViewAllMovies
            // 
            btnViewAllMovies.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnViewAllMovies.Location = new Point(515, 328);
            btnViewAllMovies.Name = "btnViewAllMovies";
            btnViewAllMovies.Size = new Size(112, 34);
            btnViewAllMovies.TabIndex = 16;
            btnViewAllMovies.Text = "View All";
            btnViewAllMovies.UseVisualStyleBackColor = true;
            // 
            // MOVIES
            // 
            MOVIES.FormattingEnabled = true;
            MOVIES.ItemHeight = 25;
            MOVIES.Location = new Point(511, 48);
            MOVIES.Name = "MOVIES";
            MOVIES.Size = new Size(277, 254);
            MOVIES.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(838, 456);
            Controls.Add(MOVIES);
            Controls.Add(btnViewAllMovies);
            Controls.Add(label6);
            Controls.Add(btnLoadMovies);
            Controls.Add(btnSaveMovies);
            Controls.Add(btnDeleteMovie);
            Controls.Add(btnUpdateMovie);
            Controls.Add(btnAddMovie);
            Controls.Add(txtMovieDirector);
            Controls.Add(txtMovieTitle);
            Controls.Add(txtMovieID);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtMovieID;
        private TextBox txtMovieTitle;
        private TextBox txtMovieDirector;
        private Button btnAddMovie;
        private Button btnUpdateMovie;
        private Button btnDeleteMovie;
        private Button btnSaveMovies;
        private Button btnLoadMovies;
        private Label label6;
        private Button btnViewAllMovies;
        private ListBox MOVIES;
    }
}
