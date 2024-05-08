namespace milestoneTwo.PresentationLayer
{
    partial class Module_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Module_Information));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModuleCode = new System.Windows.Forms.TextBox();
            this.txtModuleDescription = new System.Windows.Forms.TextBox();
            this.txtOnlineResources = new System.Windows.Forms.TextBox();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.btnDeleteModule = new System.Windows.Forms.Button();
            this.btnUpdateModule = new System.Windows.Forms.Button();
            this.btnDisplayModule = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Module Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Online Resources";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Module Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Module Name";
            // 
            // txtModuleCode
            // 
            this.txtModuleCode.Location = new System.Drawing.Point(548, 124);
            this.txtModuleCode.Name = "txtModuleCode";
            this.txtModuleCode.Size = new System.Drawing.Size(349, 26);
            this.txtModuleCode.TabIndex = 5;
            // 
            // txtModuleDescription
            // 
            this.txtModuleDescription.Location = new System.Drawing.Point(548, 255);
            this.txtModuleDescription.Name = "txtModuleDescription";
            this.txtModuleDescription.Size = new System.Drawing.Size(349, 26);
            this.txtModuleDescription.TabIndex = 6;
            // 
            // txtOnlineResources
            // 
            this.txtOnlineResources.Location = new System.Drawing.Point(548, 329);
            this.txtOnlineResources.Name = "txtOnlineResources";
            this.txtOnlineResources.Size = new System.Drawing.Size(349, 26);
            this.txtOnlineResources.TabIndex = 8;
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(548, 190);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(349, 26);
            this.txtModuleName.TabIndex = 9;
            // 
            // btnAddModule
            // 
            this.btnAddModule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddModule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddModule.Location = new System.Drawing.Point(552, 400);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(148, 52);
            this.btnAddModule.TabIndex = 10;
            this.btnAddModule.Text = "Add Module";
            this.btnAddModule.UseVisualStyleBackColor = false;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // btnDeleteModule
            // 
            this.btnDeleteModule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteModule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteModule.Location = new System.Drawing.Point(749, 470);
            this.btnDeleteModule.Name = "btnDeleteModule";
            this.btnDeleteModule.Size = new System.Drawing.Size(148, 52);
            this.btnDeleteModule.TabIndex = 11;
            this.btnDeleteModule.Text = "Delete Module";
            this.btnDeleteModule.UseVisualStyleBackColor = false;
            this.btnDeleteModule.Click += new System.EventHandler(this.btnDeleteModule_Click);
            // 
            // btnUpdateModule
            // 
            this.btnUpdateModule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateModule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateModule.Location = new System.Drawing.Point(552, 470);
            this.btnUpdateModule.Name = "btnUpdateModule";
            this.btnUpdateModule.Size = new System.Drawing.Size(148, 52);
            this.btnUpdateModule.TabIndex = 12;
            this.btnUpdateModule.Text = "Update Module";
            this.btnUpdateModule.UseVisualStyleBackColor = false;
            this.btnUpdateModule.Click += new System.EventHandler(this.btnUpdateModule_Click);
            // 
            // btnDisplayModule
            // 
            this.btnDisplayModule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDisplayModule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisplayModule.Location = new System.Drawing.Point(749, 400);
            this.btnDisplayModule.Name = "btnDisplayModule";
            this.btnDisplayModule.Size = new System.Drawing.Size(148, 52);
            this.btnDisplayModule.TabIndex = 13;
            this.btnDisplayModule.Text = "Display Modules";
            this.btnDisplayModule.UseVisualStyleBackColor = false;
            this.btnDisplayModule.Click += new System.EventHandler(this.btnDisplayModule_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Module_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDisplayModule);
            this.Controls.Add(this.btnUpdateModule);
            this.Controls.Add(this.btnDeleteModule);
            this.Controls.Add(this.btnAddModule);
            this.Controls.Add(this.txtModuleName);
            this.Controls.Add(this.txtOnlineResources);
            this.Controls.Add(this.txtModuleDescription);
            this.Controls.Add(this.txtModuleCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Module_Information";
            this.Text = "Module_Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModuleCode;
        private System.Windows.Forms.TextBox txtModuleDescription;
        private System.Windows.Forms.TextBox txtOnlineResources;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.Button btnDeleteModule;
        private System.Windows.Forms.Button btnUpdateModule;
        private System.Windows.Forms.Button btnDisplayModule;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}