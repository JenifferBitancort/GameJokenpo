namespace _20___Game_Jokenpo
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
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonTesoura = new System.Windows.Forms.Button();
            this.buttonpapel = new System.Windows.Forms.Button();
            this.buttonPedra = new System.Windows.Forms.Button();
            this.picresultado = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picresultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(37, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(702, 87);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Escolha: Pedra, Papel ou Tesoura...";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(40, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Você";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(237, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "vs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(300, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "PC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(497, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResultado
            // 
            this.labelResultado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelResultado.Location = new System.Drawing.Point(562, 193);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(177, 46);
            this.labelResultado.TabIndex = 8;
            this.labelResultado.Text = "?";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTesoura
            // 
            this.buttonTesoura.BackgroundImage = global::_20___Game_Jokenpo.Properties.Resources.tes;
            this.buttonTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTesoura.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTesoura.Location = new System.Drawing.Point(551, 334);
            this.buttonTesoura.Name = "buttonTesoura";
            this.buttonTesoura.Size = new System.Drawing.Size(200, 200);
            this.buttonTesoura.TabIndex = 11;
            this.buttonTesoura.UseVisualStyleBackColor = true;
            this.buttonTesoura.Click += new System.EventHandler(this.buttonTesoura_Click);
            // 
            // buttonpapel
            // 
            this.buttonpapel.BackgroundImage = global::_20___Game_Jokenpo.Properties.Resources.pap;
            this.buttonpapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonpapel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpapel.Location = new System.Drawing.Point(291, 334);
            this.buttonpapel.Name = "buttonpapel";
            this.buttonpapel.Size = new System.Drawing.Size(200, 200);
            this.buttonpapel.TabIndex = 10;
            this.buttonpapel.UseVisualStyleBackColor = true;
            this.buttonpapel.Click += new System.EventHandler(this.buttonpapel_Click);
            // 
            // buttonPedra
            // 
            this.buttonPedra.BackgroundImage = global::_20___Game_Jokenpo.Properties.Resources.ped;
            this.buttonPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPedra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPedra.Location = new System.Drawing.Point(31, 334);
            this.buttonPedra.Name = "buttonPedra";
            this.buttonPedra.Size = new System.Drawing.Size(200, 200);
            this.buttonPedra.TabIndex = 9;
            this.buttonPedra.UseVisualStyleBackColor = true;
            this.buttonPedra.Click += new System.EventHandler(this.buttonPedra_Click);
            // 
            // picresultado
            // 
            this.picresultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picresultado.Location = new System.Drawing.Point(551, 116);
            this.picresultado.Name = "picresultado";
            this.picresultado.Size = new System.Drawing.Size(200, 200);
            this.picresultado.TabIndex = 3;
            this.picresultado.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(291, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(31, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 575);
            this.Controls.Add(this.buttonTesoura);
            this.Controls.Add(this.buttonpapel);
            this.Controls.Add(this.buttonPedra);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picresultado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picresultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picresultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonPedra;
        private System.Windows.Forms.Button buttonpapel;
        private System.Windows.Forms.Button buttonTesoura;
    }
}

