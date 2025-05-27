namespace LabRay
{
    partial class UCChanneling
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCChanneling));
            this.DoctorsSDGV = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DoctorsCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Channel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TimeTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsSDGV)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoctorsSDGV
            // 
            this.DoctorsSDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsSDGV.GridColor = System.Drawing.Color.Purple;
            this.DoctorsSDGV.Location = new System.Drawing.Point(190, 325);
            this.DoctorsSDGV.Name = "DoctorsSDGV";
            this.DoctorsSDGV.RowHeadersWidth = 51;
            this.DoctorsSDGV.RowTemplate.Height = 24;
            this.DoctorsSDGV.Size = new System.Drawing.Size(602, 622);
            this.DoctorsSDGV.TabIndex = 0;
            this.DoctorsSDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Purple;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Purple;
            this.guna2GroupBox1.Controls.Add(this.dateTimePicker2);
            this.guna2GroupBox1.Controls.Add(this.DoctorsCb);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.Channel);
            this.guna2GroupBox1.Controls.Add(this.TimeTb);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Purple;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Thistle;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 972);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(982, 363);
            this.guna2GroupBox1.TabIndex = 5;
            this.guna2GroupBox1.Text = "Book an appointment";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(371, 146);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(404, 43);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // DoctorsCb
            // 
            this.DoctorsCb.FormattingEnabled = true;
            this.DoctorsCb.Location = new System.Drawing.Point(371, 75);
            this.DoctorsCb.Name = "DoctorsCb";
            this.DoctorsCb.Size = new System.Drawing.Size(404, 45);
            this.DoctorsCb.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter a time(hh:mm) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(107, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select a date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select a doctor :";
            // 
            // Channel
            // 
            this.Channel.BackColor = System.Drawing.Color.Thistle;
            this.Channel.BorderRadius = 20;
            this.Channel.CheckedState.Parent = this.Channel;
            this.Channel.CustomImages.Parent = this.Channel;
            this.Channel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Channel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Channel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Channel.ForeColor = System.Drawing.Color.White;
            this.Channel.HoverState.Parent = this.Channel;
            this.Channel.Location = new System.Drawing.Point(586, 293);
            this.Channel.Name = "Channel";
            this.Channel.ShadowDecoration.Parent = this.Channel;
            this.Channel.Size = new System.Drawing.Size(189, 57);
            this.Channel.TabIndex = 8;
            this.Channel.Text = "Channel";
            this.Channel.Click += new System.EventHandler(this.Channel_Click);
            // 
            // TimeTb
            // 
            this.TimeTb.BackColor = System.Drawing.Color.GhostWhite;
            this.TimeTb.BorderColorFocused = System.Drawing.Color.Purple;
            this.TimeTb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TimeTb.BorderColorMouseHover = System.Drawing.Color.Thistle;
            this.TimeTb.BorderThickness = 3;
            this.TimeTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TimeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TimeTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TimeTb.isPassword = false;
            this.TimeTb.Location = new System.Drawing.Point(371, 215);
            this.TimeTb.Margin = new System.Windows.Forms.Padding(4);
            this.TimeTb.MaxLength = 32767;
            this.TimeTb.Name = "TimeTb";
            this.TimeTb.Size = new System.Drawing.Size(404, 44);
            this.TimeTb.TabIndex = 7;
            this.TimeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(501, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-4, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 312);
            this.panel1.TabIndex = 6;
            // 
            // UCChanneling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.DoctorsSDGV);
            this.Name = "UCChanneling";
            this.Size = new System.Drawing.Size(943, 623);
            this.Load += new System.EventHandler(this.UCChanneling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsSDGV)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DoctorsSDGV;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TimeTb;
        private Guna.UI2.WinForms.Guna2GradientButton Channel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DoctorsCb;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}
