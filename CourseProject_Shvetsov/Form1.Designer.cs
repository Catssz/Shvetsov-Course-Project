
namespace Taxopark
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.carsTable = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.errorMessage = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.modelSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dealerSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.speedInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filteredCarsTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.passengerCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filteredCarsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carsTable
            // 
            this.carsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsTable.Location = new System.Drawing.Point(26, 45);
            this.carsTable.Name = "carsTable";
            this.carsTable.RowHeadersWidth = 51;
            this.carsTable.RowTemplate.Height = 24;
            this.carsTable.Size = new System.Drawing.Size(1010, 253);
            this.carsTable.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(812, 176);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(161, 36);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 338);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 263);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorMessage);
            this.tabPage1.Controls.Add(this.numberInput);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.modelSelect);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dealerSelect);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1002, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(22, 135);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 17);
            this.errorMessage.TabIndex = 9;
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(110, 78);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(175, 22);
            this.numberInput.TabIndex = 8;
            this.numberInput.TextChanged += new System.EventHandler(this.numberInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Гос. номер:";
            // 
            // modelSelect
            // 
            this.modelSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelSelect.FormattingEnabled = true;
            this.modelSelect.ImeMode = System.Windows.Forms.ImeMode.On;
            this.modelSelect.Location = new System.Drawing.Point(411, 19);
            this.modelSelect.Name = "modelSelect";
            this.modelSelect.Size = new System.Drawing.Size(175, 24);
            this.modelSelect.Sorted = true;
            this.modelSelect.TabIndex = 6;
            this.modelSelect.SelectedIndexChanged += new System.EventHandler(this.modelSelect_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Модель:";
            // 
            // dealerSelect
            // 
            this.dealerSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dealerSelect.FormattingEnabled = true;
            this.dealerSelect.Location = new System.Drawing.Point(110, 19);
            this.dealerSelect.Name = "dealerSelect";
            this.dealerSelect.Size = new System.Drawing.Size(175, 24);
            this.dealerSelect.Sorted = true;
            this.dealerSelect.TabIndex = 4;
            this.dealerSelect.SelectedIndexChanged += new System.EventHandler(this.dealerSelect_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Диллер:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.speedInput);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.filteredCarsTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1002, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Найти";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "км/ч";
            // 
            // speedInput
            // 
            this.speedInput.Location = new System.Drawing.Point(146, 15);
            this.speedInput.Name = "speedInput";
            this.speedInput.Size = new System.Drawing.Size(123, 22);
            this.speedInput.TabIndex = 5;
            this.speedInput.TextChanged += new System.EventHandler(this.speedInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Скорость от 0 до:";
            // 
            // filteredCarsTable
            // 
            this.filteredCarsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filteredCarsTable.Location = new System.Drawing.Point(0, 55);
            this.filteredCarsTable.Name = "filteredCarsTable";
            this.filteredCarsTable.RowHeadersWidth = 51;
            this.filteredCarsTable.RowTemplate.Height = 24;
            this.filteredCarsTable.Size = new System.Drawing.Size(1002, 179);
            this.filteredCarsTable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Все автомобили:";
            // 
            // passengerCarBindingSource
            // 
            this.passengerCarBindingSource.DataSource = typeof(Taxopark.PassengerCar);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 648);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.carsTable);
            this.Name = "MainForm";
            this.Text = "Таксопарк";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filteredCarsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerCarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource passengerCarBindingSource;
        private System.Windows.Forms.DataGridView carsTable;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView filteredCarsTable;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox modelSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dealerSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox speedInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label errorMessage;
    }
}

