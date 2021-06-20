
using System.Configuration;

namespace HelloWorld
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
            this.enqueue = new System.Windows.Forms.Button();
            this.EnqueueMessage = new System.Windows.Forms.TextBox();
            this.queue1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DequeueMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.queue2 = new System.Windows.Forms.TextBox();
            this.dequeue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectionText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.consumerText = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enqueue
            // 
            this.enqueue.Location = new System.Drawing.Point(427, 248);
            this.enqueue.Name = "enqueue";
            this.enqueue.Size = new System.Drawing.Size(75, 23);
            this.enqueue.TabIndex = 0;
            this.enqueue.Text = "Enqueue";
            this.enqueue.UseVisualStyleBackColor = true;
            this.enqueue.Click += new System.EventHandler(this.enqueue_Click);
            // 
            // EnqueueMessage
            // 
            this.EnqueueMessage.Location = new System.Drawing.Point(119, 166);
            this.EnqueueMessage.Multiline = true;
            this.EnqueueMessage.Name = "EnqueueMessage";
            this.EnqueueMessage.Size = new System.Drawing.Size(277, 105);
            this.EnqueueMessage.TabIndex = 2;
            this.EnqueueMessage.Text = ConfigurationManager.AppSettings["message"];
            // 
            // queue1
            // 
            this.queue1.Location = new System.Drawing.Point(478, 166);
            this.queue1.Name = "queue1";
            this.queue1.Size = new System.Drawing.Size(166, 20);
            this.queue1.TabIndex = 3;
            this.queue1.Text = ConfigurationManager.AppSettings["queue1"];
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Queue";
            // 
            // DequeueMessage
            // 
            this.DequeueMessage.Location = new System.Drawing.Point(119, 317);
            this.DequeueMessage.Multiline = true;
            this.DequeueMessage.Name = "DequeueMessage";
            this.DequeueMessage.Size = new System.Drawing.Size(277, 105);
            this.DequeueMessage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Queue";
            // 
            // queue2
            // 
            this.queue2.Location = new System.Drawing.Point(478, 320);
            this.queue2.Name = "queue2";
            this.queue2.Size = new System.Drawing.Size(166, 20);
            this.queue2.TabIndex = 7;
            this.queue2.Text = ConfigurationManager.AppSettings["queue2"];
            // 
            // dequeue
            // 
            this.dequeue.Location = new System.Drawing.Point(427, 399);
            this.dequeue.Name = "dequeue";
            this.dequeue.Size = new System.Drawing.Size(75, 23);
            this.dequeue.TabIndex = 8;
            this.dequeue.Text = "Dequeue";
            this.dequeue.UseVisualStyleBackColor = true;
            this.dequeue.Click += new System.EventHandler(this.dequeue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Connection";
            // 
            // ConnectionText
            // 
            this.ConnectionText.Location = new System.Drawing.Point(208, 40);
            this.ConnectionText.Name = "ConnectionText";
            this.ConnectionText.Size = new System.Drawing.Size(436, 20);
            this.ConnectionText.TabIndex = 10;
            this.ConnectionText.Text = ConfigurationManager.AppSettings["connection"];
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Consumer";
            // 
            // consumerText
            // 
            this.consumerText.Location = new System.Drawing.Point(208, 98);
            this.consumerText.Name = "consumerText";
            this.consumerText.Size = new System.Drawing.Size(100, 20);
            this.consumerText.TabIndex = 12;
            this.consumerText.Text = ConfigurationManager.AppSettings["consumer"];
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.consumerText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConnectionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dequeue);
            this.Controls.Add(this.queue2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DequeueMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queue1);
            this.Controls.Add(this.EnqueueMessage);
            this.Controls.Add(this.enqueue);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "qiinjector19c";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enqueue;
        private System.Windows.Forms.TextBox EnqueueMessage;
        private System.Windows.Forms.TextBox queue1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DequeueMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox queue2;
        private System.Windows.Forms.Button dequeue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConnectionText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox consumerText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

