using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WTaskRotaitor
{
    class RedmineConection
    {
        RedmineManager _manager;

        public RedmineConection(string host, string apiKey)
        {
           // string host = "http://192.168.200.57/redmine";
           // string apiKey = "b261b9cbf156a6ccf80b8261af60f729ea89e502";
            _manager = new RedmineManager(host, apiKey);

        }

        public List<Tarefa> ListarTarefas(string idprojeto)
        {
           // var parameters = new NameValueCollection { { "project_id", idprojeto } };
            var parameters = new NameValueCollection();
            parameters.Add("project_id", idprojeto);
            parameters.Add("limit", "1000");

            List<Tarefa> lista = new List<Tarefa>();      
            try
            {

                foreach (var issue in _manager.GetObjectList<Issue>(parameters))
                {
                    var tarefa = new Tarefa { Id = issue.Id, Subject = issue.Subject, Autor = issue.Author.Name, TempoEstimado = issue.EstimatedHours , PercentualTerminado = issue.DoneRatio};
                    tarefa.EntradaDeTempo =  ListarTempoGasto(tarefa.Id.ToString());
                    lista.Add(tarefa);
                }

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO:" + ex.ToString());
            }
            return lista; 

        }

        public List<Projeto> ListarProjeto()
        {
            var parameters = new NameValueCollection { { "Id", "15" } };
            List<Projeto> lista = new List<Projeto>();
            foreach (var issue in _manager.GetObjectList<Project>(parameters))
                lista.Add(new Projeto { Id = issue.Id, Nome = issue.Name });
            return lista;            
        }


        public List<Usuario> ListarUsuario()
        {
            var parameters = new NameValueCollection { { "Id", "*" } };
            List<Usuario> lista = new List<Usuario>();
            foreach (var i in _manager.GetObjectList<User>(parameters))
                lista.Add(new Usuario {  Nome = i.FirstName , Email = i.Email  });
            return lista;    
        }

        public List<EntradaDeTempo> ListarTempoGasto(string idtarefa)
        {
            var parameters = new NameValueCollection { { "issue_id", idtarefa } };
            List<EntradaDeTempo> lista = new List<EntradaDeTempo>();
            foreach (var i in _manager.GetObjectList<TimeEntry>(parameters))
                lista.Add(new EntradaDeTempo { TempoGasto = i.Hours });
            return lista; 
        }

        public void update(Tarefa t)
        { 
            //Create a issue.
            var i = new Issue
            {
                Id = t.Id,
                Project = new IdentifiableName { Id = int.Parse(t.IdProjeto) },
                Notes = t.Nota,
                //EstimatedHours =  14,                
                DoneRatio = t.PercentualTerminado,
                Subject = t.Subject,
                Status = new IdentifiableName { Id = t.Status } 
            };
            _manager.UpdateObject(t.Id.ToString(),i);
            
        }

        public void NovaEntradaDeTempo(decimal hora, Tarefa t, DateTime? data)
        {

            var i = new TimeEntry
            {
                Issue = new IdentifiableName { Id = t.Id },
                Hours = hora,
                Activity = new IdentifiableName { Id = 1 },
                SpentOn = DateTime.Now.Date        
                

            };

            _manager.CreateObject(i);

        }
    }
}
