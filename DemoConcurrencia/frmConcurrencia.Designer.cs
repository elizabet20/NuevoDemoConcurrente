namespace DemoConcurrencia
{
    partial class frmConcurrencia
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
            splitContainer1 = new SplitContainer();
            btnCancelarHilo = new Button();
            btnIniciarTarea = new Button();
            btnIniciarHilo = new Button();
            btnSecuencial = new Button();
            txtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCancelarHilo);
            splitContainer1.Panel1.Controls.Add(btnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(btnIniciarHilo);
            splitContainer1.Panel1.Controls.Add(btnSecuencial);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // btnCancelarHilo
            // 
            btnCancelarHilo.Location = new Point(46, 232);
            btnCancelarHilo.Name = "btnCancelarHilo";
            btnCancelarHilo.Size = new Size(110, 38);
            btnCancelarHilo.TabIndex = 3;
            btnCancelarHilo.Text = "Cancelar Hilo";
            btnCancelarHilo.UseVisualStyleBackColor = true;
            btnCancelarHilo.Click += btnCancelarHilo_Click;
            // 
            // btnIniciarTarea
            // 
            btnIniciarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarTarea.Location = new Point(44, 150);
            btnIniciarTarea.Name = "btnIniciarTarea";
            btnIniciarTarea.Size = new Size(112, 38);
            btnIniciarTarea.TabIndex = 2;
            btnIniciarTarea.Text = "Iniciar Tarea";
            btnIniciarTarea.UseVisualStyleBackColor = true;
            btnIniciarTarea.Click += btnIniciarTarea_Click;
            // 
            // btnIniciarHilo
            // 
            btnIniciarHilo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarHilo.Location = new Point(44, 81);
            btnIniciarHilo.Name = "btnIniciarHilo";
            btnIniciarHilo.Size = new Size(112, 39);
            btnIniciarHilo.TabIndex = 1;
            btnIniciarHilo.Text = "Iniciar Hilo";
            btnIniciarHilo.UseVisualStyleBackColor = true;
            btnIniciarHilo.Click += btnIniciarHilo_Click;
            // 
            // btnSecuencial
            // 
            btnSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSecuencial.Location = new Point(44, 12);
            btnSecuencial.Name = "btnSecuencial";
            btnSecuencial.Size = new Size(112, 35);
            btnSecuencial.TabIndex = 0;
            btnSecuencial.Text = "Iniciar Secuencial";
            btnSecuencial.UseVisualStyleBackColor = true;
            btnSecuencial.Click += button1_Click;
            // 
            // txtResultado
            // 
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Location = new Point(0, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(530, 450);
            txtResultado.TabIndex = 0;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // frmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmConcurrencia";
            Text = "Demostración de Concurrencia";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnIniciarTarea;
        private Button btnIniciarHilo;
        private Button btnSecuencial;
        private TextBox txtResultado;
        private Button btnCancelarHilo;
    }
}
