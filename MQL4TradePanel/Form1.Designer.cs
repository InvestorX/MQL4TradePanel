namespace MQL4TradePanel
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buyBtn1 = new System.Windows.Forms.Button();
            this.sellBtn1 = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.getTeminal = new System.Windows.Forms.Button();
            this.bidTbx = new System.Windows.Forms.TextBox();
            this.askTbx = new System.Windows.Forms.TextBox();
            this.spTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.allCloseBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buyBtn1
            // 
            this.buyBtn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buyBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyBtn1.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buyBtn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buyBtn1.Location = new System.Drawing.Point(12, 408);
            this.buyBtn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyBtn1.Name = "buyBtn1";
            this.buyBtn1.Size = new System.Drawing.Size(192, 120);
            this.buyBtn1.TabIndex = 2;
            this.buyBtn1.Text = "SELL";
            this.buyBtn1.UseVisualStyleBackColor = false;
            this.buyBtn1.Click += new System.EventHandler(this.buyBtn1_Click);
            // 
            // sellBtn1
            // 
            this.sellBtn1.BackColor = System.Drawing.Color.Tomato;
            this.sellBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellBtn1.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sellBtn1.Location = new System.Drawing.Point(336, 408);
            this.sellBtn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sellBtn1.Name = "sellBtn1";
            this.sellBtn1.Size = new System.Drawing.Size(192, 120);
            this.sellBtn1.TabIndex = 3;
            this.sellBtn1.Text = "BUY";
            this.sellBtn1.UseVisualStyleBackColor = false;
            this.sellBtn1.Click += new System.EventHandler(this.sellBtn1_Click);
            // 
            // connect
            // 
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.connect.Location = new System.Drawing.Point(216, 12);
            this.connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(108, 51);
            this.connect.TabIndex = 0;
            this.connect.Text = "接続";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_ClickAsync);
            // 
            // disconnect
            // 
            this.disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnect.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.disconnect.Location = new System.Drawing.Point(420, 12);
            this.disconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(108, 51);
            this.disconnect.TabIndex = 1;
            this.disconnect.Text = "切断";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // getTeminal
            // 
            this.getTeminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getTeminal.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.getTeminal.Location = new System.Drawing.Point(12, 12);
            this.getTeminal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getTeminal.Name = "getTeminal";
            this.getTeminal.Size = new System.Drawing.Size(108, 51);
            this.getTeminal.TabIndex = 4;
            this.getTeminal.Text = "一覧取得";
            this.getTeminal.UseVisualStyleBackColor = true;
            this.getTeminal.Click += new System.EventHandler(this.getTeminal_Click);
            // 
            // bidTbx
            // 
            this.bidTbx.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bidTbx.Location = new System.Drawing.Point(12, 348);
            this.bidTbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bidTbx.Name = "bidTbx";
            this.bidTbx.Size = new System.Drawing.Size(190, 48);
            this.bidTbx.TabIndex = 5;
            this.bidTbx.Text = "12345.69";
            // 
            // askTbx
            // 
            this.askTbx.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.askTbx.Location = new System.Drawing.Point(336, 348);
            this.askTbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.askTbx.Name = "askTbx";
            this.askTbx.Size = new System.Drawing.Size(190, 48);
            this.askTbx.TabIndex = 5;
            this.askTbx.Text = "42198.68";
            this.askTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // spTbx
            // 
            this.spTbx.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.spTbx.Location = new System.Drawing.Point(216, 408);
            this.spTbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spTbx.Name = "spTbx";
            this.spTbx.Size = new System.Drawing.Size(94, 38);
            this.spTbx.TabIndex = 6;
            this.spTbx.Text = "10000";
            this.spTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bid(売注文)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(360, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ask(買注文)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(216, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Spread";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 84);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 48);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "通貨";
            // 
            // allCloseBtn
            // 
            this.allCloseBtn.BackColor = System.Drawing.SystemColors.Control;
            this.allCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allCloseBtn.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.allCloseBtn.Location = new System.Drawing.Point(216, 468);
            this.allCloseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allCloseBtn.Name = "allCloseBtn";
            this.allCloseBtn.Size = new System.Drawing.Size(108, 60);
            this.allCloseBtn.TabIndex = 11;
            this.allCloseBtn.Text = "全決済";
            this.allCloseBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "取引数量(Lots)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(216, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "▲";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(12, 192);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 48);
            this.button2.TabIndex = 14;
            this.button2.Text = "▼";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Meiryo UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(84, 192);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 41);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "50";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(72, 708);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 48);
            this.button3.TabIndex = 16;
            this.button3.Text = "+1";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.Location = new System.Drawing.Point(72, 768);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 48);
            this.button4.TabIndex = 17;
            this.button4.Text = "-1";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5.Location = new System.Drawing.Point(180, 768);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 48);
            this.button5.TabIndex = 19;
            this.button5.Text = "-5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6.Location = new System.Drawing.Point(180, 708);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 48);
            this.button6.TabIndex = 18;
            this.button6.Text = "+5";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button7.Location = new System.Drawing.Point(288, 768);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 48);
            this.button7.TabIndex = 21;
            this.button7.Text = "-10";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button8.Location = new System.Drawing.Point(288, 708);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 48);
            this.button8.TabIndex = 20;
            this.button8.Text = "+10";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(24, 552);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "SL(損切)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(192, 564);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "TP(利確)";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(372, 132);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 34);
            this.button9.TabIndex = 24;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 624);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 25);
            this.textBox2.TabIndex = 25;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(408, 224);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 26;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(542, 902);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.allCloseBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spTbx);
            this.Controls.Add(this.askTbx);
            this.Controls.Add(this.bidTbx);
            this.Controls.Add(this.getTeminal);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.sellBtn1);
            this.Controls.Add(this.buyBtn1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "激速注文 for MetaTrader @InvestorX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buyBtn1;
        private System.Windows.Forms.Button sellBtn1;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button getTeminal;
        private System.Windows.Forms.TextBox bidTbx;
        private System.Windows.Forms.TextBox askTbx;
        private System.Windows.Forms.TextBox spTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button allCloseBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button10;
    }
}

