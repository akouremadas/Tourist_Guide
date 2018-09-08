namespace Tourist_Guide
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guideDataSet = new Tourist_Guide.guideDataSet();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.surnamelbl = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.userlbl = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passlbl = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.usersTableAdapter = new Tourist_Guide.guideDataSetTableAdapters.usersTableAdapter();
            this.loginsTableAdapter = new Tourist_Guide.guideDataSetTableAdapters.loginsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guideDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.namelbl.Location = new System.Drawing.Point(216, 13);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(48, 16);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Όνομα";
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nametxt.Location = new System.Drawing.Point(292, 12);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(266, 22);
            this.nametxt.TabIndex = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.guideDataSet;
            // 
            // guideDataSet
            // 
            this.guideDataSet.DataSetName = "guideDataSet";
            this.guideDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // surnametxt
            // 
            this.surnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnametxt.Location = new System.Drawing.Point(292, 47);
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(266, 22);
            this.surnametxt.TabIndex = 1;
            // 
            // surnamelbl
            // 
            this.surnamelbl.AutoSize = true;
            this.surnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnamelbl.Location = new System.Drawing.Point(216, 48);
            this.surnamelbl.Name = "surnamelbl";
            this.surnamelbl.Size = new System.Drawing.Size(62, 16);
            this.surnamelbl.TabIndex = 2;
            this.surnamelbl.Text = "Επώνυμο";
            // 
            // usertxt
            // 
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usertxt.Location = new System.Drawing.Point(325, 82);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(233, 22);
            this.usertxt.TabIndex = 2;
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.userlbl.Location = new System.Drawing.Point(216, 83);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(94, 16);
            this.userlbl.TabIndex = 3;
            this.userlbl.Text = "Όνομα χρήστη";
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passtxt.Location = new System.Drawing.Point(325, 116);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(233, 22);
            this.passtxt.TabIndex = 3;
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "logins";
            this.loginsBindingSource.DataSource = this.guideDataSet;
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passlbl.Location = new System.Drawing.Point(216, 117);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(102, 16);
            this.passlbl.TabIndex = 4;
            this.passlbl.Text = "Κωδικός χρήστη";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cancelbtn.Location = new System.Drawing.Point(289, 170);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 0;
            this.cancelbtn.Text = "Ακύρωση";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.registerbtn.Location = new System.Drawing.Point(438, 170);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(75, 23);
            this.registerbtn.TabIndex = 4;
            this.registerbtn.Text = "Εγγραφή";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 216);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.surnametxt);
            this.Controls.Add(this.surnamelbl);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Εγγραφή χρήστη";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guideDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.Label surnamelbl;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button registerbtn;
        private guideDataSet guideDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private guideDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private guideDataSetTableAdapters.loginsTableAdapter loginsTableAdapter;
    }
}