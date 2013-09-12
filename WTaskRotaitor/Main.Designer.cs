namespace WTaskRotaitor
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lTempo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.cbTarefa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNome1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTempoEstimado = new System.Windows.Forms.TextBox();
            this.tbTempoGasto = new System.Windows.Forms.TextBox();
            this.bUpdate = new System.Windows.Forms.Button();
            this.cbTerminado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bIniciar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bFecharTarefa = new System.Windows.Forms.Button();
            this.timerUpdateRed = new System.Windows.Forms.Timer(this.components);
            this.bTick = new System.Windows.Forms.Button();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbChave = new System.Windows.Forms.TextBox();
            this.bConetar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lTarefaEmDia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIdProjeto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player2";
            // 
            // lTempo
            // 
            this.lTempo.AutoSize = true;
            this.lTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTempo.Location = new System.Drawing.Point(46, 155);
            this.lTempo.Name = "lTempo";
            this.lTempo.Size = new System.Drawing.Size(145, 55);
            this.lTempo.TabIndex = 3;
            this.lTempo.Text = "15:00";
            this.lTempo.Click += new System.EventHandler(this.lTempo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cometario para finalização da tarefa";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(56, 244);
            this.tbNota.Multiline = true;
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(675, 112);
            this.tbNota.TabIndex = 5;
            // 
            // cbTarefa
            // 
            this.cbTarefa.FormattingEnabled = true;
            this.cbTarefa.Location = new System.Drawing.Point(86, 30);
            this.cbTarefa.Name = "cbTarefa";
            this.cbTarefa.Size = new System.Drawing.Size(640, 21);
            this.cbTarefa.TabIndex = 6;
            this.cbTarefa.SelectedIndexChanged += new System.EventHandler(this.cbTarefa_SelectedIndexChanged);
            this.cbTarefa.DropDownClosed += new System.EventHandler(this.cbTarefa_DropDownClosed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tarefa ";
            // 
            // cbNome1
            // 
            this.cbNome1.FormattingEnabled = true;
            this.cbNome1.Location = new System.Drawing.Point(86, 57);
            this.cbNome1.Name = "cbNome1";
            this.cbNome1.Size = new System.Drawing.Size(265, 21);
            this.cbNome1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tempo Estimado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tempo Gasto";
            // 
            // tbTempoEstimado
            // 
            this.tbTempoEstimado.Location = new System.Drawing.Point(131, 89);
            this.tbTempoEstimado.Name = "tbTempoEstimado";
            this.tbTempoEstimado.Size = new System.Drawing.Size(100, 20);
            this.tbTempoEstimado.TabIndex = 11;
            // 
            // tbTempoGasto
            // 
            this.tbTempoGasto.Location = new System.Drawing.Point(549, 92);
            this.tbTempoGasto.Name = "tbTempoGasto";
            this.tbTempoGasto.Size = new System.Drawing.Size(176, 20);
            this.tbTempoGasto.TabIndex = 12;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(656, 143);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 13;
            this.bUpdate.Text = "update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // cbTerminado
            // 
            this.cbTerminado.FormattingEnabled = true;
            this.cbTerminado.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%"});
            this.cbTerminado.Location = new System.Drawing.Point(549, 145);
            this.cbTerminado.Name = "cbTerminado";
            this.cbTerminado.Size = new System.Drawing.Size(101, 21);
            this.cbTerminado.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "% Terminado";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(461, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(265, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // bIniciar
            // 
            this.bIniciar.Location = new System.Drawing.Point(445, 177);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(141, 35);
            this.bIniciar.TabIndex = 17;
            this.bIniciar.Text = "Iniciar Tarefa";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(549, 116);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bFecharTarefa
            // 
            this.bFecharTarefa.Location = new System.Drawing.Point(56, 364);
            this.bFecharTarefa.Name = "bFecharTarefa";
            this.bFecharTarefa.Size = new System.Drawing.Size(675, 35);
            this.bFecharTarefa.TabIndex = 21;
            this.bFecharTarefa.Text = "Fechar Tarefa";
            this.bFecharTarefa.UseVisualStyleBackColor = true;
            this.bFecharTarefa.Click += new System.EventHandler(this.bFecharTarefa_Click);
            // 
            // timerUpdateRed
            // 
            this.timerUpdateRed.Interval = 3600000;
            this.timerUpdateRed.Tick += new System.EventHandler(this.timerUpdateRed_Tick);
            // 
            // bTick
            // 
            this.bTick.Location = new System.Drawing.Point(606, 183);
            this.bTick.Name = "bTick";
            this.bTick.Size = new System.Drawing.Size(125, 23);
            this.bTick.TabIndex = 22;
            this.bTick.Text = "Tick";
            this.bTick.UseVisualStyleBackColor = true;
            this.bTick.Click += new System.EventHandler(this.bTick_Click);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(55, 0);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(176, 20);
            this.tbHost.TabIndex = 23;
            this.tbHost.Text = "http://192.168.0.16/redmine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "ip";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Chave";
            // 
            // tbChave
            // 
            this.tbChave.Location = new System.Drawing.Point(281, 2);
            this.tbChave.Name = "tbChave";
            this.tbChave.Size = new System.Drawing.Size(245, 20);
            this.tbChave.TabIndex = 26;
            this.tbChave.Text = "5e91791320b92a5b4f006ec756aad05dfc48b343";
            // 
            // bConetar
            // 
            this.bConetar.Location = new System.Drawing.Point(670, 2);
            this.bConetar.Name = "bConetar";
            this.bConetar.Size = new System.Drawing.Size(61, 23);
            this.bConetar.TabIndex = 27;
            this.bConetar.Text = "Conectar ";
            this.bConetar.UseVisualStyleBackColor = true;
            this.bConetar.Click += new System.EventHandler(this.bConetar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "A Tarefa está : ";
            // 
            // lTarefaEmDia
            // 
            this.lTarefaEmDia.AutoSize = true;
            this.lTarefaEmDia.Location = new System.Drawing.Point(151, 126);
            this.lTarefaEmDia.Name = "lTarefaEmDia";
            this.lTarefaEmDia.Size = new System.Drawing.Size(25, 13);
            this.lTarefaEmDia.TabIndex = 29;
            this.lTarefaEmDia.Text = "------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(533, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Projeto";
            // 
            // tbIdProjeto
            // 
            this.tbIdProjeto.Location = new System.Drawing.Point(576, 4);
            this.tbIdProjeto.Name = "tbIdProjeto";
            this.tbIdProjeto.Size = new System.Drawing.Size(51, 20);
            this.tbIdProjeto.TabIndex = 31;
            this.tbIdProjeto.Text = "1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 541);
            this.Controls.Add(this.tbIdProjeto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lTarefaEmDia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bConetar);
            this.Controls.Add(this.tbChave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.bTick);
            this.Controls.Add(this.bFecharTarefa);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTerminado);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.tbTempoGasto);
            this.Controls.Add(this.tbTempoEstimado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbNome1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTarefa);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lTempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "TaskRotaitor ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lTempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.ComboBox cbTarefa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNome1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTempoEstimado;
        private System.Windows.Forms.TextBox tbTempoGasto;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.ComboBox cbTerminado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bFecharTarefa;
        private System.Windows.Forms.Timer timerUpdateRed;
        private System.Windows.Forms.Button bTick;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbChave;
        private System.Windows.Forms.Button bConetar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lTarefaEmDia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbIdProjeto;
    }
}

