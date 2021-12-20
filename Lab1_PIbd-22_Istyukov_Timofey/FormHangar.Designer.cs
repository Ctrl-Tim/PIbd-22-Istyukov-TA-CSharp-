
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
            this.buttonTakeAir_Clic = new System.Windows.Forms.Button();
            this.labelIndex = new System.Windows.Forms.Label();
            this.groupBoxTakeAir = new System.Windows.Forms.GroupBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddHangar_Click = new System.Windows.Forms.Button();
            this.listBoxHangars = new System.Windows.Forms.ListBox();
            this.buttonDelHangar_Click = new System.Windows.Forms.Button();
            this.buttonSetAir_Click = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            this.groupBoxTakeAir.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.Location = new System.Drawing.Point(4, 29);
            this.pictureBoxHangar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(735, 429);
            this.pictureBoxHangar.TabIndex = 1;
            this.pictureBoxHangar.TabStop = false;
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
            // groupBoxTakeAir
            // 
            this.groupBoxTakeAir.Controls.Add(this.maskedTextBox);
            this.groupBoxTakeAir.Controls.Add(this.labelIndex);
            this.groupBoxTakeAir.Controls.Add(this.buttonTakeAir_Clic);
            this.groupBoxTakeAir.Location = new System.Drawing.Point(744, 367);
            this.groupBoxTakeAir.Name = "groupBoxTakeAir";
            this.groupBoxTakeAir.Size = new System.Drawing.Size(137, 88);
            this.groupBoxTakeAir.TabIndex = 14;
            this.groupBoxTakeAir.TabStop = false;
            this.groupBoxTakeAir.Text = "Забрать самолёт";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(79, 22);
            this.maskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(32, 20);
            this.maskedTextBox.TabIndex = 22;
            // 
            // buttonAddHangar_Click
            // 
            this.buttonAddHangar_Click.Location = new System.Drawing.Point(743, 77);
            this.buttonAddHangar_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddHangar_Click.Name = "buttonAddHangar_Click";
            this.buttonAddHangar_Click.Size = new System.Drawing.Size(137, 20);
            this.buttonAddHangar_Click.TabIndex = 17;
            this.buttonAddHangar_Click.Text = "Добавить ангар";
            this.buttonAddHangar_Click.UseVisualStyleBackColor = true;
            this.buttonAddHangar_Click.Click += new System.EventHandler(this.buttonAddHangar_Click_Click);
            // 
            // listBoxHangars
            // 
            this.listBoxHangars.FormattingEnabled = true;
            this.listBoxHangars.Location = new System.Drawing.Point(743, 101);
            this.listBoxHangars.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxHangars.Name = "listBoxHangars";
            this.listBoxHangars.Size = new System.Drawing.Size(138, 82);
            this.listBoxHangars.TabIndex = 18;
            this.listBoxHangars.SelectedIndexChanged += new System.EventHandler(this.listBoxHangars_SelectedIndexChanged);
            // 
            // buttonDelHangar_Click
            // 
            this.buttonDelHangar_Click.Location = new System.Drawing.Point(743, 187);
            this.buttonDelHangar_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelHangar_Click.Name = "buttonDelHangar_Click";
            this.buttonDelHangar_Click.Size = new System.Drawing.Size(137, 20);
            this.buttonDelHangar_Click.TabIndex = 19;
            this.buttonDelHangar_Click.Text = "Удалить ангар";
            this.buttonDelHangar_Click.UseVisualStyleBackColor = true;
            this.buttonDelHangar_Click.Click += new System.EventHandler(this.buttonDelHangar_Click_Click);
            // 
            // buttonSetAir_Click
            // 
            this.buttonSetAir_Click.Location = new System.Drawing.Point(743, 310);
            this.buttonSetAir_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetAir_Click.Name = "buttonSetAir_Click";
            this.buttonSetAir_Click.Size = new System.Drawing.Size(137, 39);
            this.buttonSetAir_Click.TabIndex = 20;
            this.buttonSetAir_Click.Text = "Добавить самолёт";
            this.buttonSetAir_Click.UseVisualStyleBackColor = true;
            this.buttonSetAir_Click.Click += new System.EventHandler(this.buttonSetAir_Click_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(783, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ангары:";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(743, 51);
            this.textBoxNewLevelName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(138, 20);
            this.textBoxNewLevelName.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click_1);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click_1);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "saveFileDialog";
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort_Click
            // 
            this.buttonSort_Click.Location = new System.Drawing.Point(743, 239);
            this.buttonSort_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSort_Click.Name = "buttonSort_Click";
            this.buttonSort_Click.Size = new System.Drawing.Size(137, 39);
            this.buttonSort_Click.TabIndex = 24;
            this.buttonSort_Click.Text = "Сортировать";
            this.buttonSort_Click.UseVisualStyleBackColor = true;
            this.buttonSort_Click.Click += new System.EventHandler(this.buttonSort_Click_Click);
            // 
            // FormHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonSort_Click);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSetAir_Click);
            this.Controls.Add(this.buttonDelHangar_Click);
            this.Controls.Add(this.listBoxHangars);
            this.Controls.Add(this.buttonAddHangar_Click);
            this.Controls.Add(this.groupBoxTakeAir);
            this.Controls.Add(this.pictureBoxHangar);
            this.Name = "FormHangar";
            this.Text = "Ангар";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            this.groupBoxTakeAir.ResumeLayout(false);
            this.groupBoxTakeAir.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangar;
        private System.Windows.Forms.Button buttonTakeAir_Clic;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.GroupBox groupBoxTakeAir;
        private System.Windows.Forms.Button buttonAddHangar_Click;
        private System.Windows.Forms.ListBox listBoxHangars;
        private System.Windows.Forms.Button buttonDelHangar_Click;
        private System.Windows.Forms.Button buttonSetAir_Click;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.MaskedTextBox textBoxNewLevelName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort_Click;
    }
}