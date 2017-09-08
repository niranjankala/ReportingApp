namespace sdlcRDLCReport
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.KMTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SMR_KMS_DB_DevDataSet = new sdlcRDLCReport.SMR_KMS_DB_DevDataSet();
            this.KMTeamsTableAdapter = new sdlcRDLCReport.SMR_KMS_DB_DevDataSetTableAdapters.KMTeamsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KMTeamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMR_KMS_DB_DevDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // KMTeamsBindingSource
            // 
            this.KMTeamsBindingSource.DataMember = "KMTeams";
            this.KMTeamsBindingSource.DataSource = this.SMR_KMS_DB_DevDataSet;
            // 
            // SMR_KMS_DB_DevDataSet
            // 
            this.SMR_KMS_DB_DevDataSet.DataSetName = "SMR_KMS_DB_DevDataSet";
            this.SMR_KMS_DB_DevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KMTeamsTableAdapter
            // 
            this.KMTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 386);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KMTeamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMR_KMS_DB_DevDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource KMTeamsBindingSource;
        private SMR_KMS_DB_DevDataSet SMR_KMS_DB_DevDataSet;
        private SMR_KMS_DB_DevDataSetTableAdapters.KMTeamsTableAdapter KMTeamsTableAdapter;
        private System.Windows.Forms.Button button1;

    }
}

