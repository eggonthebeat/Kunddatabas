
namespace Kunddatabas
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bert = new System.Windows.Forms.TableLayoutPanel();
            this.Add = new System.Windows.Forms.Button();
            this.postadress = new System.Windows.Forms.TextBox();
            this.distributionstyp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gatuadress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.namn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabort = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Återställ Databas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sök på namn, adress, distributiontyp eller epost";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 21);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sök";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Namn",
            "Gatuadress",
            "Postadress",
            "Distributionstyp"});
            this.comboBox1.Location = new System.Drawing.Point(239, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Namn";
            // 
            // bert
            // 
            this.bert.BackColor = System.Drawing.Color.White;
            this.bert.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.bert.ColumnCount = 4;
            this.bert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bert.Location = new System.Drawing.Point(32, 198);
            this.bert.Name = "bert";
            this.bert.RowCount = 2;
            this.bert.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bert.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bert.Size = new System.Drawing.Size(447, 240);
            this.bert.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(32, 103);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(201, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Lägg till kund";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // postadress
            // 
            this.postadress.Location = new System.Drawing.Point(239, 71);
            this.postadress.Name = "postadress";
            this.postadress.Size = new System.Drawing.Size(74, 20);
            this.postadress.TabIndex = 1;
            this.postadress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // distributionstyp
            // 
            this.distributionstyp.FormattingEnabled = true;
            this.distributionstyp.Items.AddRange(new object[] {
            "Kivra",
            "Email",
            "Post",
            "Efaktura"});
            this.distributionstyp.Location = new System.Drawing.Point(239, 22);
            this.distributionstyp.Name = "distributionstyp";
            this.distributionstyp.Size = new System.Drawing.Size(74, 21);
            this.distributionstyp.TabIndex = 10;
            this.distributionstyp.Text = "Efaktura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Distributionstyp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Postadress";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gatuadress
            // 
            this.gatuadress.Location = new System.Drawing.Point(32, 71);
            this.gatuadress.Name = "gatuadress";
            this.gatuadress.Size = new System.Drawing.Size(192, 20);
            this.gatuadress.TabIndex = 1;
            this.gatuadress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gatuadress";
            // 
            // namn
            // 
            this.namn.Location = new System.Drawing.Point(32, 23);
            this.namn.Name = "namn";
            this.namn.Size = new System.Drawing.Size(192, 20);
            this.namn.TabIndex = 1;
            this.namn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Namn";
            // 
            // tabort
            // 
            this.tabort.Location = new System.Drawing.Point(414, 71);
            this.tabort.Name = "tabort";
            this.tabort.Size = new System.Drawing.Size(84, 20);
            this.tabort.TabIndex = 0;
            this.tabort.Text = "Ta bort kund";
            this.tabort.UseVisualStyleBackColor = true;
            this.tabort.Click += new System.EventHandler(this.tabort_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(366, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.distributionstyp);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.bert);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namn);
            this.Controls.Add(this.gatuadress);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.postadress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabort);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel bert;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox postadress;
        private System.Windows.Forms.ComboBox distributionstyp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gatuadress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox namn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tabort;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}

