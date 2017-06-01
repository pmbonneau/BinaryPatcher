namespace BinaryPatcherUI
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPatchFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenContainer = new System.Windows.Forms.Button();
            this.txtContainerPath = new System.Windows.Forms.TextBox();
            this.btnCheckAvailablePatches = new System.Windows.Forms.Button();
            this.gbAvailablePatches = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnPatchFile
            // 
            this.btnPatchFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatchFile.Location = new System.Drawing.Point(165, 381);
            this.btnPatchFile.Name = "btnPatchFile";
            this.btnPatchFile.Size = new System.Drawing.Size(192, 50);
            this.btnPatchFile.TabIndex = 0;
            this.btnPatchFile.Text = "Patch File";
            this.btnPatchFile.UseVisualStyleBackColor = true;
            this.btnPatchFile.Click += new System.EventHandler(this.btnPatchFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(192, 19);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(298, 26);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(157, 43);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File to Patch";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenContainer
            // 
            this.btnOpenContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenContainer.Location = new System.Drawing.Point(12, 73);
            this.btnOpenContainer.Name = "btnOpenContainer";
            this.btnOpenContainer.Size = new System.Drawing.Size(157, 43);
            this.btnOpenContainer.TabIndex = 3;
            this.btnOpenContainer.Text = "Open Patch Container";
            this.btnOpenContainer.UseVisualStyleBackColor = true;
            this.btnOpenContainer.Click += new System.EventHandler(this.btnOpenContainer_Click);
            // 
            // txtContainerPath
            // 
            this.txtContainerPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContainerPath.Location = new System.Drawing.Point(192, 80);
            this.txtContainerPath.Name = "txtContainerPath";
            this.txtContainerPath.Size = new System.Drawing.Size(298, 26);
            this.txtContainerPath.TabIndex = 4;
            // 
            // btnCheckAvailablePatches
            // 
            this.btnCheckAvailablePatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAvailablePatches.Location = new System.Drawing.Point(12, 137);
            this.btnCheckAvailablePatches.Name = "btnCheckAvailablePatches";
            this.btnCheckAvailablePatches.Size = new System.Drawing.Size(171, 43);
            this.btnCheckAvailablePatches.TabIndex = 5;
            this.btnCheckAvailablePatches.Text = "Check available patches";
            this.btnCheckAvailablePatches.UseVisualStyleBackColor = true;
            this.btnCheckAvailablePatches.Click += new System.EventHandler(this.btnCheckAvailablePatches_Click);
            // 
            // gbAvailablePatches
            // 
            this.gbAvailablePatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAvailablePatches.Location = new System.Drawing.Point(12, 198);
            this.gbAvailablePatches.Name = "gbAvailablePatches";
            this.gbAvailablePatches.Size = new System.Drawing.Size(487, 159);
            this.gbAvailablePatches.TabIndex = 6;
            this.gbAvailablePatches.TabStop = false;
            this.gbAvailablePatches.Text = "Available patches";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 443);
            this.Controls.Add(this.gbAvailablePatches);
            this.Controls.Add(this.btnCheckAvailablePatches);
            this.Controls.Add(this.txtContainerPath);
            this.Controls.Add(this.btnOpenContainer);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnPatchFile);
            this.Name = "frmMain";
            this.Text = "Binary Patcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatchFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenContainer;
        private System.Windows.Forms.TextBox txtContainerPath;
        private System.Windows.Forms.Button btnCheckAvailablePatches;
        private System.Windows.Forms.GroupBox gbAvailablePatches;
    }
}

