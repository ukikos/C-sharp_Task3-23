
namespace C_sharp_Task3_23
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openButton = new System.Windows.Forms.Button();
            this.sortByFuelConsumptionAscButton = new System.Windows.Forms.Button();
            this.sortByFuelConsumptionDesButton = new System.Windows.Forms.Button();
            this.calculateCostButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.findCarsBySpeedButton = new System.Windows.Forms.Button();
            this.textBoxMinSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveHowButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(1037, 104);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(264, 54);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(33, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(962, 350);
            this.dataGridView1.TabIndex = 4;
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.Location = new System.Drawing.Point(1037, 48);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(264, 50);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Открыть файл";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // sortByFuelConsumptionAscButton
            // 
            this.sortByFuelConsumptionAscButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByFuelConsumptionAscButton.Location = new System.Drawing.Point(1037, 271);
            this.sortByFuelConsumptionAscButton.Name = "sortByFuelConsumptionAscButton";
            this.sortByFuelConsumptionAscButton.Size = new System.Drawing.Size(264, 54);
            this.sortByFuelConsumptionAscButton.TabIndex = 6;
            this.sortByFuelConsumptionAscButton.Text = "Отсортировать по расходу топлива (по возр.)";
            this.sortByFuelConsumptionAscButton.UseVisualStyleBackColor = true;
            this.sortByFuelConsumptionAscButton.Click += new System.EventHandler(this.sortByFuelConsumptionAscButton_Click);
            // 
            // sortByFuelConsumptionDesButton
            // 
            this.sortByFuelConsumptionDesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByFuelConsumptionDesButton.Location = new System.Drawing.Point(1037, 331);
            this.sortByFuelConsumptionDesButton.Name = "sortByFuelConsumptionDesButton";
            this.sortByFuelConsumptionDesButton.Size = new System.Drawing.Size(264, 54);
            this.sortByFuelConsumptionDesButton.TabIndex = 7;
            this.sortByFuelConsumptionDesButton.Text = "Отсортировать по расходу топлива (по убыв.)";
            this.sortByFuelConsumptionDesButton.UseVisualStyleBackColor = true;
            this.sortByFuelConsumptionDesButton.Click += new System.EventHandler(this.sortByFuelConsumptionDesButton_Click);
            // 
            // calculateCostButton
            // 
            this.calculateCostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateCostButton.Location = new System.Drawing.Point(1037, 436);
            this.calculateCostButton.Name = "calculateCostButton";
            this.calculateCostButton.Size = new System.Drawing.Size(264, 54);
            this.calculateCostButton.TabIndex = 8;
            this.calculateCostButton.Text = "Посчитать стоимость автопарка";
            this.calculateCostButton.UseVisualStyleBackColor = true;
            this.calculateCostButton.Click += new System.EventHandler(this.calculateCostButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(1037, 496);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 26);
            this.textBox2.TabIndex = 9;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutput.Location = new System.Drawing.Point(33, 436);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(962, 190);
            this.textBoxOutput.TabIndex = 10;
            // 
            // findCarsBySpeedButton
            // 
            this.findCarsBySpeedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findCarsBySpeedButton.Location = new System.Drawing.Point(1037, 546);
            this.findCarsBySpeedButton.Name = "findCarsBySpeedButton";
            this.findCarsBySpeedButton.Size = new System.Drawing.Size(264, 46);
            this.findCarsBySpeedButton.TabIndex = 11;
            this.findCarsBySpeedButton.Text = "Найти автомобили по диапазону скоростей";
            this.findCarsBySpeedButton.UseVisualStyleBackColor = true;
            this.findCarsBySpeedButton.Click += new System.EventHandler(this.findCarsBySpeedButton_Click);
            // 
            // textBoxMinSpeed
            // 
            this.textBoxMinSpeed.Location = new System.Drawing.Point(1037, 606);
            this.textBoxMinSpeed.Name = "textBoxMinSpeed";
            this.textBoxMinSpeed.Size = new System.Drawing.Size(107, 20);
            this.textBoxMinSpeed.TabIndex = 12;
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(1190, 606);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(111, 20);
            this.textBoxMaxSpeed.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1159, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "---";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveHowButton
            // 
            this.saveHowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveHowButton.Location = new System.Drawing.Point(1037, 164);
            this.saveHowButton.Name = "saveHowButton";
            this.saveHowButton.Size = new System.Drawing.Size(264, 52);
            this.saveHowButton.TabIndex = 15;
            this.saveHowButton.Text = "Сохранить как...";
            this.saveHowButton.UseVisualStyleBackColor = true;
            this.saveHowButton.Click += new System.EventHandler(this.saveHowButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathLabel.Location = new System.Drawing.Point(60, 33);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(42, 18);
            this.pathLabel.TabIndex = 16;
            this.pathLabel.Text = "Path:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathTextBox.Location = new System.Drawing.Point(108, 31);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(840, 24);
            this.pathTextBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 660);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.saveHowButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.textBoxMinSpeed);
            this.Controls.Add(this.findCarsBySpeedButton);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.calculateCostButton);
            this.Controls.Add(this.sortByFuelConsumptionDesButton);
            this.Controls.Add(this.sortByFuelConsumptionAscButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveButton);
            this.Name = "Form1";
            this.Text = "Таксопарк";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button sortByFuelConsumptionAscButton;
        private System.Windows.Forms.Button sortByFuelConsumptionDesButton;
        private System.Windows.Forms.Button calculateCostButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button findCarsBySpeedButton;
        private System.Windows.Forms.TextBox textBoxMinSpeed;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveHowButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathTextBox;
    }
}

