using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Entities
{
    public class Compromisso
    {
        public int IdCompromisso { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public DateTime DataFim { get; set; }
        public TimeSpan HoraFim { get; set; }
        public int IdUsuario { get; set; }

        public Compromisso()
        {

        }

        public Compromisso(int idCompromisso, string titulo, string descricao, DateTime dataInicio, TimeSpan horaInicio, DateTime dataFim, TimeSpan horaFim, int idUsuario)
        {
            IdCompromisso = idCompromisso;
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            HoraInicio = horaInicio;
            DataFim = dataFim;
            HoraFim = horaFim;
            IdUsuario = idUsuario;
        }

        public Usuario Usuario {  get; set; }
    }
}
