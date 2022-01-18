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
            this.SuspendLayout();
            // 
            // buyBtn1
            // 
            this.buyBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyBtn1.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buyBtn1.Location = new System.Drawing.Point(12, 92);
            this.buyBtn1.Name = "buyBtn1";
            this.buyBtn1.Size = new System.Drawing.Size(107, 40);
            this.buyBtn1.TabIndex = 2;
            this.buyBtn1.Text = "button1";
            this.buyBtn1.UseVisualStyleBackColor = true;
            this.buyBtn1.Click += new System.EventHandler(this.buyBtn1_Click);
            // 
            // sellBtn1
            // 
            this.sellBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellBtn1.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sellBtn1.Location = new System.Drawing.Point(134, 92);
            this.sellBtn1.Name = "sellBtn1";
            this.sellBtn1.Size = new System.Drawing.Size(107, 40);
            this.sellBtn1.TabIndex = 3;
            this.sellBtn1.Text = "button2";
            this.sellBtn1.UseVisualStyleBackColor = true;
            this.sellBtn1.Click += new System.EventHandler(this.sellBtn1_Click);
            // 
            // connect
            // 
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.connect.Location = new System.Drawing.Point(90, 12);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(72, 34);
            this.connect.TabIndex = 0;
            this.connect.Text = "接続";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_ClickAsync);
            // 
            // disconnect
            // 
            this.disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnect.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.disconnect.Location = new System.Drawing.Point(169, 12);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(72, 34);
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
            this.getTeminal.Name = "getTeminal";
            this.getTeminal.Size = new System.Drawing.Size(72, 34);
            this.getTeminal.TabIndex = 4;
            this.getTeminal.Text = "一覧取得";
            this.getTeminal.UseVisualStyleBackColor = true;
            this.getTeminal.Click += new System.EventHandler(this.getTeminal_Click);
            // 
            // bidTbx
            // 
            this.bidTbx.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bidTbx.Location = new System.Drawing.Point(12, 52);
            this.bidTbx.Name = "bidTbx";
            this.bidTbx.Size = new System.Drawing.Size(107, 34);
            this.bidTbx.TabIndex = 5;
            // 
            // askTbx
            // 
            this.askTbx.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.askTbx.Location = new System.Drawing.Point(134, 52);
            this.askTbx.Name = "askTbx";
            this.askTbx.Size = new System.Drawing.Size(107, 34);
            this.askTbx.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.askTbx);
            this.Controls.Add(this.bidTbx);
            this.Controls.Add(this.getTeminal);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.sellBtn1);
            this.Controls.Add(this.buyBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

