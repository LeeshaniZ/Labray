namespace LabRay
{
    partial class UCAppoinment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAppoinment));
            this.appointmentViewDG = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DoctorsCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnupdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtboxappid = new System.Windows.Forms.TextBox();
            this.btnremove = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewDG)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentViewDG
            // 
            this.appointmentViewDG.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.appointmentViewDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentViewDG.GridColor = System.Drawing.Color.Purple;
            this.appointmentViewDG.Location = new System.Drawing.Point(188, 396);
            this.appointmentViewDG.Name = "appointmentViewDG";
            this.appointmentViewDG.RowHeadersWidth = 51;
            this.appointmentViewDG.RowTemplate.Height = 24;
            this.appointmentViewDG.Size = new System.Drawing.Size(565, 439);
            this.appointmentViewDG.TabIndex = 1;
            this.appointmentViewDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentViewDG_CellContentClick);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.LightGray;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkOrchid;
            this.guna2GroupBox1.Controls.Add(this.dateTimePicker2);
            this.guna2GroupBox1.Controls.Add(this.DoctorsCb);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.btnupdate);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.TimeTb);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Purple;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Thistle;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.guna2GroupBox1.Location = new System.Drawing.Point(4, 897);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(521, 358);
            this.guna2GroupBox1.TabIndex = 7;
            this.guna2GroupBox1.Text = "Change your appointment";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.Purple;
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.DarkMagenta;
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(286, 151);
            this.dateTimePicker2.MaxDate = new System.DateTime(2024, 9, 1, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2024, 7, 20, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(208, 38);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.Value = new System.DateTime(2024, 7, 20, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // DoctorsCb
            // 
            this.DoctorsCb.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorsCb.FormattingEnabled = true;
            this.DoctorsCb.Location = new System.Drawing.Point(288, 75);
            this.DoctorsCb.Name = "DoctorsCb";
            this.DoctorsCb.Size = new System.Drawing.Size(206, 36);
            this.DoctorsCb.TabIndex = 12;
            this.DoctorsCb.SelectedIndexChanged += new System.EventHandler(this.DoctorsCb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(61, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Change Time :";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Thistle;
            this.btnupdate.BorderRadius = 20;
            this.btnupdate.BorderThickness = 1;
            this.btnupdate.CheckedState.Parent = this.btnupdate;
            this.btnupdate.CustomImages.Parent = this.btnupdate;
            this.btnupdate.FillColor = System.Drawing.Color.Purple;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.Parent = this.btnupdate;
            this.btnupdate.Location = new System.Drawing.Point(314, 299);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ShadowDecoration.Parent = this.btnupdate;
            this.btnupdate.Size = new System.Drawing.Size(180, 45);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnremoveappointment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(61, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Change Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Change Doctor :";
            // 
            // TimeTb
            // 
            this.TimeTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeTb.BorderColorFocused = System.Drawing.Color.Purple;
            this.TimeTb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimeTb.BorderColorMouseHover = System.Drawing.Color.Indigo;
            this.TimeTb.BorderThickness = 1;
            this.TimeTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TimeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TimeTb.ForeColor = System.Drawing.Color.Black;
            this.TimeTb.isPassword = false;
            this.TimeTb.Location = new System.Drawing.Point(285, 215);
            this.TimeTb.Margin = new System.Windows.Forms.Padding(4);
            this.TimeTb.MaxLength = 32767;
            this.TimeTb.Name = "TimeTb";
            this.TimeTb.Size = new System.Drawing.Size(209, 44);
            this.TimeTb.TabIndex = 7;
            this.TimeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TimeTb.OnValueChanged += new System.EventHandler(this.TimeTb_OnValueChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Thistle;
            this.guna2GroupBox2.Controls.Add(this.txtboxappid);
            this.guna2GroupBox2.Controls.Add(this.btnremove);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Purple;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Thistle;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.GhostWhite;
            this.guna2GroupBox2.Location = new System.Drawing.Point(531, 897);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(433, 358);
            this.guna2GroupBox2.TabIndex = 8;
            this.guna2GroupBox2.Text = "Delete An Appointment";
            // 
            // txtboxappid
            // 
            this.txtboxappid.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxappid.Location = new System.Drawing.Point(214, 135);
            this.txtboxappid.Name = "txtboxappid";
            this.txtboxappid.Size = new System.Drawing.Size(129, 34);
            this.txtboxappid.TabIndex = 12;
            this.txtboxappid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Thistle;
            this.btnremove.BorderRadius = 20;
            this.btnremove.BorderThickness = 1;
            this.btnremove.CheckedState.Parent = this.btnremove;
            this.btnremove.CustomImages.Parent = this.btnremove;
            this.btnremove.FillColor = System.Drawing.Color.Purple;
            this.btnremove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.HoverState.Parent = this.btnremove;
            this.btnremove.Location = new System.Drawing.Point(163, 299);
            this.btnremove.Name = "btnremove";
            this.btnremove.ShadowDecoration.Parent = this.btnremove;
            this.btnremove.Size = new System.Drawing.Size(180, 45);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "Delete";
            this.btnremove.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Thistle;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Appointment ID :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 335);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(638, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // UCAppoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.appointmentViewDG);
            this.Name = "UCAppoinment";
            this.Size = new System.Drawing.Size(943, 644);
            this.Load += new System.EventHandler(this.UCAppoinment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewDG)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView appointmentViewDG;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox DoctorsCb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton btnupdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TimeTb;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btnremove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxappid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
