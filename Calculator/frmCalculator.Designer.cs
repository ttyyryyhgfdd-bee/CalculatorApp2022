namespace CalculatorApp
{
    partial class frmCalc
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
            txtCalcGUI = new TextBox();
            btnResult = new Button();
            btnClear = new Button();
            btnFactorial = new Button();
            btnBack = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnSubstruct = new Button();
            btnAddition = new Button();
            btnDepercent = new Button();
            btn0 = new Button();
            btnFloat = new Button();
            btnPercent = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            menuStrip1 = new MenuStrip();
            видToolStripMenuItem = new ToolStripMenuItem();
            обычныйToolStripMenuItem = new ToolStripMenuItem();
            инженерныйToolStripMenuItem = new ToolStripMenuItem();
            программистToolStripMenuItem = new ToolStripMenuItem();
            статистикаToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            журналToolStripMenuItem = new ToolStripMenuItem();
            группировкаЦифрПоToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            обычныйToolStripMenuItem1 = new ToolStripMenuItem();
            преобразованиеЕдиницToolStripMenuItem = new ToolStripMenuItem();
            вычислениеДатыToolStripMenuItem = new ToolStripMenuItem();
            листыToolStripMenuItem = new ToolStripMenuItem();
            фывToolStripMenuItem = new ToolStripMenuItem();
            автолизингToolStripMenuItem = new ToolStripMenuItem();
            экономиямильгаллонToolStripMenuItem = new ToolStripMenuItem();
            экономияТопливол100кмToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            журналToolStripMenuItem1 = new ToolStripMenuItem();
            копироватьЖурналToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            отменитьПравкуToolStripMenuItem = new ToolStripMenuItem();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            просмотретьСправкуToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            btnPower = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCalcGUI
            // 
            txtCalcGUI.Font = new Font("Segoe UI", 18F);
            txtCalcGUI.Location = new Point(12, 37);
            txtCalcGUI.Name = "txtCalcGUI";
            txtCalcGUI.ReadOnly = true;
            txtCalcGUI.Size = new Size(324, 39);
            txtCalcGUI.TabIndex = 0;
            txtCalcGUI.Text = "0";
            txtCalcGUI.TextAlign = HorizontalAlignment.Right;
            // 
            // btnResult
            // 
            btnResult.BackColor = SystemColors.ButtonShadow;
            btnResult.Font = new Font("Segoe UI", 18F);
            btnResult.Location = new Point(276, 232);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(60, 86);
            btnResult.TabIndex = 13;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnActionOperation;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ButtonShadow;
            btnClear.Font = new Font("Segoe UI", 13F);
            btnClear.Location = new Point(12, 94);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 40);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnActionOperation;
            // 
            // btnFactorial
            // 
            btnFactorial.Font = new Font("Segoe UI", 18F);
            btnFactorial.Location = new Point(144, 94);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.Size = new Size(60, 40);
            btnFactorial.TabIndex = 17;
            btnFactorial.Text = "!";
            btnFactorial.UseVisualStyleBackColor = true;
            btnFactorial.Click += btnActionOperation;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonShadow;
            btnBack.Font = new Font("Segoe UI", 13F);
            btnBack.Location = new Point(210, 94);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(126, 40);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnActionOperation;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 18F);
            btnMultiply.Location = new Point(210, 140);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(60, 40);
            btnMultiply.TabIndex = 21;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnActionOperation;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 18F);
            btnDivide.Location = new Point(210, 186);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(60, 40);
            btnDivide.TabIndex = 22;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnActionOperation;
            // 
            // btnSubstruct
            // 
            btnSubstruct.Font = new Font("Segoe UI", 18F);
            btnSubstruct.Location = new Point(210, 232);
            btnSubstruct.Name = "btnSubstruct";
            btnSubstruct.Size = new Size(60, 40);
            btnSubstruct.TabIndex = 23;
            btnSubstruct.Text = "-";
            btnSubstruct.UseVisualStyleBackColor = true;
            btnSubstruct.Click += btnActionOperation;
            // 
            // btnAddition
            // 
            btnAddition.Font = new Font("Segoe UI", 18F);
            btnAddition.Location = new Point(210, 278);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(60, 40);
            btnAddition.TabIndex = 24;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += btnActionOperation;
            // 
            // btnDepercent
            // 
            btnDepercent.Font = new Font("Segoe UI", 13F);
            btnDepercent.Location = new Point(276, 186);
            btnDepercent.Name = "btnDepercent";
            btnDepercent.Size = new Size(60, 40);
            btnDepercent.TabIndex = 28;
            btnDepercent.Text = "D%";
            btnDepercent.UseVisualStyleBackColor = true;
            btnDepercent.Click += btnActionOperation;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F);
            btn0.Location = new Point(78, 278);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 40);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnActionNumber;
            // 
            // btnFloat
            // 
            btnFloat.Font = new Font("Segoe UI", 18F);
            btnFloat.Location = new Point(12, 278);
            btnFloat.Name = "btnFloat";
            btnFloat.Size = new Size(60, 40);
            btnFloat.TabIndex = 11;
            btnFloat.Text = ",";
            btnFloat.UseVisualStyleBackColor = true;
            btnFloat.Click += btnActionNumber;
            // 
            // btnPercent
            // 
            btnPercent.Font = new Font("Segoe UI", 18F);
            btnPercent.Location = new Point(144, 278);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(60, 40);
            btnPercent.TabIndex = 1;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnActionOperation;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F);
            btn1.Location = new Point(12, 232);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 40);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnActionNumber;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F);
            btn2.Location = new Point(78, 232);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 40);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnActionNumber;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F);
            btn3.Location = new Point(144, 232);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 40);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnActionNumber;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F);
            btn6.Location = new Point(144, 186);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 40);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnActionNumber;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F);
            btn5.Location = new Point(78, 186);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 40);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnActionNumber;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F);
            btn4.Location = new Point(12, 186);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 40);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnActionNumber;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F);
            btn9.Location = new Point(144, 140);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 40);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnActionNumber;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F);
            btn8.Location = new Point(78, 140);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 40);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnActionNumber;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F);
            btn7.Location = new Point(12, 140);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 40);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnActionNumber;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { видToolStripMenuItem, правкаToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(348, 24);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { обычныйToolStripMenuItem, инженерныйToolStripMenuItem, программистToolStripMenuItem, статистикаToolStripMenuItem, toolStripSeparator1, журналToolStripMenuItem, группировкаЦифрПоToolStripMenuItem, toolStripSeparator2, обычныйToolStripMenuItem1, преобразованиеЕдиницToolStripMenuItem, вычислениеДатыToolStripMenuItem, листыToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";
            // 
            // обычныйToolStripMenuItem
            // 
            обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            обычныйToolStripMenuItem.Size = new Size(251, 22);
            обычныйToolStripMenuItem.Text = "Обычный";
            // 
            // инженерныйToolStripMenuItem
            // 
            инженерныйToolStripMenuItem.Name = "инженерныйToolStripMenuItem";
            инженерныйToolStripMenuItem.Size = new Size(251, 22);
            инженерныйToolStripMenuItem.Text = "Инженерный";
            // 
            // программистToolStripMenuItem
            // 
            программистToolStripMenuItem.Name = "программистToolStripMenuItem";
            программистToolStripMenuItem.Size = new Size(251, 22);
            программистToolStripMenuItem.Text = "Программист";
            // 
            // статистикаToolStripMenuItem
            // 
            статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            статистикаToolStripMenuItem.Size = new Size(251, 22);
            статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(248, 6);
            // 
            // журналToolStripMenuItem
            // 
            журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            журналToolStripMenuItem.Size = new Size(251, 22);
            журналToolStripMenuItem.Text = "Журнал";
            // 
            // группировкаЦифрПоToolStripMenuItem
            // 
            группировкаЦифрПоToolStripMenuItem.Name = "группировкаЦифрПоToolStripMenuItem";
            группировкаЦифрПоToolStripMenuItem.Size = new Size(251, 22);
            группировкаЦифрПоToolStripMenuItem.Text = "Группировка цифр по разрядам";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(248, 6);
            // 
            // обычныйToolStripMenuItem1
            // 
            обычныйToolStripMenuItem1.Name = "обычныйToolStripMenuItem1";
            обычныйToolStripMenuItem1.Size = new Size(251, 22);
            обычныйToolStripMenuItem1.Text = "Обычный";
            // 
            // преобразованиеЕдиницToolStripMenuItem
            // 
            преобразованиеЕдиницToolStripMenuItem.Name = "преобразованиеЕдиницToolStripMenuItem";
            преобразованиеЕдиницToolStripMenuItem.Size = new Size(251, 22);
            преобразованиеЕдиницToolStripMenuItem.Text = "Преобразование единиц";
            // 
            // вычислениеДатыToolStripMenuItem
            // 
            вычислениеДатыToolStripMenuItem.Name = "вычислениеДатыToolStripMenuItem";
            вычислениеДатыToolStripMenuItem.Size = new Size(251, 22);
            вычислениеДатыToolStripMenuItem.Text = "Вычисление даты";
            // 
            // листыToolStripMenuItem
            // 
            листыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { фывToolStripMenuItem, автолизингToolStripMenuItem, экономиямильгаллонToolStripMenuItem, экономияТопливол100кмToolStripMenuItem });
            листыToolStripMenuItem.Name = "листыToolStripMenuItem";
            листыToolStripMenuItem.Size = new Size(251, 22);
            листыToolStripMenuItem.Text = "Листы";
            // 
            // фывToolStripMenuItem
            // 
            фывToolStripMenuItem.Name = "фывToolStripMenuItem";
            фывToolStripMenuItem.Size = new Size(232, 22);
            фывToolStripMenuItem.Text = "Ипотека";
            // 
            // автолизингToolStripMenuItem
            // 
            автолизингToolStripMenuItem.Name = "автолизингToolStripMenuItem";
            автолизингToolStripMenuItem.Size = new Size(232, 22);
            автолизингToolStripMenuItem.Text = "Автолизинг";
            // 
            // экономиямильгаллонToolStripMenuItem
            // 
            экономиямильгаллонToolStripMenuItem.Name = "экономиямильгаллонToolStripMenuItem";
            экономиямильгаллонToolStripMenuItem.Size = new Size(232, 22);
            экономиямильгаллонToolStripMenuItem.Text = "Экономия (миль/галлон)";
            // 
            // экономияТопливол100кмToolStripMenuItem
            // 
            экономияТопливол100кмToolStripMenuItem.Name = "экономияТопливол100кмToolStripMenuItem";
            экономияТопливол100кмToolStripMenuItem.Size = new Size(232, 22);
            экономияТопливол100кмToolStripMenuItem.Text = "Экономия топливо(л/100км)";
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { копироватьToolStripMenuItem, вставитьToolStripMenuItem, toolStripSeparator3, журналToolStripMenuItem1 });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(59, 20);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size = new Size(139, 22);
            копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(139, 22);
            вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(136, 6);
            // 
            // журналToolStripMenuItem1
            // 
            журналToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { копироватьЖурналToolStripMenuItem, изменитьToolStripMenuItem, отменитьПравкуToolStripMenuItem, очиститьToolStripMenuItem });
            журналToolStripMenuItem1.Name = "журналToolStripMenuItem1";
            журналToolStripMenuItem1.Size = new Size(139, 22);
            журналToolStripMenuItem1.Text = "Журнал";
            // 
            // копироватьЖурналToolStripMenuItem
            // 
            копироватьЖурналToolStripMenuItem.Name = "копироватьЖурналToolStripMenuItem";
            копироватьЖурналToolStripMenuItem.Size = new Size(184, 22);
            копироватьЖурналToolStripMenuItem.Text = "Копировать журнал";
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(184, 22);
            изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // отменитьПравкуToolStripMenuItem
            // 
            отменитьПравкуToolStripMenuItem.Name = "отменитьПравкуToolStripMenuItem";
            отменитьПравкуToolStripMenuItem.Size = new Size(184, 22);
            отменитьПравкуToolStripMenuItem.Text = "Отменить правку";
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(184, 22);
            очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { просмотретьСправкуToolStripMenuItem, toolStripSeparator4, оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // просмотретьСправкуToolStripMenuItem
            // 
            просмотретьСправкуToolStripMenuItem.Name = "просмотретьСправкуToolStripMenuItem";
            просмотретьСправкуToolStripMenuItem.Size = new Size(195, 22);
            просмотретьСправкуToolStripMenuItem.Text = "Просмотреть справку";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(192, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(195, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // btnPower
            // 
            btnPower.Font = new Font("Segoe UI", 18F);
            btnPower.Location = new Point(276, 140);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(60, 40);
            btnPower.TabIndex = 30;
            btnPower.Text = "^";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += btnActionOperation;
            // 
            // frmCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(348, 332);
            Controls.Add(btnPower);
            Controls.Add(btn7);
            Controls.Add(btnDepercent);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btnAddition);
            Controls.Add(btn6);
            Controls.Add(btnSubstruct);
            Controls.Add(btn3);
            Controls.Add(btnDivide);
            Controls.Add(btn2);
            Controls.Add(btnMultiply);
            Controls.Add(btn1);
            Controls.Add(btnBack);
            Controls.Add(btnPercent);
            Controls.Add(btnFloat);
            Controls.Add(btn0);
            Controls.Add(btnFactorial);
            Controls.Add(btnClear);
            Controls.Add(btnResult);
            Controls.Add(txtCalcGUI);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmCalc";
            Text = "Calculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txtCalcGUI;
        private Button btnMultiply;
        private Button btnResult;
        private Button btnClear;
        private Button btnFactorial;
        private Button btnBack;
        private Button btnDivide;
        private Button btnSubstruct;
        private Button btnAddition;
        private Button btnDepercent;
        private Button btn0;
        private Button btnFloat;
        private Button btnPercent;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem обычныйToolStripMenuItem;
        private ToolStripMenuItem инженерныйToolStripMenuItem;
        private ToolStripMenuItem программистToolStripMenuItem;
        private ToolStripMenuItem статистикаToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem журналToolStripMenuItem;
        private ToolStripMenuItem группировкаЦифрПоToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem обычныйToolStripMenuItem1;
        private ToolStripMenuItem преобразованиеЕдиницToolStripMenuItem;
        private ToolStripMenuItem вычислениеДатыToolStripMenuItem;
        private ToolStripMenuItem листыToolStripMenuItem;
        private ToolStripMenuItem фывToolStripMenuItem;
        private ToolStripMenuItem автолизингToolStripMenuItem;
        private ToolStripMenuItem экономиямильгаллонToolStripMenuItem;
        private ToolStripMenuItem экономияТопливол100кмToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem журналToolStripMenuItem1;
        private ToolStripMenuItem копироватьЖурналToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem отменитьПравкуToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem просмотретьСправкуToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Button btnPower;
    }
}
