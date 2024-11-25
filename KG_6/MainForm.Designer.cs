namespace KG_6
{
    partial class MainForm
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
            this.uploadFile_button = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_saltAndPaper_noise = new System.Windows.Forms.Button();
            this.button_lines_noise = new System.Windows.Forms.Button();
            this.button_circles_noise = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Gauss_filter = new System.Windows.Forms.Button();
            this.comboBox_sigma = new System.Windows.Forms.ComboBox();
            this.comboBox_Gauss_n = new System.Windows.Forms.ComboBox();
            this.comboBox_noise_chance = new System.Windows.Forms.ComboBox();
            this.numericUpDown_number_of_lines = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_number_of_circles = new System.Windows.Forms.NumericUpDown();
            this.button_linear_filter = new System.Windows.Forms.Button();
            this.comboBox_linear_n = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_linear_m = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_sharpen = new System.Windows.Forms.Button();
            this.numericUpDown_sharpen_k = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_sharpen_n = new System.Windows.Forms.NumericUpDown();
            this.button_glass = new System.Windows.Forms.Button();
            this.numericUpDown_glass_strength = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_lines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_circles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sharpen_k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sharpen_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_glass_strength)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadFile_button
            // 
            this.uploadFile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadFile_button.BackColor = System.Drawing.Color.DarkOrange;
            this.uploadFile_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uploadFile_button.ForeColor = System.Drawing.Color.Navy;
            this.uploadFile_button.Location = new System.Drawing.Point(889, 12);
            this.uploadFile_button.Name = "uploadFile_button";
            this.uploadFile_button.Size = new System.Drawing.Size(143, 65);
            this.uploadFile_button.TabIndex = 1;
            this.uploadFile_button.Text = "Загрузить файл";
            this.uploadFile_button.UseVisualStyleBackColor = false;
            this.uploadFile_button.Click += new System.EventHandler(this.uploadFile_button_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Reset.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Reset.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Reset.ForeColor = System.Drawing.Color.Navy;
            this.button_Reset.Location = new System.Drawing.Point(1038, 12);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(123, 65);
            this.button_Reset.TabIndex = 14;
            this.button_Reset.Text = "Сброс";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_image.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(849, 737);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image.TabIndex = 15;
            this.pictureBox_image.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(907, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Искусственное наложение шума";
            // 
            // button_saltAndPaper_noise
            // 
            this.button_saltAndPaper_noise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_saltAndPaper_noise.BackColor = System.Drawing.Color.DarkOrange;
            this.button_saltAndPaper_noise.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_saltAndPaper_noise.ForeColor = System.Drawing.Color.Navy;
            this.button_saltAndPaper_noise.Location = new System.Drawing.Point(865, 106);
            this.button_saltAndPaper_noise.Name = "button_saltAndPaper_noise";
            this.button_saltAndPaper_noise.Size = new System.Drawing.Size(75, 46);
            this.button_saltAndPaper_noise.TabIndex = 21;
            this.button_saltAndPaper_noise.Text = "Точки";
            this.button_saltAndPaper_noise.UseVisualStyleBackColor = false;
            this.button_saltAndPaper_noise.Click += new System.EventHandler(this.button_saltAndPaper_noise_Click);
            // 
            // button_lines_noise
            // 
            this.button_lines_noise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_lines_noise.BackColor = System.Drawing.Color.DarkOrange;
            this.button_lines_noise.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_lines_noise.ForeColor = System.Drawing.Color.Navy;
            this.button_lines_noise.Location = new System.Drawing.Point(946, 106);
            this.button_lines_noise.Name = "button_lines_noise";
            this.button_lines_noise.Size = new System.Drawing.Size(84, 46);
            this.button_lines_noise.TabIndex = 22;
            this.button_lines_noise.Text = "Линии";
            this.button_lines_noise.UseVisualStyleBackColor = false;
            this.button_lines_noise.Click += new System.EventHandler(this.button_lines_noise_Click);
            // 
            // button_circles_noise
            // 
            this.button_circles_noise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_circles_noise.BackColor = System.Drawing.Color.DarkOrange;
            this.button_circles_noise.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_circles_noise.ForeColor = System.Drawing.Color.Navy;
            this.button_circles_noise.Location = new System.Drawing.Point(1036, 106);
            this.button_circles_noise.Name = "button_circles_noise";
            this.button_circles_noise.Size = new System.Drawing.Size(136, 46);
            this.button_circles_noise.TabIndex = 23;
            this.button_circles_noise.Text = "Окружности";
            this.button_circles_noise.UseVisualStyleBackColor = false;
            this.button_circles_noise.Click += new System.EventHandler(this.button_circles_noise_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(879, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 40;
            this.label2.Text = "sigma:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(919, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 27);
            this.label3.TabIndex = 39;
            this.label3.Text = "n:";
            // 
            // button_Gauss_filter
            // 
            this.button_Gauss_filter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_Gauss_filter.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Gauss_filter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Gauss_filter.ForeColor = System.Drawing.Color.Navy;
            this.button_Gauss_filter.Location = new System.Drawing.Point(1029, 328);
            this.button_Gauss_filter.Name = "button_Gauss_filter";
            this.button_Gauss_filter.Size = new System.Drawing.Size(143, 74);
            this.button_Gauss_filter.TabIndex = 34;
            this.button_Gauss_filter.Text = "Фильтр Гаусса";
            this.button_Gauss_filter.UseVisualStyleBackColor = false;
            this.button_Gauss_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // comboBox_sigma
            // 
            this.comboBox_sigma.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_sigma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sigma.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_sigma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox_sigma.FormattingEnabled = true;
            this.comboBox_sigma.Items.AddRange(new object[] {
            "0,5",
            "0,6",
            "0,7",
            "0,8",
            "0,9",
            "1,0",
            "1,1",
            "1,2",
            "1,3",
            "1,4",
            "1,5",
            "1,6",
            "1,7",
            "1,8",
            "1,9",
            "2,0"});
            this.comboBox_sigma.Location = new System.Drawing.Point(955, 371);
            this.comboBox_sigma.Name = "comboBox_sigma";
            this.comboBox_sigma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_sigma.Size = new System.Drawing.Size(68, 31);
            this.comboBox_sigma.TabIndex = 43;
            // 
            // comboBox_Gauss_n
            // 
            this.comboBox_Gauss_n.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_Gauss_n.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Gauss_n.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Gauss_n.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox_Gauss_n.FormattingEnabled = true;
            this.comboBox_Gauss_n.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.comboBox_Gauss_n.Location = new System.Drawing.Point(955, 328);
            this.comboBox_Gauss_n.Name = "comboBox_Gauss_n";
            this.comboBox_Gauss_n.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Gauss_n.Size = new System.Drawing.Size(68, 31);
            this.comboBox_Gauss_n.TabIndex = 44;
            // 
            // comboBox_noise_chance
            // 
            this.comboBox_noise_chance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_noise_chance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_noise_chance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_noise_chance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox_noise_chance.FormattingEnabled = true;
            this.comboBox_noise_chance.Items.AddRange(new object[] {
            "0,01",
            "0,02",
            "0,03",
            "0,04",
            "0,05",
            "0,06",
            "0,07",
            "0,08",
            "0,09",
            "0,1"});
            this.comboBox_noise_chance.Location = new System.Drawing.Point(865, 158);
            this.comboBox_noise_chance.Name = "comboBox_noise_chance";
            this.comboBox_noise_chance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_noise_chance.Size = new System.Drawing.Size(75, 31);
            this.comboBox_noise_chance.TabIndex = 45;
            // 
            // numericUpDown_number_of_lines
            // 
            this.numericUpDown_number_of_lines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_number_of_lines.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_number_of_lines.Location = new System.Drawing.Point(946, 158);
            this.numericUpDown_number_of_lines.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_number_of_lines.Name = "numericUpDown_number_of_lines";
            this.numericUpDown_number_of_lines.Size = new System.Drawing.Size(84, 30);
            this.numericUpDown_number_of_lines.TabIndex = 46;
            this.numericUpDown_number_of_lines.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_number_of_circles
            // 
            this.numericUpDown_number_of_circles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_number_of_circles.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_number_of_circles.Location = new System.Drawing.Point(1036, 158);
            this.numericUpDown_number_of_circles.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_number_of_circles.Name = "numericUpDown_number_of_circles";
            this.numericUpDown_number_of_circles.Size = new System.Drawing.Size(134, 30);
            this.numericUpDown_number_of_circles.TabIndex = 47;
            this.numericUpDown_number_of_circles.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button_linear_filter
            // 
            this.button_linear_filter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_linear_filter.BackColor = System.Drawing.Color.DarkOrange;
            this.button_linear_filter.Font = new System.Drawing.Font("Comic Sans MS", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_linear_filter.ForeColor = System.Drawing.Color.Navy;
            this.button_linear_filter.Location = new System.Drawing.Point(1029, 232);
            this.button_linear_filter.Name = "button_linear_filter";
            this.button_linear_filter.Size = new System.Drawing.Size(143, 74);
            this.button_linear_filter.TabIndex = 48;
            this.button_linear_filter.Text = "Равномерный фильтр";
            this.button_linear_filter.UseVisualStyleBackColor = false;
            this.button_linear_filter.Click += new System.EventHandler(this.button_linear_filter_Click);
            // 
            // comboBox_linear_n
            // 
            this.comboBox_linear_n.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_linear_n.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_linear_n.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_linear_n.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox_linear_n.FormattingEnabled = true;
            this.comboBox_linear_n.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9"});
            this.comboBox_linear_n.Location = new System.Drawing.Point(955, 232);
            this.comboBox_linear_n.Name = "comboBox_linear_n";
            this.comboBox_linear_n.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_linear_n.Size = new System.Drawing.Size(68, 31);
            this.comboBox_linear_n.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(919, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 27);
            this.label4.TabIndex = 49;
            this.label4.Text = "n:";
            // 
            // comboBox_linear_m
            // 
            this.comboBox_linear_m.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_linear_m.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_linear_m.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_linear_m.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox_linear_m.FormattingEnabled = true;
            this.comboBox_linear_m.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9"});
            this.comboBox_linear_m.Location = new System.Drawing.Point(955, 275);
            this.comboBox_linear_m.Name = "comboBox_linear_m";
            this.comboBox_linear_m.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_linear_m.Size = new System.Drawing.Size(68, 31);
            this.comboBox_linear_m.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(914, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 27);
            this.label5.TabIndex = 51;
            this.label5.Text = "m:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(1068, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 27);
            this.label6.TabIndex = 56;
            this.label6.Text = "k:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(928, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 27);
            this.label7.TabIndex = 54;
            this.label7.Text = "n:";
            // 
            // button_sharpen
            // 
            this.button_sharpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sharpen.BackColor = System.Drawing.Color.DarkOrange;
            this.button_sharpen.Font = new System.Drawing.Font("Comic Sans MS", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sharpen.ForeColor = System.Drawing.Color.Navy;
            this.button_sharpen.Location = new System.Drawing.Point(867, 505);
            this.button_sharpen.Name = "button_sharpen";
            this.button_sharpen.Size = new System.Drawing.Size(305, 39);
            this.button_sharpen.TabIndex = 53;
            this.button_sharpen.Text = "Фильтр повышения резкости";
            this.button_sharpen.UseVisualStyleBackColor = false;
            this.button_sharpen.Click += new System.EventHandler(this.button_sharpen_Click);
            // 
            // numericUpDown_sharpen_k
            // 
            this.numericUpDown_sharpen_k.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_sharpen_k.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_sharpen_k.Location = new System.Drawing.Point(1102, 472);
            this.numericUpDown_sharpen_k.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_sharpen_k.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_sharpen_k.Name = "numericUpDown_sharpen_k";
            this.numericUpDown_sharpen_k.Size = new System.Drawing.Size(68, 30);
            this.numericUpDown_sharpen_k.TabIndex = 57;
            this.numericUpDown_sharpen_k.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown_sharpen_n
            // 
            this.numericUpDown_sharpen_n.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_sharpen_n.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_sharpen_n.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_sharpen_n.Location = new System.Drawing.Point(964, 472);
            this.numericUpDown_sharpen_n.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown_sharpen_n.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_sharpen_n.Name = "numericUpDown_sharpen_n";
            this.numericUpDown_sharpen_n.Size = new System.Drawing.Size(68, 30);
            this.numericUpDown_sharpen_n.TabIndex = 58;
            this.numericUpDown_sharpen_n.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_sharpen_n.ValueChanged += new System.EventHandler(this.numericUpDown_sharpen_n_ValueChanged);
            // 
            // button_glass
            // 
            this.button_glass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_glass.BackColor = System.Drawing.Color.DarkOrange;
            this.button_glass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_glass.ForeColor = System.Drawing.Color.Navy;
            this.button_glass.Location = new System.Drawing.Point(1029, 675);
            this.button_glass.Name = "button_glass";
            this.button_glass.Size = new System.Drawing.Size(145, 74);
            this.button_glass.TabIndex = 59;
            this.button_glass.Text = "Спецэффект \"Стекло\"";
            this.button_glass.UseVisualStyleBackColor = false;
            this.button_glass.Click += new System.EventHandler(this.button_glass_Click);
            // 
            // numericUpDown_glass_strength
            // 
            this.numericUpDown_glass_strength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_glass_strength.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_glass_strength.Location = new System.Drawing.Point(955, 719);
            this.numericUpDown_glass_strength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_glass_strength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_glass_strength.Name = "numericUpDown_glass_strength";
            this.numericUpDown_glass_strength.Size = new System.Drawing.Size(68, 30);
            this.numericUpDown_glass_strength.TabIndex = 60;
            this.numericUpDown_glass_strength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(867, 689);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 27);
            this.label8.TabIndex = 61;
            this.label8.Text = "Сила эффекта:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_glass_strength);
            this.Controls.Add(this.button_glass);
            this.Controls.Add(this.numericUpDown_sharpen_n);
            this.Controls.Add(this.numericUpDown_sharpen_k);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_sharpen);
            this.Controls.Add(this.comboBox_linear_m);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_linear_n);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_linear_filter);
            this.Controls.Add(this.numericUpDown_number_of_circles);
            this.Controls.Add(this.numericUpDown_number_of_lines);
            this.Controls.Add(this.comboBox_noise_chance);
            this.Controls.Add(this.comboBox_Gauss_n);
            this.Controls.Add(this.comboBox_sigma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Gauss_filter);
            this.Controls.Add(this.button_circles_noise);
            this.Controls.Add(this.button_lines_noise);
            this.Controls.Add(this.button_saltAndPaper_noise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.uploadFile_button);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_lines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number_of_circles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sharpen_k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sharpen_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_glass_strength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadFile_button;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_saltAndPaper_noise;
        private System.Windows.Forms.Button button_lines_noise;
        private System.Windows.Forms.Button button_circles_noise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Gauss_filter;
        private System.Windows.Forms.ComboBox comboBox_sigma;
        private System.Windows.Forms.ComboBox comboBox_Gauss_n;
        private System.Windows.Forms.ComboBox comboBox_noise_chance;
        private System.Windows.Forms.NumericUpDown numericUpDown_number_of_lines;
        private System.Windows.Forms.NumericUpDown numericUpDown_number_of_circles;
        private System.Windows.Forms.Button button_linear_filter;
        private System.Windows.Forms.ComboBox comboBox_linear_n;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_linear_m;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_sharpen;
        private System.Windows.Forms.NumericUpDown numericUpDown_sharpen_k;
        private System.Windows.Forms.NumericUpDown numericUpDown_sharpen_n;
        private System.Windows.Forms.Button button_glass;
        private System.Windows.Forms.NumericUpDown numericUpDown_glass_strength;
        private System.Windows.Forms.Label label8;
    }
}