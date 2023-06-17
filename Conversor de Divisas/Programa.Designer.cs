namespace Conversor_de_Divisas
{
    partial class fr_Programa
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
            lb_Updates = new Label();
            lb_Euro = new Label();
            lb_Cotizaciones = new Label();
            lb_Actualizacion = new Label();
            tb_Cantidad = new TextBox();
            lb_Cantidad = new Label();
            lb_Moneda1 = new Label();
            cb_Moneda1 = new ComboBox();
            cb_Moneda2 = new ComboBox();
            lb_Resultado = new Label();
            pb_Flecha = new PictureBox();
            lb_Resultado2 = new Label();
            bt_Convertir = new Button();
            bt_About = new Button();
            bt_ChangeLog = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_Flecha).BeginInit();
            SuspendLayout();
            // 
            // lb_Updates
            // 
            lb_Updates.AutoSize = true;
            lb_Updates.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Updates.ForeColor = Color.Yellow;
            lb_Updates.Location = new Point(12, 223);
            lb_Updates.Name = "lb_Updates";
            lb_Updates.Size = new Size(149, 14);
            lb_Updates.TabIndex = 0;
            lb_Updates.Text = "Últimas Cotizaciones:";
            // 
            // lb_Euro
            // 
            lb_Euro.AutoSize = true;
            lb_Euro.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Euro.ForeColor = Color.White;
            lb_Euro.Location = new Point(12, 242);
            lb_Euro.Name = "lb_Euro";
            lb_Euro.Size = new Size(42, 14);
            lb_Euro.TabIndex = 1;
            lb_Euro.Text = "Euro:";
            // 
            // lb_Cotizaciones
            // 
            lb_Cotizaciones.AutoSize = true;
            lb_Cotizaciones.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Cotizaciones.Location = new Point(12, 256);
            lb_Cotizaciones.Name = "lb_Cotizaciones";
            lb_Cotizaciones.Size = new Size(109, 14);
            lb_Cotizaciones.TabIndex = 2;
            lb_Cotizaciones.Text = "1 € = 1,0768 $";
            // 
            // lb_Actualizacion
            // 
            lb_Actualizacion.AutoSize = true;
            lb_Actualizacion.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Actualizacion.Location = new Point(12, 439);
            lb_Actualizacion.Name = "lb_Actualizacion";
            lb_Actualizacion.Size = new Size(148, 13);
            lb_Actualizacion.TabIndex = 3;
            lb_Actualizacion.Text = "Última Actualización: ";
            // 
            // tb_Cantidad
            // 
            tb_Cantidad.BackColor = Color.Black;
            tb_Cantidad.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Cantidad.ForeColor = Color.White;
            tb_Cantidad.Location = new Point(12, 40);
            tb_Cantidad.MaxLength = 9;
            tb_Cantidad.Name = "tb_Cantidad";
            tb_Cantidad.Size = new Size(192, 43);
            tb_Cantidad.TabIndex = 4;
            // 
            // lb_Cantidad
            // 
            lb_Cantidad.AutoSize = true;
            lb_Cantidad.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Cantidad.ForeColor = Color.Yellow;
            lb_Cantidad.Location = new Point(12, 22);
            lb_Cantidad.Name = "lb_Cantidad";
            lb_Cantidad.Size = new Size(65, 14);
            lb_Cantidad.TabIndex = 5;
            lb_Cantidad.Text = "Cantidad";
            // 
            // lb_Moneda1
            // 
            lb_Moneda1.AutoSize = true;
            lb_Moneda1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Moneda1.ForeColor = Color.Yellow;
            lb_Moneda1.Location = new Point(12, 95);
            lb_Moneda1.Name = "lb_Moneda1";
            lb_Moneda1.Size = new Size(58, 14);
            lb_Moneda1.TabIndex = 6;
            lb_Moneda1.Text = "Moneda";
            // 
            // cb_Moneda1
            // 
            cb_Moneda1.BackColor = Color.Black;
            cb_Moneda1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cb_Moneda1.ForeColor = Color.White;
            cb_Moneda1.FormattingEnabled = true;
            cb_Moneda1.Items.AddRange(new object[] { "$ - Dólar Estadounidense", "$ - Dólar Canadiense", "$ - Dólar Australiano", "€ - Euro", "F - Franco Suizo", "£ - Libra Esterlina", "¥ - Renminbi Chino", "S - Sol Peruano", "¥ - Yen Japonés" });
            cb_Moneda1.Location = new Point(12, 112);
            cb_Moneda1.Name = "cb_Moneda1";
            cb_Moneda1.Size = new Size(192, 22);
            cb_Moneda1.TabIndex = 7;
            // 
            // cb_Moneda2
            // 
            cb_Moneda2.BackColor = Color.Black;
            cb_Moneda2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cb_Moneda2.ForeColor = Color.White;
            cb_Moneda2.FormattingEnabled = true;
            cb_Moneda2.Items.AddRange(new object[] { "$ - Dólar Estadounidense", "$ - Dólar Canadiense", "$ - Dólar Australiano", "€ - Euro", "F - Franco Suizo", "£ - Libra Esterlina", "¥ - Renminbi Chino", "S - Sol Peruano", "¥ - Yen Japonés" });
            cb_Moneda2.Location = new Point(12, 181);
            cb_Moneda2.Name = "cb_Moneda2";
            cb_Moneda2.Size = new Size(192, 22);
            cb_Moneda2.TabIndex = 11;
            // 
            // lb_Resultado
            // 
            lb_Resultado.AutoSize = true;
            lb_Resultado.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Resultado.ForeColor = Color.Yellow;
            lb_Resultado.Location = new Point(296, 22);
            lb_Resultado.Name = "lb_Resultado";
            lb_Resultado.Size = new Size(72, 14);
            lb_Resultado.TabIndex = 9;
            lb_Resultado.Text = "Resultado";
            // 
            // pb_Flecha
            // 
            pb_Flecha.Image = Properties.Resources.flecha;
            pb_Flecha.Location = new Point(86, 140);
            pb_Flecha.Name = "pb_Flecha";
            pb_Flecha.Size = new Size(35, 35);
            pb_Flecha.TabIndex = 12;
            pb_Flecha.TabStop = false;
            // 
            // lb_Resultado2
            // 
            lb_Resultado2.AutoSize = true;
            lb_Resultado2.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Resultado2.ForeColor = Color.White;
            lb_Resultado2.Location = new Point(255, 43);
            lb_Resultado2.Name = "lb_Resultado2";
            lb_Resultado2.Size = new Size(0, 35);
            lb_Resultado2.TabIndex = 13;
            lb_Resultado2.TextAlign = ContentAlignment.TopCenter;
            // 
            // bt_Convertir
            // 
            bt_Convertir.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Convertir.Location = new Point(255, 123);
            bt_Convertir.Name = "bt_Convertir";
            bt_Convertir.Size = new Size(131, 52);
            bt_Convertir.TabIndex = 14;
            bt_Convertir.Text = "Convertir";
            bt_Convertir.UseVisualStyleBackColor = true;
            bt_Convertir.Click += bt_Convertir_Click;
            // 
            // bt_About
            // 
            bt_About.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_About.Location = new Point(338, 426);
            bt_About.Name = "bt_About";
            bt_About.Size = new Size(84, 23);
            bt_About.TabIndex = 15;
            bt_About.Text = "Sobre";
            bt_About.UseVisualStyleBackColor = true;
            bt_About.Click += bt_About_Click;
            // 
            // bt_ChangeLog
            // 
            bt_ChangeLog.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_ChangeLog.Location = new Point(338, 397);
            bt_ChangeLog.Name = "bt_ChangeLog";
            bt_ChangeLog.Size = new Size(84, 23);
            bt_ChangeLog.TabIndex = 16;
            bt_ChangeLog.Text = "ChangeLog";
            bt_ChangeLog.UseVisualStyleBackColor = true;
            bt_ChangeLog.Click += bt_ChangeLog_Click;
            // 
            // fr_Programa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(434, 461);
            Controls.Add(bt_ChangeLog);
            Controls.Add(bt_About);
            Controls.Add(bt_Convertir);
            Controls.Add(lb_Resultado2);
            Controls.Add(pb_Flecha);
            Controls.Add(cb_Moneda2);
            Controls.Add(lb_Resultado);
            Controls.Add(cb_Moneda1);
            Controls.Add(lb_Moneda1);
            Controls.Add(lb_Cantidad);
            Controls.Add(tb_Cantidad);
            Controls.Add(lb_Actualizacion);
            Controls.Add(lb_Cotizaciones);
            Controls.Add(lb_Euro);
            Controls.Add(lb_Updates);
            Name = "fr_Programa";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb_Flecha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Updates;
        private Label lb_Euro;
        private Label lb_Cotizaciones;
        private Label lb_Actualizacion;
        private TextBox tb_Cantidad;
        private Label lb_Cantidad;
        private Label lb_Moneda1;
        private ComboBox cb_Moneda1;
        private ComboBox cb_Moneda2;
        private Label lb_Resultado;
        private PictureBox pb_Flecha;
        private Label lb_Resultado2;
        private Button bt_Convertir;
        private Button bt_About;
        private Button bt_ChangeLog;
    }
}