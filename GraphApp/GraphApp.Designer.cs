namespace GraphApp
{
    partial class GraphApp
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonCheckConnection = new System.Windows.Forms.Button();
            this.deleteEdgeRadioButton = new System.Windows.Forms.RadioButton();
            this.addEdgeRadioButton = new System.Windows.Forms.RadioButton();
            this.moveNodeRadioButton = new System.Windows.Forms.RadioButton();
            this.deleteNodeRadioButton = new System.Windows.Forms.RadioButton();
            this.addNodeRadioButton = new System.Windows.Forms.RadioButton();
            this.modesLabel = new System.Windows.Forms.Label();
            this.labelChecked = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(13, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(660, 383);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.buttonCheckConnection);
            this.groupBox.Controls.Add(this.deleteEdgeRadioButton);
            this.groupBox.Controls.Add(this.addEdgeRadioButton);
            this.groupBox.Controls.Add(this.moveNodeRadioButton);
            this.groupBox.Controls.Add(this.deleteNodeRadioButton);
            this.groupBox.Controls.Add(this.addNodeRadioButton);
            this.groupBox.Controls.Add(this.modesLabel);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.Location = new System.Drawing.Point(13, 397);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(660, 135);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Работа с графом";
            // 
            // buttonCheckConnection
            // 
            this.buttonCheckConnection.Location = new System.Drawing.Point(6, 103);
            this.buttonCheckConnection.Name = "buttonCheckConnection";
            this.buttonCheckConnection.Size = new System.Drawing.Size(162, 26);
            this.buttonCheckConnection.TabIndex = 6;
            this.buttonCheckConnection.Text = "Проверить на связность";
            this.buttonCheckConnection.UseVisualStyleBackColor = true;
            this.buttonCheckConnection.Click += new System.EventHandler(this.buttonCheckConnection_Click);
            // 
            // deleteEdgeRadioButton
            // 
            this.deleteEdgeRadioButton.AutoSize = true;
            this.deleteEdgeRadioButton.Location = new System.Drawing.Point(158, 57);
            this.deleteEdgeRadioButton.Name = "deleteEdgeRadioButton";
            this.deleteEdgeRadioButton.Size = new System.Drawing.Size(113, 19);
            this.deleteEdgeRadioButton.TabIndex = 5;
            this.deleteEdgeRadioButton.Text = "Удалить рёбра";
            this.deleteEdgeRadioButton.UseVisualStyleBackColor = true;
            // 
            // addEdgeRadioButton
            // 
            this.addEdgeRadioButton.AutoSize = true;
            this.addEdgeRadioButton.Location = new System.Drawing.Point(158, 32);
            this.addEdgeRadioButton.Name = "addEdgeRadioButton";
            this.addEdgeRadioButton.Size = new System.Drawing.Size(121, 19);
            this.addEdgeRadioButton.TabIndex = 4;
            this.addEdgeRadioButton.Text = "Добавить рёбра";
            this.addEdgeRadioButton.UseVisualStyleBackColor = true;
            // 
            // moveNodeRadioButton
            // 
            this.moveNodeRadioButton.AutoSize = true;
            this.moveNodeRadioButton.Location = new System.Drawing.Point(6, 82);
            this.moveNodeRadioButton.Name = "moveNodeRadioButton";
            this.moveNodeRadioButton.Size = new System.Drawing.Size(135, 19);
            this.moveNodeRadioButton.TabIndex = 3;
            this.moveNodeRadioButton.Text = "Переместить узлы";
            this.moveNodeRadioButton.UseVisualStyleBackColor = true;
            // 
            // deleteNodeRadioButton
            // 
            this.deleteNodeRadioButton.AutoSize = true;
            this.deleteNodeRadioButton.Location = new System.Drawing.Point(6, 57);
            this.deleteNodeRadioButton.Name = "deleteNodeRadioButton";
            this.deleteNodeRadioButton.Size = new System.Drawing.Size(105, 19);
            this.deleteNodeRadioButton.TabIndex = 2;
            this.deleteNodeRadioButton.Text = "Удалить узлы";
            this.deleteNodeRadioButton.UseVisualStyleBackColor = true;
            // 
            // addNodeRadioButton
            // 
            this.addNodeRadioButton.AutoSize = true;
            this.addNodeRadioButton.Checked = true;
            this.addNodeRadioButton.Location = new System.Drawing.Point(6, 32);
            this.addNodeRadioButton.Name = "addNodeRadioButton";
            this.addNodeRadioButton.Size = new System.Drawing.Size(113, 19);
            this.addNodeRadioButton.TabIndex = 1;
            this.addNodeRadioButton.TabStop = true;
            this.addNodeRadioButton.Text = "Добавить узлы";
            this.addNodeRadioButton.UseVisualStyleBackColor = true;
            // 
            // modesLabel
            // 
            this.modesLabel.AutoSize = true;
            this.modesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modesLabel.Location = new System.Drawing.Point(6, 16);
            this.modesLabel.Name = "modesLabel";
            this.modesLabel.Size = new System.Drawing.Size(162, 16);
            this.modesLabel.TabIndex = 0;
            this.modesLabel.Text = "Что вы хотите сделать?";
            // 
            // labelChecked
            // 
            this.labelChecked.AutoSize = true;
            this.labelChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChecked.Location = new System.Drawing.Point(10, 9);
            this.labelChecked.Name = "labelChecked";
            this.labelChecked.Size = new System.Drawing.Size(229, 20);
            this.labelChecked.TabIndex = 2;
            this.labelChecked.Text = "Является ли граф связным?";
            // 
            // GraphApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 544);
            this.Controls.Add(this.labelChecked);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "GraphApp";
            this.Text = "GraphApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton deleteEdgeRadioButton;
        private System.Windows.Forms.RadioButton addEdgeRadioButton;
        private System.Windows.Forms.RadioButton moveNodeRadioButton;
        private System.Windows.Forms.RadioButton deleteNodeRadioButton;
        private System.Windows.Forms.RadioButton addNodeRadioButton;
        private System.Windows.Forms.Label modesLabel;
        private System.Windows.Forms.Button buttonCheckConnection;
        private System.Windows.Forms.Label labelChecked;
    }
}

