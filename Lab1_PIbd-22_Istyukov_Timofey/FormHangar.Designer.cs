
namespace Lab1_PIbd_22_Istyukov_Timofey
{
    partial class FormHangar
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
            this.pictureBoxHangar = new System.Windows.Forms.PictureBox();
            this.buttonSetWarPlane_Click = new System.Windows.Forms.Button();
            this.buttonSetFighterPlane_Click = new System.Windows.Forms.Button();
            this.buttonTakeAir_Clic = new System.Windows.Forms.Button();
            this.labelIndex = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxTakeAir = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            this.groupBoxTakeAir.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxHangar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(735, 455);
            this.pictureBoxHangar.TabIndex = 1;
            this.pictureBoxHangar.TabStop = false;
            // 
            // buttonSetWarPlane_Click
            // 
            this.buttonSetWarPlane_Click.Location = new System.Drawing.Point(743, 11);
            this.buttonSetWarPlane_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetWarPlane_Click.Name = "buttonSetWarPlane_Click";
            this.buttonSetWarPlane_Click.Size = new System.Drawing.Size(137, 39);
            this.buttonSetWarPlane_Click.TabIndex = 8;
            this.buttonSetWarPlane_Click.Text = "Припарковать военный самолёт";
            this.buttonSetWarPlane_Click.UseVisualStyleBackColor = true;
            this.buttonSetWarPlane_Click.Click += new System.EventHandler(this.buttonSetWarPlane_Click_Click);
            // 
            // buttonSetFighterPlane_Click
            // 
            this.buttonSetFighterPlane_Click.Location = new System.Drawing.Point(743, 54);
            this.buttonSetFighterPlane_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetFighterPlane_Click.Name = "buttonSetFighterPlane_Click";
            this.buttonSetFighterPlane_Click.Size = new System.Drawing.Size(137, 37);
            this.buttonSetFighterPlane_Click.TabIndex = 9;
            this.buttonSetFighterPlane_Click.Text = "Припарковать истребитель";
            this.buttonSetFighterPlane_Click.UseVisualStyleBackColor = true;
            this.buttonSetFighterPlane_Click.Click += new System.EventHandler(this.buttonSetFighterPlane_Click_Click_1);
            // 
            // buttonTakeAir_Clic
            // 
            this.buttonTakeAir_Clic.Location = new System.Drawing.Point(5, 48);
            this.buttonTakeAir_Clic.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTakeAir_Clic.Name = "buttonTakeAir_Clic";
            this.buttonTakeAir_Clic.Size = new System.Drawing.Size(127, 26);
            this.buttonTakeAir_Clic.TabIndex = 13;
            this.buttonTakeAir_Clic.Text = "Забрать";
            this.buttonTakeAir_Clic.UseVisualStyleBackColor = true;
            this.buttonTakeAir_Clic.Click += new System.EventHandler(this.buttonTakeAir_Clic_Click_1);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIndex.Location = new System.Drawing.Point(23, 24);
            this.labelIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(52, 16);
            this.labelIndex.TabIndex = 12;
            this.labelIndex.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(79, 24);
            this.maskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(32, 20);
            this.maskedTextBox.TabIndex = 11;
            // 
            // groupBoxTakeAir
            // 
            this.groupBoxTakeAir.Controls.Add(this.labelIndex);
            this.groupBoxTakeAir.Controls.Add(this.buttonTakeAir_Clic);
            this.groupBoxTakeAir.Controls.Add(this.maskedTextBox);
            this.groupBoxTakeAir.Location = new System.Drawing.Point(743, 106);
            this.groupBoxTakeAir.Name = "groupBoxTakeAir";
            this.groupBoxTakeAir.Size = new System.Drawing.Size(137, 79);
            this.groupBoxTakeAir.TabIndex = 14;
            this.groupBoxTakeAir.TabStop = false;
            this.groupBoxTakeAir.Text = "Забрать самолёт";
            // 
            // FormHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBoxTakeAir);
            this.Controls.Add(this.buttonSetFighterPlane_Click);
            this.Controls.Add(this.buttonSetWarPlane_Click);
            this.Controls.Add(this.pictureBoxHangar);
            this.Name = "FormHangar";
            this.Text = "Ангар";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            this.groupBoxTakeAir.ResumeLayout(false);
            this.groupBoxTakeAir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangar;
        private System.Windows.Forms.Button buttonSetWarPlane_Click;
        private System.Windows.Forms.Button buttonSetFighterPlane_Click;
        private System.Windows.Forms.Button buttonTakeAir_Clic;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.GroupBox groupBoxTakeAir;
    }
}