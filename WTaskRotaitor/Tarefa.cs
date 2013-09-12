using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WTaskRotaitor
{
    class Tarefa
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Autor { get; set; }
        public string Atribuido { get; set; }
        public float? TempoEstimado { get; set; }
        public float TempoGasto { get; set; }
        public float? PercentualTerminado { get; set; }
        public string Nota { get; set; }


        public List<EntradaDeTempo> EntradaDeTempo { get; set; }

        public Tarefa()
        {
            EntradaDeTempo = new List<EntradaDeTempo>();

        }

        public decimal GetTempoGasto()
        {
            if (EntradaDeTempo.Count > 0)
            {
                decimal total = 0;
                foreach (var i in EntradaDeTempo)
                {
                    total  = total +  i.TempoGasto;
                }
                return total;
            }
            return 0.0m;
        }

        public string GetTarefaEmDia(float p)
        {
            //TarefaEmdia =  TempoGasto TempoPrevisto PercentualCompetado
            //                  5          10              50% 
            //                  x     =      y*0.5           50/100
            //                  x     =      y*p/100
            //                  5     =    10*50/100 
            //                  2     <    10*50/100 
            //tarefaAtrasda  =  7           10            50%
            //                  7     >     10*50/100

            //if ( tbTempoGasto == TempoPrevisto*percentua/100) || (tbTempoGasto < TempoPrevisto*percentua/100)          
/*
            try
            {
                if (((float)GetTempoGasto() == (TempoEstimado.Value * p / 100)) || ((float)GetTempoGasto() < TempoEstimado.Value * p / 100))
                {
                    // TAREFA EM DIA
                    return "EMDIA";
                }
                else
                {
                    // tarefa Atrasada
                    return "ATRASADA";
                }
            }
            catch (Exception e)
            {

                return "";
            }*/

            return "";
        }

        public string IdProjeto { get; set; }

        public int Status { get; set; }
    }
}
