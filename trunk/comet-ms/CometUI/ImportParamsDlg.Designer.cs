﻿namespace CometUI
{
    partial class ImportParamsDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportParamsDlg));
            this.btnCancel = new System.Windows.Forms.Button();
            this.paramsDbFileCombo = new System.Windows.Forms.ComboBox();
            this.btnBrowseParams = new System.Windows.Forms.Button();
            this.paramsDbLabel = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(381, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 103;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // paramsDbFileCombo
            // 
            this.paramsDbFileCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.paramsDbFileCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.paramsDbFileCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.paramsDbFileCombo.FormattingEnabled = true;
            this.paramsDbFileCombo.Location = new System.Drawing.Point(15, 32);
            this.paramsDbFileCombo.Name = "paramsDbFileCombo";
            this.paramsDbFileCombo.Size = new System.Drawing.Size(360, 23);
            this.paramsDbFileCombo.TabIndex = 100;
            // 
            // btnBrowseParams
            // 
            this.btnBrowseParams.Location = new System.Drawing.Point(381, 32);
            this.btnBrowseParams.Name = "btnBrowseParams";
            this.btnBrowseParams.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseParams.TabIndex = 101;
            this.btnBrowseParams.Text = "&Browse";
            this.btnBrowseParams.UseVisualStyleBackColor = true;
            this.btnBrowseParams.Click += new System.EventHandler(this.BtnBrowseParamsClick);
            // 
            // paramsDbLabel
            // 
            this.paramsDbLabel.AutoSize = true;
            this.paramsDbLabel.Location = new System.Drawing.Point(12, 16);
            this.paramsDbLabel.Name = "paramsDbLabel";
            this.paramsDbLabel.Size = new System.Drawing.Size(128, 13);
            this.paramsDbLabel.TabIndex = 43;
            this.paramsDbLabel.Text = "&Parameters File (.params):";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(300, 88);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 102;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // ImportParamsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 123);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnBrowseParams);
            this.Controls.Add(this.paramsDbLabel);
            this.Controls.Add(this.paramsDbFileCombo);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportParamsDlg";
            this.Text = "Import Search Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox paramsDbFileCombo;
        private System.Windows.Forms.Button btnBrowseParams;
        private System.Windows.Forms.Label paramsDbLabel;
        private System.Windows.Forms.Button btnImport;
    }
}