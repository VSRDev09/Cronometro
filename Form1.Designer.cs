namespace Cronometro
{
    partial class Cronometro
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
            components = new System.ComponentModel.Container();
            botaoOval1 = new BotaoOval();
            botaoOval2 = new BotaoOval();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            botaoOval3 = new BotaoOval();
            SuspendLayout();
            // 
            // botaoOval1
            // 
            botaoOval1.Location = new Point(219, 441);
            botaoOval1.Margin = new Padding(4);
            botaoOval1.Name = "botaoOval1";
            botaoOval1.Size = new Size(141, 67);
            botaoOval1.TabIndex = 0;
            botaoOval1.Text = "Iniciar";
            botaoOval1.UseVisualStyleBackColor = true;
            botaoOval1.Click += botaoOval1_Click_1;
            // 
            // botaoOval2
            // 
            botaoOval2.Location = new Point(59, 441);
            botaoOval2.Margin = new Padding(4);
            botaoOval2.Name = "botaoOval2";
            botaoOval2.Size = new Size(141, 67);
            botaoOval2.TabIndex = 1;
            botaoOval2.Text = "Restaurar";
            botaoOval2.UseVisualStyleBackColor = true;
            botaoOval2.Click += botaoOval2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(360, 76);
            label1.TabIndex = 2;
            label1.Text = "00:00:00";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // botaoOval3
            // 
            botaoOval3.Location = new Point(134, 367);
            botaoOval3.Margin = new Padding(4);
            botaoOval3.Name = "botaoOval3";
            botaoOval3.Size = new Size(148, 55);
            botaoOval3.TabIndex = 3;
            botaoOval3.Text = "Alterar modo";
            botaoOval3.UseVisualStyleBackColor = true;
            botaoOval3.Click += botaoOval3_Click;
            // 
            // Cronometro
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(412, 546);
            Controls.Add(botaoOval3);
            Controls.Add(label1);
            Controls.Add(botaoOval2);
            Controls.Add(botaoOval1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Cronometro";
            Text = "Cronometro";
            Load += Cronometro_Load;
            ResumeLayout(false);
        }

        #endregion

        private BotaoOval botaoOval1;
        private BotaoOval botaoOval2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private BotaoOval botaoOval3;
    }
}
