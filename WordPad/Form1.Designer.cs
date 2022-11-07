namespace WordPad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_Fonts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_Sizes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Bold = new System.Windows.Forms.Button();
            this.btn_Italic = new System.Windows.Forms.Button();
            this.btn_Underline = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Center = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox_Colors = new System.Windows.Forms.ComboBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_Redo = new System.Windows.Forms.PictureBox();
            this.pictureBox_Undo = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Redo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Undo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // cbox_Fonts
            // 
            this.cbox_Fonts.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cbox_Fonts.FormattingEnabled = true;
            this.cbox_Fonts.Items.AddRange(new object[] {
            " Arial Rounded MT",
            " Cooper",
            " Georgia",
            " Latin",
            " Mistral",
            " Times New Roman"});
            this.cbox_Fonts.Location = new System.Drawing.Point(12, 74);
            this.cbox_Fonts.Name = "cbox_Fonts";
            this.cbox_Fonts.Size = new System.Drawing.Size(212, 31);
            this.cbox_Fonts.TabIndex = 1;
            this.cbox_Fonts.SelectedIndexChanged += new System.EventHandler(this.cbox_Fonts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(264, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // cbox_Sizes
            // 
            this.cbox_Sizes.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cbox_Sizes.FormattingEnabled = true;
            this.cbox_Sizes.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28"});
            this.cbox_Sizes.Location = new System.Drawing.Point(264, 73);
            this.cbox_Sizes.Name = "cbox_Sizes";
            this.cbox_Sizes.Size = new System.Drawing.Size(72, 31);
            this.cbox_Sizes.TabIndex = 3;
            this.cbox_Sizes.SelectedIndexChanged += new System.EventHandler(this.cbox_Fonts_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(453, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "FontStyle";
            // 
            // btn_Bold
            // 
            this.btn_Bold.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Bold.Location = new System.Drawing.Point(408, 56);
            this.btn_Bold.Name = "btn_Bold";
            this.btn_Bold.Size = new System.Drawing.Size(61, 48);
            this.btn_Bold.TabIndex = 5;
            this.btn_Bold.Text = "B";
            this.btn_Bold.UseVisualStyleBackColor = true;
            this.btn_Bold.Click += new System.EventHandler(this.btn_Bold_Click);
            // 
            // btn_Italic
            // 
            this.btn_Italic.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_Italic.Location = new System.Drawing.Point(542, 56);
            this.btn_Italic.Name = "btn_Italic";
            this.btn_Italic.Size = new System.Drawing.Size(61, 48);
            this.btn_Italic.TabIndex = 5;
            this.btn_Italic.Text = "I";
            this.btn_Italic.UseVisualStyleBackColor = true;
            this.btn_Italic.Click += new System.EventHandler(this.btn_Italic_Click);
            // 
            // btn_Underline
            // 
            this.btn_Underline.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btn_Underline.Location = new System.Drawing.Point(475, 56);
            this.btn_Underline.Name = "btn_Underline";
            this.btn_Underline.Size = new System.Drawing.Size(61, 48);
            this.btn_Underline.TabIndex = 5;
            this.btn_Underline.Text = "U";
            this.btn_Underline.UseVisualStyleBackColor = true;
            this.btn_Underline.Click += new System.EventHandler(this.btn_Underline_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(708, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alignment";
            // 
            // btn_Left
            // 
            this.btn_Left.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Left.Location = new System.Drawing.Point(680, 57);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(63, 48);
            this.btn_Left.TabIndex = 7;
            this.btn_Left.Text = "L";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // btn_Center
            // 
            this.btn_Center.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Center.Location = new System.Drawing.Point(749, 57);
            this.btn_Center.Name = "btn_Center";
            this.btn_Center.Size = new System.Drawing.Size(63, 48);
            this.btn_Center.TabIndex = 7;
            this.btn_Center.Text = "C";
            this.btn_Center.UseVisualStyleBackColor = true;
            this.btn_Center.Click += new System.EventHandler(this.btn_Center_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Right.Location = new System.Drawing.Point(818, 57);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(63, 48);
            this.btn_Right.TabIndex = 7;
            this.btn_Right.Text = "R";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(973, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color";
            // 
            // cbox_Colors
            // 
            this.cbox_Colors.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbox_Colors.FormattingEnabled = true;
            this.cbox_Colors.Items.AddRange(new object[] {
            " Black",
            " Aquamarine",
            " Red",
            " Blue",
            " Green",
            " Yellow",
            " DeepPink",
            " Purple",
            " Goldenrod",
            " LightSalmon"});
            this.cbox_Colors.Location = new System.Drawing.Point(963, 73);
            this.cbox_Colors.Name = "cbox_Colors";
            this.cbox_Colors.Size = new System.Drawing.Size(151, 31);
            this.cbox_Colors.TabIndex = 9;
            this.cbox_Colors.SelectedIndexChanged += new System.EventHandler(this.cbox_Colors_SelectedIndexChanged);
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Load.Location = new System.Drawing.Point(1340, 9);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(105, 50);
            this.btn_Load.TabIndex = 10;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1467, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 48);
            this.textBox1.TabIndex = 11;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(1340, 65);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(356, 42);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1156, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Undo,Redo";
            // 
            // pictureBox_Redo
            // 
            this.pictureBox_Redo.Image = global::WordPad.Properties.Resources.icons8_redo_24;
            this.pictureBox_Redo.Location = new System.Drawing.Point(1230, 56);
            this.pictureBox_Redo.Name = "pictureBox_Redo";
            this.pictureBox_Redo.Size = new System.Drawing.Size(41, 36);
            this.pictureBox_Redo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Redo.TabIndex = 14;
            this.pictureBox_Redo.TabStop = false;
            this.pictureBox_Redo.Click += new System.EventHandler(this.pictureBox_Redo_Click);
            // 
            // pictureBox_Undo
            // 
            this.pictureBox_Undo.Image = global::WordPad.Properties.Resources.icons8_undo_24;
            this.pictureBox_Undo.Location = new System.Drawing.Point(1172, 56);
            this.pictureBox_Undo.Name = "pictureBox_Undo";
            this.pictureBox_Undo.Size = new System.Drawing.Size(41, 36);
            this.pictureBox_Undo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Undo.TabIndex = 14;
            this.pictureBox_Undo.TabStop = false;
            this.pictureBox_Undo.Click += new System.EventHandler(this.pictureBox_Undo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 179);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1676, 469);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1730, 660);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox_Undo);
            this.Controls.Add(this.pictureBox_Redo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.cbox_Colors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Center);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Underline);
            this.Controls.Add(this.btn_Italic);
            this.Controls.Add(this.btn_Bold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbox_Sizes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_Fonts);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WordPad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Redo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Undo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbox_Fonts;
        private Label label2;
        private ComboBox cbox_Sizes;
        private Label label3;
        private Button btn_Bold;
        private Button btn_Italic;
        private Button btn_Underline;
        private Label label4;
        private Button btn_Left;
        private Button btn_Center;
        private Button btn_Right;
        private Label label5;
        private ComboBox cbox_Colors;
        private Button btn_Load;
        private TextBox textBox1;
        private Button btn_Save;
        private Label label6;
        private PictureBox pictureBox_Redo;
        private PictureBox pictureBox_Undo;
        private RichTextBox richTextBox1;
    }
}