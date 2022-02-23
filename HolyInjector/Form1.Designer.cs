namespace HolyInjector
{
    partial class HolyInjector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HolyInjector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.execute = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.Button();
            this.savefile = new System.Windows.Forms.Button();
            this.inject = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.scripts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.min);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 46);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(160, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "HOLYINJECTOR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.min.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.min.ForeColor = System.Drawing.Color.White;
            this.min.Location = new System.Drawing.Point(634, 3);
            this.min.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(80, 40);
            this.min.TabIndex = 3;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.exit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(718, 3);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(80, 40);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(259, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fastColoredTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.CommentPrefix = "--";
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.Black;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '{';
            this.fastColoredTextBox1.Location = new System.Drawing.Point(12, 52);
            this.fastColoredTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(625, 359);
            this.fastColoredTextBox1.TabIndex = 1;
            this.fastColoredTextBox1.Text = "thanks for using holyinjector";
            this.fastColoredTextBox1.TextAreaBorderColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // execute
            // 
            this.execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.execute.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.execute.ForeColor = System.Drawing.Color.White;
            this.execute.Location = new System.Drawing.Point(12, 413);
            this.execute.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(80, 33);
            this.execute.TabIndex = 4;
            this.execute.Text = "Execute";
            this.execute.UseVisualStyleBackColor = false;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.clear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(98, 413);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 33);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // openfile
            // 
            this.openfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.openfile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openfile.ForeColor = System.Drawing.Color.White;
            this.openfile.Location = new System.Drawing.Point(184, 413);
            this.openfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(80, 33);
            this.openfile.TabIndex = 6;
            this.openfile.Text = "Open File";
            this.openfile.UseVisualStyleBackColor = false;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // savefile
            // 
            this.savefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.savefile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savefile.ForeColor = System.Drawing.Color.White;
            this.savefile.Location = new System.Drawing.Point(270, 413);
            this.savefile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(80, 33);
            this.savefile.TabIndex = 7;
            this.savefile.Text = "Save File";
            this.savefile.UseVisualStyleBackColor = false;
            this.savefile.Click += new System.EventHandler(this.button4_Click);
            // 
            // inject
            // 
            this.inject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.inject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inject.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inject.ForeColor = System.Drawing.Color.White;
            this.inject.Location = new System.Drawing.Point(718, 413);
            this.inject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inject.Name = "inject";
            this.inject.Size = new System.Drawing.Size(80, 33);
            this.inject.TabIndex = 8;
            this.inject.Text = "Attach";
            this.inject.UseVisualStyleBackColor = false;
            this.inject.Click += new System.EventHandler(this.inject_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(635, 413);
            this.refresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(80, 33);
            this.refresh.TabIndex = 9;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // scripts
            // 
            this.scripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.scripts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scripts.ForeColor = System.Drawing.Color.White;
            this.scripts.FormattingEnabled = true;
            this.scripts.ItemHeight = 15;
            this.scripts.Location = new System.Drawing.Point(644, 62);
            this.scripts.Name = "scripts";
            this.scripts.Size = new System.Drawing.Size(144, 347);
            this.scripts.TabIndex = 11;
            this.scripts.SelectedIndexChanged += new System.EventHandler(this.scripts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(697, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Scripts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HolyInjector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scripts);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.inject);
            this.Controls.Add(this.savefile);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HolyInjector";
            this.Text = "HolyInjector";
            this.Load += new System.EventHandler(this.HolyInjector_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private Button min;
        private Button exit;
        private Button execute;
        private Button clear;
        private Button openfile;
        private Button savefile;
        private Button inject;
        private Button refresh;
        private ListBox scripts;
        private Label label1;
        private Label label2;
    }
}