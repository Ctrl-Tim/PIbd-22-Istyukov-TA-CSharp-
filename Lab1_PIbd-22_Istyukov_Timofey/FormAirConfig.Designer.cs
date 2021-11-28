
namespace Lab1_PIbd_22_Istyukov_Timofey
{
    partial class FormAirConfig
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
            this.groupBoxAir = new System.Windows.Forms.GroupBox();
            this.labelFighterPlane = new System.Windows.Forms.Label();
            this.labelWarPlane = new System.Windows.Forms.Label();
            this.panelAir = new System.Windows.Forms.Panel();
            this.pictureBoxAir = new System.Windows.Forms.PictureBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.panelNavy = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxMiniBombs = new System.Windows.Forms.CheckBox();
            this.checkBoxBigBombs = new System.Windows.Forms.CheckBox();
            this.checkBoxSideBombs = new System.Windows.Forms.CheckBox();
            this.checkBoxFrontPlane = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxAir.SuspendLayout();
            this.panelAir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAir)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAir
            // 
            this.groupBoxAir.Controls.Add(this.labelFighterPlane);
            this.groupBoxAir.Controls.Add(this.labelWarPlane);
            this.groupBoxAir.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAir.Name = "groupBoxAir";
            this.groupBoxAir.Size = new System.Drawing.Size(361, 146);
            this.groupBoxAir.TabIndex = 7;
            this.groupBoxAir.TabStop = false;
            this.groupBoxAir.Text = "Тип кузова:";
            // 
            // labelFighterPlane
            // 
            this.labelFighterPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFighterPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFighterPlane.Location = new System.Drawing.Point(22, 77);
            this.labelFighterPlane.Name = "labelFighterPlane";
            this.labelFighterPlane.Size = new System.Drawing.Size(138, 38);
            this.labelFighterPlane.TabIndex = 1;
            this.labelFighterPlane.Text = "Истребитель";
            this.labelFighterPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFighterPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFighterPlane_MouseDown);
            // 
            // labelWarPlane
            // 
            this.labelWarPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWarPlane.Location = new System.Drawing.Point(22, 29);
            this.labelWarPlane.Name = "labelWarPlane";
            this.labelWarPlane.Size = new System.Drawing.Size(138, 38);
            this.labelWarPlane.TabIndex = 0;
            this.labelWarPlane.Text = "Военный самолёт";
            this.labelWarPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWarPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWarPlane_MouseDown);
            // 
            // panelAir
            // 
            this.panelAir.AllowDrop = true;
            this.panelAir.Controls.Add(this.pictureBoxAir);
            this.panelAir.Location = new System.Drawing.Point(201, 12);
            this.panelAir.Name = "panelAir";
            this.panelAir.Size = new System.Drawing.Size(153, 136);
            this.panelAir.TabIndex = 9;
            this.panelAir.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAir_DragDrop);
            this.panelAir.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAir_DragEnter);
            // 
            // pictureBoxAir
            // 
            this.pictureBoxAir.Location = new System.Drawing.Point(7, 8);
            this.pictureBoxAir.Name = "pictureBoxAir";
            this.pictureBoxAir.Size = new System.Drawing.Size(136, 125);
            this.pictureBoxAir.TabIndex = 2;
            this.pictureBoxAir.TabStop = false;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.labelDopColor);
            this.groupBoxColor.Controls.Add(this.panelNavy);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Controls.Add(this.panelAqua);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.labelMainColor);
            this.groupBoxColor.Location = new System.Drawing.Point(360, 12);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(251, 163);
            this.groupBoxColor.TabIndex = 11;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDopColor.Location = new System.Drawing.Point(129, 20);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(117, 38);
            this.labelDopColor.TabIndex = 9;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelNavy
            // 
            this.panelNavy.BackColor = System.Drawing.Color.Navy;
            this.panelNavy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavy.Location = new System.Drawing.Point(196, 114);
            this.panelNavy.Name = "panelNavy";
            this.panelNavy.Size = new System.Drawing.Size(40, 40);
            this.panelNavy.TabIndex = 6;
            this.panelNavy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(196, 66);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(40, 40);
            this.panelWhite.TabIndex = 4;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(136, 114);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(40, 40);
            this.panelGreen.TabIndex = 7;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(136, 66);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(40, 40);
            this.panelBlack.TabIndex = 4;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAqua.Location = new System.Drawing.Point(75, 114);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(40, 40);
            this.panelAqua.TabIndex = 8;
            this.panelAqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(75, 66);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(40, 40);
            this.panelYellow.TabIndex = 4;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(15, 114);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(40, 40);
            this.panelGray.TabIndex = 5;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(15, 66);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(40, 40);
            this.panelRed.TabIndex = 3;
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainColor.Location = new System.Drawing.Point(6, 20);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(117, 38);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Controls.Add(this.label2);
            this.groupBoxParametrs.Controls.Add(this.checkBoxMiniBombs);
            this.groupBoxParametrs.Controls.Add(this.checkBoxBigBombs);
            this.groupBoxParametrs.Controls.Add(this.checkBoxSideBombs);
            this.groupBoxParametrs.Controls.Add(this.checkBoxFrontPlane);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParametrs.Controls.Add(this.label1);
            this.groupBoxParametrs.Location = new System.Drawing.Point(12, 154);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(342, 125);
            this.groupBoxParametrs.TabIndex = 12;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Параметры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Вес самолёта:";
            // 
            // checkBoxMiniBombs
            // 
            this.checkBoxMiniBombs.AutoSize = true;
            this.checkBoxMiniBombs.Checked = true;
            this.checkBoxMiniBombs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMiniBombs.Location = new System.Drawing.Point(181, 85);
            this.checkBoxMiniBombs.Name = "checkBoxMiniBombs";
            this.checkBoxMiniBombs.Size = new System.Drawing.Size(120, 17);
            this.checkBoxMiniBombs.TabIndex = 9;
            this.checkBoxMiniBombs.Text = "Маленькие бомбы";
            this.checkBoxMiniBombs.UseVisualStyleBackColor = true;
            // 
            // checkBoxBigBombs
            // 
            this.checkBoxBigBombs.AutoSize = true;
            this.checkBoxBigBombs.Checked = true;
            this.checkBoxBigBombs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBigBombs.Location = new System.Drawing.Point(181, 62);
            this.checkBoxBigBombs.Name = "checkBoxBigBombs";
            this.checkBoxBigBombs.Size = new System.Drawing.Size(108, 17);
            this.checkBoxBigBombs.TabIndex = 8;
            this.checkBoxBigBombs.Text = "Большие бомбы";
            this.checkBoxBigBombs.UseVisualStyleBackColor = true;
            // 
            // checkBoxSideBombs
            // 
            this.checkBoxSideBombs.AutoSize = true;
            this.checkBoxSideBombs.Checked = true;
            this.checkBoxSideBombs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSideBombs.Location = new System.Drawing.Point(181, 39);
            this.checkBoxSideBombs.Name = "checkBoxSideBombs";
            this.checkBoxSideBombs.Size = new System.Drawing.Size(108, 17);
            this.checkBoxSideBombs.TabIndex = 7;
            this.checkBoxSideBombs.Text = "Боковые бомбы";
            this.checkBoxSideBombs.UseVisualStyleBackColor = true;
            // 
            // checkBoxFrontPlane
            // 
            this.checkBoxFrontPlane.AutoSize = true;
            this.checkBoxFrontPlane.Checked = true;
            this.checkBoxFrontPlane.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFrontPlane.Location = new System.Drawing.Point(181, 16);
            this.checkBoxFrontPlane.Name = "checkBoxFrontPlane";
            this.checkBoxFrontPlane.Size = new System.Drawing.Size(127, 17);
            this.checkBoxFrontPlane.TabIndex = 6;
            this.checkBoxFrontPlane.Text = "Переднее оперение";
            this.checkBoxFrontPlane.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(85, 79);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(85, 32);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс.скорость:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(536, 206);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 13;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click_1);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(536, 256);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAirConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 291);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxParametrs);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelAir);
            this.Controls.Add(this.groupBoxAir);
            this.Name = "FormAirConfig";
            this.Text = "FormAirConfig";
            this.groupBoxAir.ResumeLayout(false);
            this.panelAir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAir)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAir;
        private System.Windows.Forms.Label labelFighterPlane;
        private System.Windows.Forms.Label labelWarPlane;
        private System.Windows.Forms.Panel panelAir;
        private System.Windows.Forms.PictureBox pictureBoxAir;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Panel panelNavy;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxMiniBombs;
        private System.Windows.Forms.CheckBox checkBoxBigBombs;
        private System.Windows.Forms.CheckBox checkBoxSideBombs;
        private System.Windows.Forms.CheckBox checkBoxFrontPlane;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}