namespace cnc_deneme
{
    partial class cnc_control_screen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.speed_100_label = new System.Windows.Forms.Label();
            this.speed_50_label = new System.Windows.Forms.Label();
            this.speed_0_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setting_save_button = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Panel();
            this.speed_setting = new System.Windows.Forms.TrackBar();
            this.speed_label = new System.Windows.Forms.Label();
            this.baud_rate_label = new System.Windows.Forms.Label();
            this.baud_rate_select = new System.Windows.Forms.ComboBox();
            this.connect_button = new System.Windows.Forms.Label();
            this.com_port_number_select = new System.Windows.Forms.ComboBox();
            this.com_port_number_label = new System.Windows.Forms.Label();
            this.z_axis_max_label = new System.Windows.Forms.Label();
            this.z_axis_max = new System.Windows.Forms.TextBox();
            this.z_axis_min_label = new System.Windows.Forms.Label();
            this.z_axis_min = new System.Windows.Forms.TextBox();
            this.degrees_for_z_axis_label = new System.Windows.Forms.Label();
            this.y_step_mm_label = new System.Windows.Forms.Label();
            this.y_step_mm = new System.Windows.Forms.TextBox();
            this.x_step_mm_label = new System.Windows.Forms.Label();
            this.x_step_mm = new System.Windows.Forms.TextBox();
            this.step_mm_for_x_y_axis_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.step_size_select = new System.Windows.Forms.ComboBox();
            this.step_size_label = new System.Windows.Forms.Label();
            this.z_axis_down = new System.Windows.Forms.Label();
            this.z_axis_up = new System.Windows.Forms.Label();
            this.x_axis_right = new System.Windows.Forms.Label();
            this.x_axis_left = new System.Windows.Forms.Label();
            this.y_axis_fwd = new System.Windows.Forms.Label();
            this.y_axis_rev = new System.Windows.Forms.Label();
            this.y_coordinates = new System.Windows.Forms.Label();
            this.y_coordinates_label = new System.Windows.Forms.Label();
            this.x_coordinates = new System.Windows.Forms.Label();
            this.x_coordinates_label = new System.Windows.Forms.Label();
            this.coordinates_label = new System.Windows.Forms.Label();
            this.kare_kenar_uzunluk = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_setting)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.kare_kenar_uzunluk);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 726);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.speed_100_label);
            this.panel2.Controls.Add(this.speed_50_label);
            this.panel2.Controls.Add(this.speed_0_label);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.setting_save_button);
            this.panel2.Controls.Add(this.reset_button);
            this.panel2.Controls.Add(this.speed_setting);
            this.panel2.Controls.Add(this.speed_label);
            this.panel2.Controls.Add(this.baud_rate_label);
            this.panel2.Controls.Add(this.baud_rate_select);
            this.panel2.Controls.Add(this.connect_button);
            this.panel2.Controls.Add(this.com_port_number_select);
            this.panel2.Controls.Add(this.com_port_number_label);
            this.panel2.Controls.Add(this.z_axis_max_label);
            this.panel2.Controls.Add(this.z_axis_max);
            this.panel2.Controls.Add(this.z_axis_min_label);
            this.panel2.Controls.Add(this.z_axis_min);
            this.panel2.Controls.Add(this.degrees_for_z_axis_label);
            this.panel2.Controls.Add(this.y_step_mm_label);
            this.panel2.Controls.Add(this.y_step_mm);
            this.panel2.Controls.Add(this.x_step_mm_label);
            this.panel2.Controls.Add(this.x_step_mm);
            this.panel2.Controls.Add(this.step_mm_for_x_y_axis_label);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.y_coordinates);
            this.panel2.Controls.Add(this.y_coordinates_label);
            this.panel2.Controls.Add(this.x_coordinates);
            this.panel2.Controls.Add(this.x_coordinates_label);
            this.panel2.Controls.Add(this.coordinates_label);
            this.panel2.Location = new System.Drawing.Point(750, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 726);
            this.panel2.TabIndex = 1;
            // 
            // speed_100_label
            // 
            this.speed_100_label.BackColor = System.Drawing.Color.Transparent;
            this.speed_100_label.Location = new System.Drawing.Point(203, 218);
            this.speed_100_label.Name = "speed_100_label";
            this.speed_100_label.Size = new System.Drawing.Size(25, 15);
            this.speed_100_label.TabIndex = 27;
            this.speed_100_label.Text = "100";
            // 
            // speed_50_label
            // 
            this.speed_50_label.BackColor = System.Drawing.Color.Transparent;
            this.speed_50_label.Location = new System.Drawing.Point(111, 218);
            this.speed_50_label.Name = "speed_50_label";
            this.speed_50_label.Size = new System.Drawing.Size(20, 15);
            this.speed_50_label.TabIndex = 26;
            this.speed_50_label.Text = "50";
            // 
            // speed_0_label
            // 
            this.speed_0_label.BackColor = System.Drawing.Color.Transparent;
            this.speed_0_label.Location = new System.Drawing.Point(16, 218);
            this.speed_0_label.Name = "speed_0_label";
            this.speed_0_label.Size = new System.Drawing.Size(13, 14);
            this.speed_0_label.TabIndex = 25;
            this.speed_0_label.Text = "0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 5);
            this.label2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 5);
            this.label1.TabIndex = 23;
            // 
            // setting_save_button
            // 
            this.setting_save_button.BackColor = System.Drawing.Color.Transparent;
            this.setting_save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.setting_save_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.setting_save_button.Image = global::cnc_deneme.Properties.Resources.button;
            this.setting_save_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.setting_save_button.Location = new System.Drawing.Point(15, 344);
            this.setting_save_button.Name = "setting_save_button";
            this.setting_save_button.Size = new System.Drawing.Size(207, 68);
            this.setting_save_button.TabIndex = 22;
            this.setting_save_button.Text = "SETTING SAVE";
            this.setting_save_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.setting_save_button.Click += new System.EventHandler(this.setting_save_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackgroundImage = global::cnc_deneme.Properties.Resources.reset_button;
            this.reset_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reset_button.Location = new System.Drawing.Point(159, 455);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(70, 40);
            this.reset_button.TabIndex = 21;
            this.reset_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reset_button_MouseClick);
            // 
            // speed_setting
            // 
            this.speed_setting.Location = new System.Drawing.Point(9, 189);
            this.speed_setting.Maximum = 100;
            this.speed_setting.Name = "speed_setting";
            this.speed_setting.Size = new System.Drawing.Size(220, 45);
            this.speed_setting.TabIndex = 0;
            this.speed_setting.Value = 50;
            // 
            // speed_label
            // 
            this.speed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.speed_label.Location = new System.Drawing.Point(9, 161);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(220, 25);
            this.speed_label.TabIndex = 20;
            this.speed_label.Text = "Speed";
            this.speed_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speed_label.Click += new System.EventHandler(this.speed_label_Click);
            // 
            // baud_rate_label
            // 
            this.baud_rate_label.BackColor = System.Drawing.Color.Transparent;
            this.baud_rate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baud_rate_label.ForeColor = System.Drawing.Color.Black;
            this.baud_rate_label.Location = new System.Drawing.Point(4, 49);
            this.baud_rate_label.Name = "baud_rate_label";
            this.baud_rate_label.Size = new System.Drawing.Size(125, 20);
            this.baud_rate_label.TabIndex = 19;
            this.baud_rate_label.Text = "Baud Rate";
            this.baud_rate_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baud_rate_select
            // 
            this.baud_rate_select.BackColor = System.Drawing.Color.Gray;
            this.baud_rate_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.baud_rate_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baud_rate_select.FormattingEnabled = true;
            this.baud_rate_select.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200"});
            this.baud_rate_select.Location = new System.Drawing.Point(131, 45);
            this.baud_rate_select.Name = "baud_rate_select";
            this.baud_rate_select.Size = new System.Drawing.Size(100, 28);
            this.baud_rate_select.TabIndex = 18;
            this.baud_rate_select.Text = "9600";
            // 
            // connect_button
            // 
            this.connect_button.BackColor = System.Drawing.Color.Transparent;
            this.connect_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connect_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.connect_button.Image = global::cnc_deneme.Properties.Resources.button;
            this.connect_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.connect_button.Location = new System.Drawing.Point(15, 75);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(207, 68);
            this.connect_button.TabIndex = 17;
            this.connect_button.Text = "CONNECT";
            this.connect_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // com_port_number_select
            // 
            this.com_port_number_select.BackColor = System.Drawing.Color.Gray;
            this.com_port_number_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_port_number_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.com_port_number_select.FormattingEnabled = true;
            this.com_port_number_select.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.com_port_number_select.Location = new System.Drawing.Point(156, 9);
            this.com_port_number_select.Name = "com_port_number_select";
            this.com_port_number_select.Size = new System.Drawing.Size(75, 28);
            this.com_port_number_select.TabIndex = 8;
            this.com_port_number_select.Text = "3";
            // 
            // com_port_number_label
            // 
            this.com_port_number_label.BackColor = System.Drawing.Color.Transparent;
            this.com_port_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.com_port_number_label.ForeColor = System.Drawing.Color.Black;
            this.com_port_number_label.Location = new System.Drawing.Point(4, 13);
            this.com_port_number_label.Name = "com_port_number_label";
            this.com_port_number_label.Size = new System.Drawing.Size(150, 20);
            this.com_port_number_label.TabIndex = 16;
            this.com_port_number_label.Text = "Com Port Number";
            this.com_port_number_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // z_axis_max_label
            // 
            this.z_axis_max_label.BackColor = System.Drawing.Color.Transparent;
            this.z_axis_max_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.z_axis_max_label.ForeColor = System.Drawing.Color.Black;
            this.z_axis_max_label.Location = new System.Drawing.Point(122, 264);
            this.z_axis_max_label.Name = "z_axis_max_label";
            this.z_axis_max_label.Size = new System.Drawing.Size(50, 20);
            this.z_axis_max_label.TabIndex = 15;
            this.z_axis_max_label.Text = "Max";
            this.z_axis_max_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // z_axis_max
            // 
            this.z_axis_max.BackColor = System.Drawing.Color.Gray;
            this.z_axis_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.z_axis_max.Location = new System.Drawing.Point(173, 261);
            this.z_axis_max.Name = "z_axis_max";
            this.z_axis_max.Size = new System.Drawing.Size(55, 26);
            this.z_axis_max.TabIndex = 14;
            this.z_axis_max.Text = "70";
            this.z_axis_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.z_axis_max.TextChanged += new System.EventHandler(this.z_axis_max_TextChanged);
            // 
            // z_axis_min_label
            // 
            this.z_axis_min_label.BackColor = System.Drawing.Color.Transparent;
            this.z_axis_min_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.z_axis_min_label.ForeColor = System.Drawing.Color.Black;
            this.z_axis_min_label.Location = new System.Drawing.Point(9, 264);
            this.z_axis_min_label.Name = "z_axis_min_label";
            this.z_axis_min_label.Size = new System.Drawing.Size(50, 20);
            this.z_axis_min_label.TabIndex = 13;
            this.z_axis_min_label.Text = "Min";
            this.z_axis_min_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // z_axis_min
            // 
            this.z_axis_min.BackColor = System.Drawing.Color.Gray;
            this.z_axis_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.z_axis_min.Location = new System.Drawing.Point(60, 261);
            this.z_axis_min.Name = "z_axis_min";
            this.z_axis_min.Size = new System.Drawing.Size(55, 26);
            this.z_axis_min.TabIndex = 12;
            this.z_axis_min.Text = "95";
            this.z_axis_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // degrees_for_z_axis_label
            // 
            this.degrees_for_z_axis_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degrees_for_z_axis_label.Location = new System.Drawing.Point(5, 234);
            this.degrees_for_z_axis_label.Name = "degrees_for_z_axis_label";
            this.degrees_for_z_axis_label.Size = new System.Drawing.Size(228, 25);
            this.degrees_for_z_axis_label.TabIndex = 11;
            this.degrees_for_z_axis_label.Text = "Degrees for Z Axis";
            this.degrees_for_z_axis_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // y_step_mm_label
            // 
            this.y_step_mm_label.BackColor = System.Drawing.Color.Transparent;
            this.y_step_mm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y_step_mm_label.ForeColor = System.Drawing.Color.Black;
            this.y_step_mm_label.Location = new System.Drawing.Point(122, 318);
            this.y_step_mm_label.Name = "y_step_mm_label";
            this.y_step_mm_label.Size = new System.Drawing.Size(30, 20);
            this.y_step_mm_label.TabIndex = 10;
            this.y_step_mm_label.Text = "Y";
            this.y_step_mm_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // y_step_mm
            // 
            this.y_step_mm.BackColor = System.Drawing.Color.Gray;
            this.y_step_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y_step_mm.Location = new System.Drawing.Point(153, 315);
            this.y_step_mm.Name = "y_step_mm";
            this.y_step_mm.Size = new System.Drawing.Size(75, 26);
            this.y_step_mm.TabIndex = 9;
            this.y_step_mm.Text = "40";
            this.y_step_mm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // x_step_mm_label
            // 
            this.x_step_mm_label.BackColor = System.Drawing.Color.Transparent;
            this.x_step_mm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.x_step_mm_label.ForeColor = System.Drawing.Color.Black;
            this.x_step_mm_label.Location = new System.Drawing.Point(9, 318);
            this.x_step_mm_label.Name = "x_step_mm_label";
            this.x_step_mm_label.Size = new System.Drawing.Size(30, 20);
            this.x_step_mm_label.TabIndex = 8;
            this.x_step_mm_label.Text = "X";
            this.x_step_mm_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x_step_mm
            // 
            this.x_step_mm.BackColor = System.Drawing.Color.Gray;
            this.x_step_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.x_step_mm.Location = new System.Drawing.Point(40, 315);
            this.x_step_mm.Name = "x_step_mm";
            this.x_step_mm.Size = new System.Drawing.Size(75, 26);
            this.x_step_mm.TabIndex = 7;
            this.x_step_mm.Text = "40";
            this.x_step_mm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // step_mm_for_x_y_axis_label
            // 
            this.step_mm_for_x_y_axis_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.step_mm_for_x_y_axis_label.Location = new System.Drawing.Point(5, 288);
            this.step_mm_for_x_y_axis_label.Name = "step_mm_for_x_y_axis_label";
            this.step_mm_for_x_y_axis_label.Size = new System.Drawing.Size(228, 25);
            this.step_mm_for_x_y_axis_label.TabIndex = 6;
            this.step_mm_for_x_y_axis_label.Text = "Step/mm for X-Y Axis";
            this.step_mm_for_x_y_axis_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::cnc_deneme.Properties.Resources.tus_takimi;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.step_size_select);
            this.panel3.Controls.Add(this.step_size_label);
            this.panel3.Controls.Add(this.z_axis_down);
            this.panel3.Controls.Add(this.z_axis_up);
            this.panel3.Controls.Add(this.x_axis_right);
            this.panel3.Controls.Add(this.x_axis_left);
            this.panel3.Controls.Add(this.y_axis_fwd);
            this.panel3.Controls.Add(this.y_axis_rev);
            this.panel3.Location = new System.Drawing.Point(9, 497);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 220);
            this.panel3.TabIndex = 5;
            // 
            // step_size_select
            // 
            this.step_size_select.BackColor = System.Drawing.Color.Gray;
            this.step_size_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.step_size_select.FormattingEnabled = true;
            this.step_size_select.Items.AddRange(new object[] {
            "00001",
            "00010",
            "00100",
            "01000"});
            this.step_size_select.Location = new System.Drawing.Point(80, 107);
            this.step_size_select.Name = "step_size_select";
            this.step_size_select.Size = new System.Drawing.Size(60, 21);
            this.step_size_select.TabIndex = 7;
            this.step_size_select.Text = "00001";
            this.step_size_select.SelectedIndexChanged += new System.EventHandler(this.step_size_select_SelectedIndexChanged);
            // 
            // step_size_label
            // 
            this.step_size_label.BackColor = System.Drawing.Color.Transparent;
            this.step_size_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.step_size_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.step_size_label.Location = new System.Drawing.Point(75, 86);
            this.step_size_label.Name = "step_size_label";
            this.step_size_label.Size = new System.Drawing.Size(70, 20);
            this.step_size_label.TabIndex = 6;
            this.step_size_label.Text = "Step Size";
            this.step_size_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // z_axis_down
            // 
            this.z_axis_down.BackColor = System.Drawing.Color.Transparent;
            this.z_axis_down.Location = new System.Drawing.Point(26, 154);
            this.z_axis_down.Name = "z_axis_down";
            this.z_axis_down.Size = new System.Drawing.Size(40, 40);
            this.z_axis_down.TabIndex = 5;
            this.z_axis_down.Click += new System.EventHandler(this.z_axis_down_Click);
            // 
            // z_axis_up
            // 
            this.z_axis_up.BackColor = System.Drawing.Color.Transparent;
            this.z_axis_up.Location = new System.Drawing.Point(154, 25);
            this.z_axis_up.Name = "z_axis_up";
            this.z_axis_up.Size = new System.Drawing.Size(40, 40);
            this.z_axis_up.TabIndex = 4;
            this.z_axis_up.Click += new System.EventHandler(this.z_axis_up_Click);
            // 
            // x_axis_right
            // 
            this.x_axis_right.BackColor = System.Drawing.Color.Transparent;
            this.x_axis_right.Location = new System.Drawing.Point(145, 90);
            this.x_axis_right.Name = "x_axis_right";
            this.x_axis_right.Size = new System.Drawing.Size(55, 40);
            this.x_axis_right.TabIndex = 3;
            this.x_axis_right.Click += new System.EventHandler(this.x_axis_right_Click);
            // 
            // x_axis_left
            // 
            this.x_axis_left.BackColor = System.Drawing.Color.Transparent;
            this.x_axis_left.Location = new System.Drawing.Point(20, 90);
            this.x_axis_left.Name = "x_axis_left";
            this.x_axis_left.Size = new System.Drawing.Size(55, 40);
            this.x_axis_left.TabIndex = 2;
            this.x_axis_left.Click += new System.EventHandler(this.x_axis_left_Click);
            // 
            // y_axis_fwd
            // 
            this.y_axis_fwd.BackColor = System.Drawing.Color.Transparent;
            this.y_axis_fwd.Location = new System.Drawing.Point(89, 144);
            this.y_axis_fwd.Name = "y_axis_fwd";
            this.y_axis_fwd.Size = new System.Drawing.Size(40, 55);
            this.y_axis_fwd.TabIndex = 1;
            this.y_axis_fwd.Click += new System.EventHandler(this.y_axis_fwd_Click);
            // 
            // y_axis_rev
            // 
            this.y_axis_rev.BackColor = System.Drawing.Color.Transparent;
            this.y_axis_rev.Location = new System.Drawing.Point(90, 20);
            this.y_axis_rev.Name = "y_axis_rev";
            this.y_axis_rev.Size = new System.Drawing.Size(40, 55);
            this.y_axis_rev.TabIndex = 0;
            this.y_axis_rev.Click += new System.EventHandler(this.y_axis_rev_Click);
            // 
            // y_coordinates
            // 
            this.y_coordinates.BackColor = System.Drawing.Color.Transparent;
            this.y_coordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y_coordinates.ForeColor = System.Drawing.Color.Black;
            this.y_coordinates.Location = new System.Drawing.Point(102, 453);
            this.y_coordinates.Name = "y_coordinates";
            this.y_coordinates.Size = new System.Drawing.Size(50, 40);
            this.y_coordinates.TabIndex = 4;
            this.y_coordinates.Text = "00.0";
            this.y_coordinates.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // y_coordinates_label
            // 
            this.y_coordinates_label.BackColor = System.Drawing.Color.Transparent;
            this.y_coordinates_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y_coordinates_label.ForeColor = System.Drawing.Color.Black;
            this.y_coordinates_label.Location = new System.Drawing.Point(84, 453);
            this.y_coordinates_label.Name = "y_coordinates_label";
            this.y_coordinates_label.Size = new System.Drawing.Size(15, 40);
            this.y_coordinates_label.TabIndex = 3;
            this.y_coordinates_label.Text = "Y";
            this.y_coordinates_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x_coordinates
            // 
            this.x_coordinates.BackColor = System.Drawing.Color.Transparent;
            this.x_coordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.x_coordinates.ForeColor = System.Drawing.Color.Black;
            this.x_coordinates.Location = new System.Drawing.Point(31, 453);
            this.x_coordinates.Name = "x_coordinates";
            this.x_coordinates.Size = new System.Drawing.Size(50, 40);
            this.x_coordinates.TabIndex = 2;
            this.x_coordinates.Text = "00.0";
            this.x_coordinates.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // x_coordinates_label
            // 
            this.x_coordinates_label.BackColor = System.Drawing.Color.Transparent;
            this.x_coordinates_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.x_coordinates_label.ForeColor = System.Drawing.Color.Black;
            this.x_coordinates_label.Location = new System.Drawing.Point(13, 453);
            this.x_coordinates_label.Name = "x_coordinates_label";
            this.x_coordinates_label.Size = new System.Drawing.Size(15, 40);
            this.x_coordinates_label.TabIndex = 1;
            this.x_coordinates_label.Text = "X";
            this.x_coordinates_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coordinates_label
            // 
            this.coordinates_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coordinates_label.Location = new System.Drawing.Point(5, 429);
            this.coordinates_label.Name = "coordinates_label";
            this.coordinates_label.Size = new System.Drawing.Size(228, 25);
            this.coordinates_label.TabIndex = 0;
            this.coordinates_label.Text = "Coordinates";
            this.coordinates_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_kenar_uzunluk
            // 
            this.kare_kenar_uzunluk.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kare_kenar_uzunluk.FormattingEnabled = true;
            this.kare_kenar_uzunluk.Items.AddRange(new object[] {
            "00001",
            "00002",
            "00003",
            "00004",
            "00005",
            "00006",
            "00007",
            "00008",
            "00009",
            "00010",
            "00015",
            "00020",
            "00025",
            "00030",
            "00040",
            "00050",
            "00060",
            "00070",
            "00080",
            "00090",
            "00100"});
            this.kare_kenar_uzunluk.Location = new System.Drawing.Point(3, 50);
            this.kare_kenar_uzunluk.MaximumSize = new System.Drawing.Size(350, 0);
            this.kare_kenar_uzunluk.Name = "kare_kenar_uzunluk";
            this.kare_kenar_uzunluk.Size = new System.Drawing.Size(216, 21);
            this.kare_kenar_uzunluk.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cnc_deneme.Properties.Resources.button;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(3, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "KARE ÇİZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(3, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "KENAR UZUNLUĞU (mm)";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cnc_control_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cnc_control_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_setting)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label y_coordinates;
        private System.Windows.Forms.Label y_coordinates_label;
        private System.Windows.Forms.Label x_coordinates;
        private System.Windows.Forms.Label x_coordinates_label;
        private System.Windows.Forms.Label coordinates_label;
        private System.Windows.Forms.Label step_size_label;
        private System.Windows.Forms.Label z_axis_down;
        private System.Windows.Forms.Label z_axis_up;
        private System.Windows.Forms.Label x_axis_right;
        private System.Windows.Forms.Label x_axis_left;
        private System.Windows.Forms.Label y_axis_fwd;
        private System.Windows.Forms.Label y_axis_rev;
        private System.Windows.Forms.ComboBox step_size_select;
        private System.Windows.Forms.Label y_step_mm_label;
        private System.Windows.Forms.TextBox y_step_mm;
        private System.Windows.Forms.Label x_step_mm_label;
        private System.Windows.Forms.TextBox x_step_mm;
        private System.Windows.Forms.Label step_mm_for_x_y_axis_label;
        private System.Windows.Forms.ComboBox com_port_number_select;
        private System.Windows.Forms.Label com_port_number_label;
        private System.Windows.Forms.Label z_axis_max_label;
        private System.Windows.Forms.TextBox z_axis_max;
        private System.Windows.Forms.Label z_axis_min_label;
        private System.Windows.Forms.TextBox z_axis_min;
        private System.Windows.Forms.Label degrees_for_z_axis_label;
        private System.Windows.Forms.Label connect_button;
        private System.Windows.Forms.Label baud_rate_label;
        private System.Windows.Forms.ComboBox baud_rate_select;
        private System.Windows.Forms.TrackBar speed_setting;
        private System.Windows.Forms.Label speed_label;
        private System.Windows.Forms.Panel reset_button;
        private System.Windows.Forms.Label setting_save_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label speed_100_label;
        private System.Windows.Forms.Label speed_50_label;
        private System.Windows.Forms.Label speed_0_label;
        private System.Windows.Forms.ComboBox kare_kenar_uzunluk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

