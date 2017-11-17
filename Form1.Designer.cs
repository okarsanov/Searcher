namespace Searcher
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWhat = new System.Windows.Forms.TextBox();
            this.tbWhere = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCshtml = new System.Windows.Forms.CheckBox();
            this.chkCs = new System.Windows.Forms.CheckBox();
            this.chkJs = new System.Windows.Forms.CheckBox();
            this.chHtml = new System.Windows.Forms.CheckBox();
            this.chkCss = new System.Windows.Forms.CheckBox();
            this.chkLess = new System.Windows.Forms.CheckBox();
            this.chkTs = new System.Windows.Forms.CheckBox();
            this.gbExtensions = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkConfig = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbExtensions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Что искать?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Где искать?";
            // 
            // tbWhat
            // 
            this.tbWhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWhat.Location = new System.Drawing.Point(88, 6);
            this.tbWhat.Name = "tbWhat";
            this.tbWhat.Size = new System.Drawing.Size(1046, 20);
            this.tbWhat.TabIndex = 1;
            // 
            // tbWhere
            // 
            this.tbWhere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWhere.Location = new System.Drawing.Point(88, 41);
            this.tbWhere.Name = "tbWhere";
            this.tbWhere.Size = new System.Drawing.Size(1012, 20);
            this.tbWhere.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1119, 510);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1140, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Искать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Найдено:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 603);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // chkCshtml
            // 
            this.chkCshtml.AutoSize = true;
            this.chkCshtml.Checked = true;
            this.chkCshtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCshtml.Location = new System.Drawing.Point(10, 19);
            this.chkCshtml.Name = "chkCshtml";
            this.chkCshtml.Size = new System.Drawing.Size(59, 17);
            this.chkCshtml.TabIndex = 6;
            this.chkCshtml.Text = ".cshtml";
            this.chkCshtml.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chkCshtml.UseVisualStyleBackColor = true;
            // 
            // chkCs
            // 
            this.chkCs.AutoSize = true;
            this.chkCs.Location = new System.Drawing.Point(10, 42);
            this.chkCs.Name = "chkCs";
            this.chkCs.Size = new System.Drawing.Size(40, 17);
            this.chkCs.TabIndex = 7;
            this.chkCs.Text = ".cs";
            this.chkCs.UseVisualStyleBackColor = true;
            // 
            // chkJs
            // 
            this.chkJs.AutoSize = true;
            this.chkJs.Location = new System.Drawing.Point(10, 65);
            this.chkJs.Name = "chkJs";
            this.chkJs.Size = new System.Drawing.Size(36, 17);
            this.chkJs.TabIndex = 8;
            this.chkJs.Text = ".js";
            this.chkJs.UseVisualStyleBackColor = true;
            // 
            // chHtml
            // 
            this.chHtml.AutoSize = true;
            this.chHtml.Location = new System.Drawing.Point(10, 88);
            this.chHtml.Name = "chHtml";
            this.chHtml.Size = new System.Drawing.Size(48, 17);
            this.chHtml.TabIndex = 9;
            this.chHtml.Text = ".html";
            this.chHtml.UseVisualStyleBackColor = true;
            // 
            // chkCss
            // 
            this.chkCss.AutoSize = true;
            this.chkCss.Location = new System.Drawing.Point(10, 111);
            this.chkCss.Name = "chkCss";
            this.chkCss.Size = new System.Drawing.Size(45, 17);
            this.chkCss.TabIndex = 10;
            this.chkCss.Text = ".css";
            this.chkCss.UseVisualStyleBackColor = true;
            // 
            // chkLess
            // 
            this.chkLess.AutoSize = true;
            this.chkLess.Location = new System.Drawing.Point(10, 134);
            this.chkLess.Name = "chkLess";
            this.chkLess.Size = new System.Drawing.Size(47, 17);
            this.chkLess.TabIndex = 11;
            this.chkLess.Text = ".less";
            this.chkLess.UseVisualStyleBackColor = true;
            // 
            // chkTs
            // 
            this.chkTs.AutoSize = true;
            this.chkTs.Location = new System.Drawing.Point(10, 157);
            this.chkTs.Name = "chkTs";
            this.chkTs.Size = new System.Drawing.Size(37, 17);
            this.chkTs.TabIndex = 12;
            this.chkTs.Text = ".ts";
            this.chkTs.UseVisualStyleBackColor = true;
            // 
            // gbExtensions
            // 
            this.gbExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbExtensions.Controls.Add(this.checkBox1);
            this.gbExtensions.Controls.Add(this.chkConfig);
            this.gbExtensions.Controls.Add(this.chkCshtml);
            this.gbExtensions.Controls.Add(this.chkTs);
            this.gbExtensions.Controls.Add(this.chkCs);
            this.gbExtensions.Controls.Add(this.chkLess);
            this.gbExtensions.Controls.Add(this.chkJs);
            this.gbExtensions.Controls.Add(this.chkCss);
            this.gbExtensions.Controls.Add(this.chHtml);
            this.gbExtensions.Location = new System.Drawing.Point(1140, 79);
            this.gbExtensions.Name = "gbExtensions";
            this.gbExtensions.Size = new System.Drawing.Size(75, 231);
            this.gbExtensions.TabIndex = 13;
            this.gbExtensions.TabStop = false;
            this.gbExtensions.Text = "Extensions";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = ".csproj";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkConfig
            // 
            this.chkConfig.AutoSize = true;
            this.chkConfig.Location = new System.Drawing.Point(10, 180);
            this.chkConfig.Name = "chkConfig";
            this.chkConfig.Size = new System.Drawing.Size(58, 17);
            this.chkConfig.TabIndex = 13;
            this.chkConfig.Text = ".config";
            this.chkConfig.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Просмотрено файлов";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "0";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1106, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 625);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbExtensions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbWhere);
            this.Controls.Add(this.tbWhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbExtensions.ResumeLayout(false);
            this.gbExtensions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWhat;
        private System.Windows.Forms.TextBox tbWhere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCshtml;
        private System.Windows.Forms.CheckBox chkCs;
        private System.Windows.Forms.CheckBox chkJs;
        private System.Windows.Forms.CheckBox chHtml;
        private System.Windows.Forms.CheckBox chkCss;
        private System.Windows.Forms.CheckBox chkLess;
        private System.Windows.Forms.CheckBox chkTs;
        private System.Windows.Forms.GroupBox gbExtensions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkConfig;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
    }
}

