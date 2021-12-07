
namespace Lab1_PIbd_22_Istyukov_Timofey
{
    partial class FormPlane
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
            this.pictureBoxFighterAircraft = new System.Windows.Forms.PictureBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonCreateWarPlane_Click = new System.Windows.Forms.Button();
            this.buttonCreateFighterPlane_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFighterAircraft)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFighterAircraft
            // 
            this.pictureBoxFighterAircraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFighterAircraft.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFighterAircraft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxFighterAircraft.Name = "pictureBoxFighterAircraft";
            this.pictureBoxFighterAircraft.Size = new System.Drawing.Size(662, 368);
            this.pictureBoxFighterAircraft.TabIndex = 0;
            this.pictureBoxFighterAircraft.TabStop = false;
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::Lab1_PIbd_22_Istyukov_Timofey.Properties.Resources.up_;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(605, 284);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(22, 24);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::Lab1_PIbd_22_Istyukov_Timofey.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(580, 310);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(22, 24);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::Lab1_PIbd_22_Istyukov_Timofey.Properties.Resources.right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(629, 310);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(22, 24);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::Lab1_PIbd_22_Istyukov_Timofey.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(605, 336);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(22, 24);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateWarPlane_Click
            // 
            this.buttonCreateWarPlane_Click.Location = new System.Drawing.Point(11, 11);
            this.buttonCreateWarPlane_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateWarPlane_Click.Name = "buttonCreateWarPlane_Click";
            this.buttonCreateWarPlane_Click.Size = new System.Drawing.Size(153, 23);
            this.buttonCreateWarPlane_Click.TabIndex = 8;
            this.buttonCreateWarPlane_Click.Text = "Создать военный самолёт";
            this.buttonCreateWarPlane_Click.UseVisualStyleBackColor = true;
            this.buttonCreateWarPlane_Click.Click += new System.EventHandler(this.buttonCreateWarPlane_Click_Click);
            // 
            // buttonCreateFighterPlane_Click
            // 
            this.buttonCreateFighterPlane_Click.Location = new System.Drawing.Point(168, 11);
            this.buttonCreateFighterPlane_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateFighterPlane_Click.Name = "buttonCreateFighterPlane_Click";
            this.buttonCreateFighterPlane_Click.Size = new System.Drawing.Size(144, 23);
            this.buttonCreateFighterPlane_Click.TabIndex = 9;
            this.buttonCreateFighterPlane_Click.Text = "Создать истребитель";
            this.buttonCreateFighterPlane_Click.UseVisualStyleBackColor = true;
            this.buttonCreateFighterPlane_Click.Click += new System.EventHandler(this.buttonCreateFighterPlane_Click_Click);
            // 
            // FormPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 368);
            this.Controls.Add(this.buttonCreateFighterPlane_Click);
            this.Controls.Add(this.buttonCreateWarPlane_Click);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.pictureBoxFighterAircraft);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPlane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFighterAircraft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFighterAircraft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCreateWarPlane_Click;
        private System.Windows.Forms.Button buttonCreateFighterPlane_Click;
    }
}

