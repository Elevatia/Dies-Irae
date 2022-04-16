
namespace Dies_Irae.Popup
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.box_total_strings_tag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.box_total_file_bytes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_magic_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.box_view = new System.Windows.Forms.RichTextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.box_file_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel4.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 3;
            this.bunifuPanel1.Controls.Add(this.header);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel4);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel3);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(809, 543);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.bunifuPanel3.BorderRadius = 20;
            this.bunifuPanel3.BorderThickness = 3;
            this.bunifuPanel3.Controls.Add(this.box_file_path);
            this.bunifuPanel3.Controls.Add(this.label2);
            this.bunifuPanel3.Controls.Add(this.box_total_strings_tag);
            this.bunifuPanel3.Controls.Add(this.label4);
            this.bunifuPanel3.Controls.Add(this.box_total_file_bytes);
            this.bunifuPanel3.Controls.Add(this.label3);
            this.bunifuPanel3.Location = new System.Drawing.Point(429, 59);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(368, 118);
            this.bunifuPanel3.TabIndex = 55;
            // 
            // box_total_strings_tag
            // 
            this.box_total_strings_tag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.box_total_strings_tag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.box_total_strings_tag.Location = new System.Drawing.Point(102, 71);
            this.box_total_strings_tag.Name = "box_total_strings_tag";
            this.box_total_strings_tag.ReadOnly = true;
            this.box_total_strings_tag.Size = new System.Drawing.Size(243, 20);
            this.box_total_strings_tag.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total string:";
            // 
            // box_total_file_bytes
            // 
            this.box_total_file_bytes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.box_total_file_bytes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.box_total_file_bytes.Location = new System.Drawing.Point(103, 45);
            this.box_total_file_bytes.Name = "box_total_file_bytes";
            this.box_total_file_bytes.ReadOnly = true;
            this.box_total_file_bytes.Size = new System.Drawing.Size(243, 20);
            this.box_total_file_bytes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total file bytes:";
            // 
            // box_magic_number
            // 
            this.box_magic_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.box_magic_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.box_magic_number.Location = new System.Drawing.Point(102, 26);
            this.box_magic_number.Name = "box_magic_number";
            this.box_magic_number.ReadOnly = true;
            this.box_magic_number.Size = new System.Drawing.Size(243, 20);
            this.box_magic_number.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magic number:";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.bunifuPanel2.BorderRadius = 20;
            this.bunifuPanel2.BorderThickness = 3;
            this.bunifuPanel2.Controls.Add(this.box_view);
            this.bunifuPanel2.Location = new System.Drawing.Point(12, 59);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(411, 472);
            this.bunifuPanel2.TabIndex = 54;
            // 
            // box_view
            // 
            this.box_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.box_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_view.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.box_view.Location = new System.Drawing.Point(12, 12);
            this.box_view.Name = "box_view";
            this.box_view.ReadOnly = true;
            this.box_view.Size = new System.Drawing.Size(383, 444);
            this.box_view.TabIndex = 0;
            this.box_view.Text = "";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.bunifuPanel4.BorderRadius = 20;
            this.bunifuPanel4.BorderThickness = 3;
            this.bunifuPanel4.Controls.Add(this.box_magic_number);
            this.bunifuPanel4.Controls.Add(this.label1);
            this.bunifuPanel4.Location = new System.Drawing.Point(429, 183);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(368, 75);
            this.bunifuPanel4.TabIndex = 56;
            // 
            // box_file_path
            // 
            this.box_file_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.box_file_path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.box_file_path.Location = new System.Drawing.Point(103, 19);
            this.box_file_path.Name = "box_file_path";
            this.box_file_path.ReadOnly = true;
            this.box_file_path.Size = new System.Drawing.Size(243, 20);
            this.box_file_path.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "File path:";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Controls.Add(this.button_exit);
            this.header.Location = new System.Drawing.Point(12, 12);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(785, 41);
            this.header.TabIndex = 57;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit.BackgroundImage")));
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(750, 6);
            this.button_exit.Margin = new System.Windows.Forms.Padding(10);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(25, 25);
            this.button_exit.TabIndex = 9;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click_1);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(809, 543);
            this.Controls.Add(this.bunifuPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Shown += new System.EventHandler(this.Editor_Shown);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel4.PerformLayout();
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.RichTextBox box_view;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_magic_number;
        private System.Windows.Forms.TextBox box_total_file_bytes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_total_strings_tag;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private System.Windows.Forms.TextBox box_file_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button button_exit;
    }
}