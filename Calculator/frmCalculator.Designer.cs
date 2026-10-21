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
            this.txtCalcGUI = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSubstruct = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnDepercent = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инженерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.журналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группировкаЦифрПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.обычныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.преобразованиеЕдиницToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислениеДатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.листыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фывToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автолизингToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экономиямильгаллонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экономияТопливол100кмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.журналToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьЖурналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьПравкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСправкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCalcGUI
            // 
            this.txtCalcGUI.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalcGUI.Location = new System.Drawing.Point(12, 37);
            this.txtCalcGUI.Name = "txtCalcGUI";
            this.txtCalcGUI.ReadOnly = true;
            this.txtCalcGUI.Size = new System.Drawing.Size(324, 39);
            this.txtCalcGUI.TabIndex = 0;
            this.txtCalcGUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResult.Location = new System.Drawing.Point(276, 278);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(60, 40);
            this.btnResult.TabIndex = 13;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(12, 94);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 40);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnFactorial
            // 
            this.btnFactorial.Enabled = false;
            this.btnFactorial.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFactorial.Location = new System.Drawing.Point(276, 232);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(60, 40);
            this.btnFactorial.TabIndex = 17;
            this.btnFactorial.Text = "!";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btnMin
            // 
            this.btnMin.Enabled = false;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMin.Location = new System.Drawing.Point(276, 186);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(60, 40);
            this.btnMin.TabIndex = 18;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            this.btnMax.Enabled = false;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMax.Location = new System.Drawing.Point(276, 140);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(60, 40);
            this.btnMax.TabIndex = 19;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(276, 94);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 40);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(210, 140);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 40);
            this.btnMultiply.TabIndex = 21;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(210, 186);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 40);
            this.btnDivide.TabIndex = 22;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btnSubstruct
            // 
            this.btnSubstruct.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubstruct.Location = new System.Drawing.Point(210, 232);
            this.btnSubstruct.Name = "btnSubstruct";
            this.btnSubstruct.Size = new System.Drawing.Size(60, 40);
            this.btnSubstruct.TabIndex = 23;
            this.btnSubstruct.Text = "-";
            this.btnSubstruct.UseVisualStyleBackColor = true;
            this.btnSubstruct.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddition.Location = new System.Drawing.Point(210, 278);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(60, 40);
            this.btnAddition.TabIndex = 24;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btnSum
            // 
            this.btnSum.Enabled = false;
            this.btnSum.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSum.Location = new System.Drawing.Point(78, 94);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(60, 40);
            this.btnSum.TabIndex = 26;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            // 
            // btnCount
            // 
            this.btnCount.Enabled = false;
            this.btnCount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCount.Location = new System.Drawing.Point(144, 94);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(60, 40);
            this.btnCount.TabIndex = 27;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            // 
            // btnDepercent
            // 
            this.btnDepercent.Enabled = false;
            this.btnDepercent.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDepercent.Location = new System.Drawing.Point(210, 94);
            this.btnDepercent.Name = "btnDepercent";
            this.btnDepercent.Size = new System.Drawing.Size(60, 40);
            this.btnDepercent.TabIndex = 28;
            this.btnDepercent.Text = "D%";
            this.btnDepercent.UseVisualStyleBackColor = true;
            this.btnDepercent.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(78, 278);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 40);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btnFloat
            // 
            this.btnFloat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFloat.Location = new System.Drawing.Point(12, 278);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(60, 40);
            this.btnFloat.TabIndex = 11;
            this.btnFloat.Text = ",";
            this.btnFloat.UseVisualStyleBackColor = true;
            this.btnFloat.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btnPercent
            // 
            this.btnPercent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPercent.Location = new System.Drawing.Point(144, 278);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(60, 40);
            this.btnPercent.TabIndex = 1;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnActionOperation);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(12, 232);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 40);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(78, 232);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 40);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(144, 232);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 40);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(144, 186);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 40);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(78, 186);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 40);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(12, 186);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 40);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(144, 140);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 40);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(78, 140);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 40);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(12, 140);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 40);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnActionNumber);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйToolStripMenuItem,
            this.инженерныйToolStripMenuItem,
            this.программистToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.toolStripSeparator1,
            this.журналToolStripMenuItem,
            this.группировкаЦифрПоToolStripMenuItem,
            this.toolStripSeparator2,
            this.обычныйToolStripMenuItem1,
            this.преобразованиеЕдиницToolStripMenuItem,
            this.вычислениеДатыToolStripMenuItem,
            this.листыToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.обычныйToolStripMenuItem.Text = "Обычный";
            // 
            // инженерныйToolStripMenuItem
            // 
            this.инженерныйToolStripMenuItem.Name = "инженерныйToolStripMenuItem";
            this.инженерныйToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.инженерныйToolStripMenuItem.Text = "Инженерный";
            // 
            // программистToolStripMenuItem
            // 
            this.программистToolStripMenuItem.Name = "программистToolStripMenuItem";
            this.программистToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.программистToolStripMenuItem.Text = "Программист";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(248, 6);
            // 
            // журналToolStripMenuItem
            // 
            this.журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            this.журналToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.журналToolStripMenuItem.Text = "Журнал";
            // 
            // группировкаЦифрПоToolStripMenuItem
            // 
            this.группировкаЦифрПоToolStripMenuItem.Name = "группировкаЦифрПоToolStripMenuItem";
            this.группировкаЦифрПоToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.группировкаЦифрПоToolStripMenuItem.Text = "Группировка цифр по разрядам";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(248, 6);
            // 
            // обычныйToolStripMenuItem1
            // 
            this.обычныйToolStripMenuItem1.Name = "обычныйToolStripMenuItem1";
            this.обычныйToolStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.обычныйToolStripMenuItem1.Text = "Обычный";
            // 
            // преобразованиеЕдиницToolStripMenuItem
            // 
            this.преобразованиеЕдиницToolStripMenuItem.Name = "преобразованиеЕдиницToolStripMenuItem";
            this.преобразованиеЕдиницToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.преобразованиеЕдиницToolStripMenuItem.Text = "Преобразование единиц";
            // 
            // вычислениеДатыToolStripMenuItem
            // 
            this.вычислениеДатыToolStripMenuItem.Name = "вычислениеДатыToolStripMenuItem";
            this.вычислениеДатыToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.вычислениеДатыToolStripMenuItem.Text = "Вычисление даты";
            // 
            // листыToolStripMenuItem
            // 
            this.листыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фывToolStripMenuItem,
            this.автолизингToolStripMenuItem,
            this.экономиямильгаллонToolStripMenuItem,
            this.экономияТопливол100кмToolStripMenuItem});
            this.листыToolStripMenuItem.Name = "листыToolStripMenuItem";
            this.листыToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.листыToolStripMenuItem.Text = "Листы";
            // 
            // фывToolStripMenuItem
            // 
            this.фывToolStripMenuItem.Name = "фывToolStripMenuItem";
            this.фывToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.фывToolStripMenuItem.Text = "Ипотека";
            // 
            // автолизингToolStripMenuItem
            // 
            this.автолизингToolStripMenuItem.Name = "автолизингToolStripMenuItem";
            this.автолизингToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.автолизингToolStripMenuItem.Text = "Автолизинг";
            // 
            // экономиямильгаллонToolStripMenuItem
            // 
            this.экономиямильгаллонToolStripMenuItem.Name = "экономиямильгаллонToolStripMenuItem";
            this.экономиямильгаллонToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.экономиямильгаллонToolStripMenuItem.Text = "Экономия (миль/галлон)";
            // 
            // экономияТопливол100кмToolStripMenuItem
            // 
            this.экономияТопливол100кмToolStripMenuItem.Name = "экономияТопливол100кмToolStripMenuItem";
            this.экономияТопливол100кмToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.экономияТопливол100кмToolStripMenuItem.Text = "Экономия топливо(л/100км)";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.toolStripSeparator3,
            this.журналToolStripMenuItem1});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(136, 6);
            // 
            // журналToolStripMenuItem1
            // 
            this.журналToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьЖурналToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.отменитьПравкуToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.журналToolStripMenuItem1.Name = "журналToolStripMenuItem1";
            this.журналToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.журналToolStripMenuItem1.Text = "Журнал";
            // 
            // копироватьЖурналToolStripMenuItem
            // 
            this.копироватьЖурналToolStripMenuItem.Name = "копироватьЖурналToolStripMenuItem";
            this.копироватьЖурналToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.копироватьЖурналToolStripMenuItem.Text = "Копировать журнал";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // отменитьПравкуToolStripMenuItem
            // 
            this.отменитьПравкуToolStripMenuItem.Name = "отменитьПравкуToolStripMenuItem";
            this.отменитьПравкуToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.отменитьПравкуToolStripMenuItem.Text = "Отменить правку";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьСправкуToolStripMenuItem,
            this.toolStripSeparator4,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // просмотретьСправкуToolStripMenuItem
            // 
            this.просмотретьСправкуToolStripMenuItem.Name = "просмотретьСправкуToolStripMenuItem";
            this.просмотретьСправкуToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.просмотретьСправкуToolStripMenuItem.Text = "Просмотреть справку";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(348, 332);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDepercent);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnSubstruct);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtCalcGUI);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCalc";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCalcGUI;
        private Button btnMultiply;
        private Button btnResult;
        private Button btnClear;
        private Button btnFactorial;
        private Button btnMin;
        private Button btnMax;
        private Button btnBack;
        private Button btnDivide;
        private Button btnSubstruct;
        private Button btnAddition;
        private Button btnSum;
        private Button btnCount;
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
    }
}
