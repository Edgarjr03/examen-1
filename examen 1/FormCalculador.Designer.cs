namespace examen_1
{
    partial class FormCalculador
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
            txb_SueldoMensual = new TextBox();
            label1 = new Label();
            btn_Calcular = new Button();
            label2 = new Label();
            txb_ISR = new TextBox();
            label6 = new Label();
            txb_SueldoNeto = new TextBox();
            SuspendLayout();
            // 
            // txb_SueldoMensual
            // 
            txb_SueldoMensual.Location = new Point(280, 61);
            txb_SueldoMensual.Name = "txb_SueldoMensual";
            txb_SueldoMensual.Size = new Size(150, 31);
            txb_SueldoMensual.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 33);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 1;
            label1.Text = "Sueldo Mensual";
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location = new Point(298, 123);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(112, 34);
            btn_Calcular.TabIndex = 2;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 95);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 10;
            label2.Text = "ISR";
            // 
            // txb_ISR
            // 
            txb_ISR.Location = new Point(26, 123);
            txb_ISR.Name = "txb_ISR";
            txb_ISR.Size = new Size(234, 31);
            txb_ISR.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(501, 95);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 14;
            label6.Text = "Sueldo neto";
            // 
            // txb_SueldoNeto
            // 
            txb_SueldoNeto.Location = new Point(436, 123);
            txb_SueldoNeto.Name = "txb_SueldoNeto";
            txb_SueldoNeto.Size = new Size(226, 31);
            txb_SueldoNeto.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 189);
            Controls.Add(label6);
            Controls.Add(txb_SueldoNeto);
            Controls.Add(label2);
            Controls.Add(txb_ISR);
            Controls.Add(btn_Calcular);
            Controls.Add(label1);
            Controls.Add(txb_SueldoMensual);
            Name = "Form1";
            Text = "Calculador de ISR y Sueldo neto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_SueldoMensual;
        private Label label1;
        private Button btn_Calcular;
        private Label label2;
        private TextBox txb_ISR;
        private Label label6;
        private TextBox txb_SueldoNeto;
    }
}
