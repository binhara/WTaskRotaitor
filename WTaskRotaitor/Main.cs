using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WTaskRotaitor
{
    public partial class Main : Form
    {
        private RedmineConection _redmine; 
        private Cronometro Crono = new  Cronometro();

        public Main()
        {
            InitializeComponent();
        }

        private void bTroca_Click(object sender, EventArgs e)
        {
          
           

        }

        private void Main_Load(object sender, EventArgs e)
        {
           


        }

        private void cbTarefa_SelectedValueChanged(object sender, EventArgs e)
        {
          


        }

        private void cbTarefa_DropDownClosed(object sender, EventArgs e)
        {

            if (cbTarefa.SelectedItem != null)
            {                
                Tarefa t = (Tarefa)cbTarefa.SelectedItem;
                tbTempoEstimado.Text = t.TempoEstimado.ToString();
                tbTempoGasto.Text = t.GetTempoGasto().ToString();
                //tbTerminado.Text = t.PercentualTerminado.ToString();
                progressBar1.Value = Convert.ToInt32(t.PercentualTerminado.ToString());
                lTarefaEmDia.Text = t.GetTarefaEmDia(progressBar1.Value);
         
            }

        }

        private void cbTarefa_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (cbTarefa.SelectedItem != null)
            {
                Tarefa t = (Tarefa) cbTarefa.SelectedItem;
                t.IdProjeto = tbIdProjeto.Text;
                t.PercentualTerminado = (float)Convert.ToDouble(cbTerminado.SelectedItem.ToString().Substring(0, 2));
                progressBar1.Value = (int)t.PercentualTerminado;
                cbTerminado.SelectedText = (int)t.PercentualTerminado + "%";
                _redmine.update(t);// fazendo o update na tarefa              
            }
        }

        private void AtualizacaoDeTempo(int horas, Tarefa t)
        {
            _redmine.NovaEntradaDeTempo(horas, t, DateTime.Now);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lTempo.Text = Crono.getTempo();
            

        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            Crono.Start();
            lTempo.Text = Crono.getTempo();
            timerUpdateRed.Enabled = true; 
            //mudar o status da tarefa para iniciada
            if (cbTarefa.SelectedItem != null)
            {
                Tarefa t = (Tarefa)cbTarefa.SelectedItem;
                t.IdProjeto = tbIdProjeto.Text;               
                t.Status = 2; //resolvida                  
                _redmine.update(t);// fazendo o update na tarefa              
            }
           

        }

        private void bPausa_Click(object sender, EventArgs e)
        {
            //if (Crono.estaParado())
            //{
            //    bPausa.Text = "Reiniciar";
            //    Crono.Stop();
            //}
            //else
            //{
            //    bPausa.Text = "Pausa";
            //    Crono.Start();
            //}



        }

        private void bFecharTarefa_Click(object sender, EventArgs e)
        {
            if (cbTarefa.SelectedItem != null)
            {
                Tarefa t = (Tarefa)cbTarefa.SelectedItem;
                t.IdProjeto = tbIdProjeto.Text;
                t.PercentualTerminado = 100;              
                t.Nota = tbNota.Text;
                t.Status = 3; //resolvida                  
                _redmine.update(t);// fazendo o update na tarefa              
            }

        }

        private void timerUpdateRed_Tick(object sender, EventArgs e)
        {
            //aqui vai fazer um update de tempo a cada hora de trabalho

            if (cbTarefa.SelectedItem != null)
            {
                Tarefa t = (Tarefa)cbTarefa.SelectedItem;
                t.IdProjeto = tbIdProjeto.Text;                  
                AtualizacaoDeTempo(1, t);
            }

            
        }

        private void bTick_Click(object sender, EventArgs e)
        {
            //aqui vai fazer um update de tempo a cada hora de trabalho

            if (cbTarefa.SelectedItem != null)
            {
                Tarefa t = (Tarefa)cbTarefa.SelectedItem;
                t.IdProjeto = tbIdProjeto.Text;
                AtualizacaoDeTempo(1, t);
                tbTempoGasto.Text = t.GetTempoGasto().ToString();        
                lTarefaEmDia.Text = t.GetTarefaEmDia(progressBar1.Value);
            }

        }

        private void lTempo_Click(object sender, EventArgs e)
        {

        }

        private void bConetar_Click(object sender, EventArgs e)
        {
            _redmine = new RedmineConection(tbHost.Text, tbChave.Text);
            var l = _redmine.ListarTarefas(tbIdProjeto.Text);
            //var users = _redmine.ListarUsuario();
            cbTarefa.DataSource = l;
            cbTarefa.DisplayMember = "Subject";

            //cbNome1.DataBindings = _redmine.ListarUsuario();

        }

       
    }
}
