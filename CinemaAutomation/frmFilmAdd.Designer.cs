
namespace CinemaAutomation
{
    partial class frmFilmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.Yönetmen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilmName = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cmbFilmTye = new System.Windows.Forms.ComboBox();
            this.btnFilmAdd = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChooseBannner = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(69, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı";
            // 
            // Yönetmen
            // 
            this.Yönetmen.AutoSize = true;
            this.Yönetmen.BackColor = System.Drawing.Color.Transparent;
            this.Yönetmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yönetmen.ForeColor = System.Drawing.Color.Yellow;
            this.Yönetmen.Location = new System.Drawing.Point(59, 87);
            this.Yönetmen.Name = "Yönetmen";
            this.Yönetmen.Size = new System.Drawing.Size(91, 20);
            this.Yönetmen.TabIndex = 0;
            this.Yönetmen.Text = "Yönetmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(58, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Film Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(58, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Süre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(58, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yapım Yılı";
            // 
            // txtFilmName
            // 
            this.txtFilmName.Location = new System.Drawing.Point(183, 45);
            this.txtFilmName.Name = "txtFilmName";
            this.txtFilmName.Size = new System.Drawing.Size(126, 22);
            this.txtFilmName.TabIndex = 1;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(183, 85);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(126, 22);
            this.txtDirector.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(183, 160);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(126, 22);
            this.txtTime.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(183, 199);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(126, 22);
            this.txtYear.TabIndex = 1;
            // 
            // cmbFilmTye
            // 
            this.cmbFilmTye.FormattingEnabled = true;
            this.cmbFilmTye.Items.AddRange(new object[] {
            "Komedi",
            "Dram",
            "Korku",
            "Gerilim",
            "Macera",
            "Biyografi"});
            this.cmbFilmTye.Location = new System.Drawing.Point(183, 124);
            this.cmbFilmTye.Name = "cmbFilmTye";
            this.cmbFilmTye.Size = new System.Drawing.Size(126, 24);
            this.cmbFilmTye.TabIndex = 2;
            // 
            // btnFilmAdd
            // 
            this.btnFilmAdd.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFilmAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFilmAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilmAdd.ImageIndex = 0;
            this.btnFilmAdd.ImageList = this.ımageList1;
            this.btnFilmAdd.Location = new System.Drawing.Point(93, 324);
            this.btnFilmAdd.Name = "btnFilmAdd";
            this.btnFilmAdd.Size = new System.Drawing.Size(148, 49);
            this.btnFilmAdd.TabIndex = 3;
            this.btnFilmAdd.Text = "Film Ekle";
            this.btnFilmAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilmAdd.UseVisualStyleBackColor = false;
            this.btnFilmAdd.Click += new System.EventHandler(this.btnFilmAdd_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "filmekle.PNG");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(370, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnChooseBannner
            // 
            this.btnChooseBannner.BackColor = System.Drawing.Color.OrangeRed;
            this.btnChooseBannner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseBannner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseBannner.ImageIndex = 0;
            this.btnChooseBannner.ImageList = this.ımageList2;
            this.btnChooseBannner.Location = new System.Drawing.Point(389, 251);
            this.btnChooseBannner.Name = "btnChooseBannner";
            this.btnChooseBannner.Size = new System.Drawing.Size(137, 49);
            this.btnChooseBannner.TabIndex = 5;
            this.btnChooseBannner.Text = "Afiş Seç";
            this.btnChooseBannner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChooseBannner.UseVisualStyleBackColor = false;
            this.btnChooseBannner.Click += new System.EventHandler(this.btnChooseBannner_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "afiş.PNG");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(59, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // frmFilmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaAutomation.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnChooseBannner);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFilmAdd);
            this.Controls.Add(this.cmbFilmTye);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtFilmName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Yönetmen);
            this.Controls.Add(this.label1);
            this.Name = "frmFilmAdd";
            this.Text = "frmFilmAdd";
            this.Load += new System.EventHandler(this.frmFilmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Yönetmen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilmName;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbFilmTye;
        private System.Windows.Forms.Button btnFilmAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChooseBannner;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}