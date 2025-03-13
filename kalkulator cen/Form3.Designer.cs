namespace kalkulator_cen
{
    partial class Form3
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
            label1 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 252);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 1;
            label1.Text = "Cena";
            // 
            // listView1
            // 
            listView1.Location = new Point(313, 51);
            listView1.Name = "listView1";
            listView1.Size = new Size(182, 146);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(257, 319);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(467, 252);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(507, 252);
            label3.Name = "label3";
            label3.Size = new Size(25, 25);
            label3.TabIndex = 6;
            label3.Text = "zł";
            // 
            // button2
            // 
            button2.Location = new Point(435, 319);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "anuluj";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}