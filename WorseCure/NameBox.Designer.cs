namespace WorseCure
{
    partial class NameBox
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
            this.tb_entername = new System.Windows.Forms.TextBox();
            this.btn_addname = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.lb_names = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.b_clear_name = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_entername
            // 
            this.tb_entername.Location = new System.Drawing.Point(9, 182);
            this.tb_entername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_entername.Name = "tb_entername";
            this.tb_entername.Size = new System.Drawing.Size(122, 20);
            this.tb_entername.TabIndex = 0;
            // 
            // btn_addname
            // 
            this.btn_addname.Location = new System.Drawing.Point(135, 181);
            this.btn_addname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addname.Name = "btn_addname";
            this.btn_addname.Size = new System.Drawing.Size(56, 19);
            this.btn_addname.TabIndex = 2;
            this.btn_addname.Text = "&Add";
            this.btn_addname.UseVisualStyleBackColor = true;
            this.btn_addname.Click += new System.EventHandler(this.btn_addname_Click);
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(74, 217);
            this.btn_done.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(56, 19);
            this.btn_done.TabIndex = 3;
            this.btn_done.Text = "&Done";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // lb_names
            // 
            this.lb_names.FormattingEnabled = true;
            this.lb_names.Location = new System.Drawing.Point(9, 11);
            this.lb_names.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_names.Name = "lb_names";
            this.lb_names.Size = new System.Drawing.Size(122, 160);
            this.lb_names.TabIndex = 4;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(135, 11);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(56, 19);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "&Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // b_clear_name
            // 
            this.b_clear_name.Location = new System.Drawing.Point(137, 91);
            this.b_clear_name.Name = "b_clear_name";
            this.b_clear_name.Size = new System.Drawing.Size(54, 22);
            this.b_clear_name.TabIndex = 6;
            this.b_clear_name.Text = "Clear";
            this.b_clear_name.UseVisualStyleBackColor = true;
            this.b_clear_name.Click += new System.EventHandler(this.b_clear_name_Click);
            // 
            // NameBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 249);
            this.Controls.Add(this.b_clear_name);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lb_names);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_addname);
            this.Controls.Add(this.tb_entername);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NameBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NameBox_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_entername;
        private System.Windows.Forms.Button btn_addname;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.ListBox lb_names;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button b_clear_name;
    }
}