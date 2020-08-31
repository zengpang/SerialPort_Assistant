namespace 串口助手
{
    partial class AddProtocolDialog
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
            this.ProtocolName_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProtocolContent_TextBox = new System.Windows.Forms.TextBox();
            this.ProtocolAdd_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProtocolName_TextBox
            // 
            this.ProtocolName_TextBox.Location = new System.Drawing.Point(12, 49);
            this.ProtocolName_TextBox.Name = "ProtocolName_TextBox";
            this.ProtocolName_TextBox.Size = new System.Drawing.Size(296, 21);
            this.ProtocolName_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "协议名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "协议内容";
            // 
            // ProtocolContent_TextBox
            // 
            this.ProtocolContent_TextBox.Location = new System.Drawing.Point(12, 108);
            this.ProtocolContent_TextBox.Name = "ProtocolContent_TextBox";
            this.ProtocolContent_TextBox.Size = new System.Drawing.Size(296, 21);
            this.ProtocolContent_TextBox.TabIndex = 3;
            // 
            // ProtocolAdd_Btn
            // 
            this.ProtocolAdd_Btn.Location = new System.Drawing.Point(16, 161);
            this.ProtocolAdd_Btn.Name = "ProtocolAdd_Btn";
            this.ProtocolAdd_Btn.Size = new System.Drawing.Size(95, 32);
            this.ProtocolAdd_Btn.TabIndex = 4;
            this.ProtocolAdd_Btn.Text = "添加";
            this.ProtocolAdd_Btn.UseVisualStyleBackColor = true;
            this.ProtocolAdd_Btn.Click += new System.EventHandler(this.ProtocolAdd_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(213, 161);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(95, 32);
            this.Cancel_Btn.TabIndex = 5;
            this.Cancel_Btn.Text = "取消";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // AddProtocolDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 208);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.ProtocolAdd_Btn);
            this.Controls.Add(this.ProtocolContent_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProtocolName_TextBox);
            this.Name = "AddProtocolDialog";
            this.Text = "协议添加窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProtocolName_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProtocolContent_TextBox;
        private System.Windows.Forms.Button ProtocolAdd_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
    }
}