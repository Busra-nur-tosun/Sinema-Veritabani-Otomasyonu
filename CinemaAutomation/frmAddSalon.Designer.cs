
namespace CinemaAutomation
{
    partial class frmAddSalon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSalon));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalonName = new System.Windows.Forms.TextBox();
            this.btnSalonAdd = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon Adı";
            // 
            // txtSalonName
            // 
            this.txtSalonName.Location = new System.Drawing.Point(201, 43);
            this.txtSalonName.Multiline = true;
            this.txtSalonName.Name = "txtSalonName";
            this.txtSalonName.Size = new System.Drawing.Size(137, 29);
            this.txtSalonName.TabIndex = 1;
            // 
            // btnSalonAdd
            // 
            this.btnSalonAdd.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSalonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalonAdd.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSalonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalonAdd.ImageIndex = 0;
            this.btnSalonAdd.ImageList = this.ımageList1;
            this.btnSalonAdd.Location = new System.Drawing.Point(142, 96);
            this.btnSalonAdd.Name = "btnSalonAdd";
            this.btnSalonAdd.Size = new System.Drawing.Size(101, 48);
            this.btnSalonAdd.TabIndex = 2;
            this.btnSalonAdd.Text = "Ekle";
            this.btnSalonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalonAdd.UseVisualStyleBackColor = false;
            this.btnSalonAdd.Click += new System.EventHandler(this.btnSalonAdd_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "salon2.PNG");
            // 
            // frmAddSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaAutomation.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 248);
            this.Controls.Add(this.btnSalonAdd);
            this.Controls.Add(this.txtSalonName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddSalon";
            this.Text = "frmAddSalon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalonName;
        private System.Windows.Forms.Button btnSalonAdd;
        private System.Windows.Forms.ImageList ımageList1;
    }
}