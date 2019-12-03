namespace ProxyChanger
{
   partial class Form1
   {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다. 
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
      /// </summary>
      private void InitializeComponent()
      {
         this.treeView1 = new System.Windows.Forms.TreeView();
         this.btn_del = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.tb_proxyyAdd = new System.Windows.Forms.TextBox();
         this.btn_add = new System.Windows.Forms.Button();
         this.cb_proxyUse = new System.Windows.Forms.CheckBox();
         this.btn_getProxy = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.btn_proxyUse = new System.Windows.Forms.Button();
         this.btn_dataSave = new System.Windows.Forms.Button();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.button1 = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.tb_mainProxy = new System.Windows.Forms.TextBox();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // treeView1
         // 
         this.treeView1.Location = new System.Drawing.Point(23, 36);
         this.treeView1.Name = "treeView1";
         this.treeView1.Size = new System.Drawing.Size(341, 431);
         this.treeView1.TabIndex = 0;
         this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
         // 
         // btn_del
         // 
         this.btn_del.Location = new System.Drawing.Point(389, 291);
         this.btn_del.Name = "btn_del";
         this.btn_del.Size = new System.Drawing.Size(266, 53);
         this.btn_del.TabIndex = 1;
         this.btn_del.Text = "선택 삭제";
         this.btn_del.UseVisualStyleBackColor = true;
         this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(378, 140);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(89, 17);
         this.label1.TabIndex = 2;
         this.label1.Text = "Address:port";
         // 
         // tb_proxyyAdd
         // 
         this.tb_proxyyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tb_proxyyAdd.Location = new System.Drawing.Point(389, 170);
         this.tb_proxyyAdd.Name = "tb_proxyyAdd";
         this.tb_proxyyAdd.Size = new System.Drawing.Size(266, 27);
         this.tb_proxyyAdd.TabIndex = 3;
         // 
         // btn_add
         // 
         this.btn_add.Location = new System.Drawing.Point(389, 214);
         this.btn_add.Name = "btn_add";
         this.btn_add.Size = new System.Drawing.Size(266, 56);
         this.btn_add.TabIndex = 4;
         this.btn_add.Text = "추가";
         this.btn_add.UseVisualStyleBackColor = true;
         this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
         // 
         // cb_proxyUse
         // 
         this.cb_proxyUse.AutoSize = true;
         this.cb_proxyUse.Location = new System.Drawing.Point(23, 32);
         this.cb_proxyUse.Name = "cb_proxyUse";
         this.cb_proxyUse.Size = new System.Drawing.Size(102, 21);
         this.cb_proxyUse.TabIndex = 5;
         this.cb_proxyUse.Text = "Proxy Use?";
         this.cb_proxyUse.UseVisualStyleBackColor = true;
         this.cb_proxyUse.CheckedChanged += new System.EventHandler(this.cb_proxyUse_CheckedChanged);
         // 
         // btn_getProxy
         // 
         this.btn_getProxy.Location = new System.Drawing.Point(388, 79);
         this.btn_getProxy.Name = "btn_getProxy";
         this.btn_getProxy.Size = new System.Drawing.Size(266, 47);
         this.btn_getProxy.TabIndex = 6;
         this.btn_getProxy.Text = "현재 사용중인 프록시 LOAD";
         this.btn_getProxy.UseVisualStyleBackColor = true;
         this.btn_getProxy.Click += new System.EventHandler(this.btn_getProxy_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.btn_proxyUse);
         this.groupBox1.Controls.Add(this.btn_dataSave);
         this.groupBox1.Controls.Add(this.treeView1);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.btn_del);
         this.groupBox1.Controls.Add(this.tb_proxyyAdd);
         this.groupBox1.Controls.Add(this.btn_add);
         this.groupBox1.Location = new System.Drawing.Point(12, 155);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(677, 488);
         this.groupBox1.TabIndex = 7;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Setting";
         // 
         // btn_proxyUse
         // 
         this.btn_proxyUse.Location = new System.Drawing.Point(389, 36);
         this.btn_proxyUse.Name = "btn_proxyUse";
         this.btn_proxyUse.Size = new System.Drawing.Size(266, 53);
         this.btn_proxyUse.TabIndex = 8;
         this.btn_proxyUse.Text = "선택 사용";
         this.btn_proxyUse.UseVisualStyleBackColor = true;
         this.btn_proxyUse.Click += new System.EventHandler(this.btn_proxyUse_Click);
         // 
         // btn_dataSave
         // 
         this.btn_dataSave.Location = new System.Drawing.Point(389, 411);
         this.btn_dataSave.Name = "btn_dataSave";
         this.btn_dataSave.Size = new System.Drawing.Size(266, 56);
         this.btn_dataSave.TabIndex = 7;
         this.btn_dataSave.Text = "프록시 정보 SAVE";
         this.btn_dataSave.UseVisualStyleBackColor = true;
         this.btn_dataSave.Click += new System.EventHandler(this.button1_Click);
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.button1);
         this.groupBox2.Controls.Add(this.label2);
         this.groupBox2.Controls.Add(this.tb_mainProxy);
         this.groupBox2.Controls.Add(this.btn_getProxy);
         this.groupBox2.Controls.Add(this.cb_proxyUse);
         this.groupBox2.Location = new System.Drawing.Point(13, 13);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(676, 136);
         this.groupBox2.TabIndex = 8;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Information";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(388, 21);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(266, 47);
         this.button1.TabIndex = 9;
         this.button1.Text = "제어판-인터넷 설정 열기";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click_1);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(19, 64);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(89, 17);
         this.label2.TabIndex = 6;
         this.label2.Text = "Address:port";
         // 
         // tb_mainProxy
         // 
         this.tb_mainProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tb_mainProxy.Location = new System.Drawing.Point(22, 84);
         this.tb_mainProxy.Name = "tb_mainProxy";
         this.tb_mainProxy.ReadOnly = true;
         this.tb_mainProxy.Size = new System.Drawing.Size(341, 27);
         this.tb_mainProxy.TabIndex = 7;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(703, 656);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Proxy Changer";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TreeView treeView1;
      private System.Windows.Forms.Button btn_del;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox tb_proxyyAdd;
      private System.Windows.Forms.Button btn_add;
      private System.Windows.Forms.CheckBox cb_proxyUse;
      private System.Windows.Forms.Button btn_getProxy;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button btn_dataSave;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox tb_mainProxy;
      private System.Windows.Forms.Button btn_proxyUse;
      private System.Windows.Forms.Button button1;
   }
}

