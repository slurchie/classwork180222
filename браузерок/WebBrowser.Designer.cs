
namespace браузерок
{
    partial class WebBrowser
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("09-121");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Тальдаева");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Конышева");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Захарова");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("09-122", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("группы", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode11});
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.browser = new System.Windows.Forms.Button();
            this.нижнийслой = new System.Windows.Forms.SplitContainer();
            this.верхнийконтейнер = new System.Windows.Forms.SplitContainer();
            this.дерево1шаг = new System.Windows.Forms.TreeView();
            this.напёрдыш = new System.Windows.Forms.PictureBox();
            this.нижняятабл = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.нижнийслой)).BeginInit();
            this.нижнийслой.Panel1.SuspendLayout();
            this.нижнийслой.Panel2.SuspendLayout();
            this.нижнийслой.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.верхнийконтейнер)).BeginInit();
            this.верхнийконтейнер.Panel1.SuspendLayout();
            this.верхнийконтейнер.Panel2.SuspendLayout();
            this.верхнийконтейнер.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.напёрдыш)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нижняятабл)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem2.Text = "View";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(49, 24);
            this.toolStripMenuItem3.Text = "Edit";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 422);
            this.webBrowser1.TabIndex = 3;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 28);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(800, 422);
            this.webBrowser2.TabIndex = 6;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(0, 28);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(800, 422);
            this.webBrowser3.TabIndex = 7;
            // 
            // browser
            // 
            this.browser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.browser.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.browser.Location = new System.Drawing.Point(152, 0);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(114, 28);
            this.browser.TabIndex = 9;
            this.browser.Text = "WebBrowser";
            this.browser.UseVisualStyleBackColor = false;
            this.browser.Click += new System.EventHandler(this.browser_Click);
            // 
            // нижнийслой
            // 
            this.нижнийслой.Location = new System.Drawing.Point(12, 28);
            this.нижнийслой.Name = "нижнийслой";
            this.нижнийслой.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // нижнийслой.Panel1
            // 
            this.нижнийслой.Panel1.Controls.Add(this.верхнийконтейнер);
            // 
            // нижнийслой.Panel2
            // 
            this.нижнийслой.Panel2.Controls.Add(this.нижняятабл);
            this.нижнийслой.Size = new System.Drawing.Size(788, 414);
            this.нижнийслой.SplitterDistance = 207;
            this.нижнийслой.TabIndex = 10;
            // 
            // верхнийконтейнер
            // 
            this.верхнийконтейнер.Location = new System.Drawing.Point(0, 0);
            this.верхнийконтейнер.Name = "верхнийконтейнер";
            // 
            // верхнийконтейнер.Panel1
            // 
            this.верхнийконтейнер.Panel1.Controls.Add(this.дерево1шаг);
            // 
            // верхнийконтейнер.Panel2
            // 
            this.верхнийконтейнер.Panel2.Controls.Add(this.напёрдыш);
            this.верхнийконтейнер.Size = new System.Drawing.Size(788, 207);
            this.верхнийконтейнер.SplitterDistance = 278;
            this.верхнийконтейнер.TabIndex = 0;
            // 
            // дерево1шаг
            // 
            this.дерево1шаг.Location = new System.Drawing.Point(19, 28);
            this.дерево1шаг.Name = "дерево1шаг";
            treeNode7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            treeNode7.Name = "09-121";
            treeNode7.Text = "09-121";
            treeNode8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNode8.Name = "Тальдаева";
            treeNode8.Text = "Тальдаева";
            treeNode9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNode9.Name = "Конышева";
            treeNode9.Text = "Конышева";
            treeNode10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNode10.Name = "Захарова";
            treeNode10.Text = "Захарова";
            treeNode11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            treeNode11.Name = "09-122";
            treeNode11.Text = "09-122";
            treeNode12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            treeNode12.Name = "группы";
            treeNode12.Text = "группы";
            this.дерево1шаг.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.дерево1шаг.Size = new System.Drawing.Size(219, 129);
            this.дерево1шаг.TabIndex = 0;
            // 
            // напёрдыш
            // 
            this.напёрдыш.Dock = System.Windows.Forms.DockStyle.Fill;
            this.напёрдыш.Image = global::браузерок.Properties.Resources.maxresdefault1;
            this.напёрдыш.Location = new System.Drawing.Point(0, 0);
            this.напёрдыш.Name = "напёрдыш";
            this.напёрдыш.Size = new System.Drawing.Size(506, 207);
            this.напёрдыш.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.напёрдыш.TabIndex = 0;
            this.напёрдыш.TabStop = false;
            // 
            // нижняятабл
            // 
            this.нижняятабл.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.нижняятабл.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.нижняятабл.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.нижняятабл.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.нижняятабл.ColumnHeadersHeight = 29;
            this.нижняятабл.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.age,
            this.description});
            this.нижняятабл.Location = new System.Drawing.Point(19, 3);
            this.нижняятабл.Name = "нижняятабл";
            this.нижняятабл.RowHeadersWidth = 51;
            this.нижняятабл.RowTemplate.Height = 24;
            this.нижняятабл.Size = new System.Drawing.Size(757, 150);
            this.нижняятабл.TabIndex = 0;
        
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // age
            // 
            this.age.HeaderText = "age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.нижнийслой);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WebBrowser";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.нижнийслой.Panel1.ResumeLayout(false);
            this.нижнийслой.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.нижнийслой)).EndInit();
            this.нижнийслой.ResumeLayout(false);
            this.верхнийконтейнер.Panel1.ResumeLayout(false);
            this.верхнийконтейнер.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.верхнийконтейнер)).EndInit();
            this.верхнийконтейнер.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.напёрдыш)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нижняятабл)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.Button browser;
        private System.Windows.Forms.SplitContainer нижнийслой;
        private System.Windows.Forms.SplitContainer верхнийконтейнер;
        private System.Windows.Forms.PictureBox напёрдыш;
        private System.Windows.Forms.TreeView дерево1шаг;
        private System.Windows.Forms.DataGridView нижняятабл;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}

