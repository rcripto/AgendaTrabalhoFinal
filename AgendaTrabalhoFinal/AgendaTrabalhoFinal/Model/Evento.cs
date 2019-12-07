using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AgendaTrabalhoFinal.Model
{
    public class Evento
    {
        [PrimaryKey, AutoIncrement]
        public uint ID { get; set; }
        public string NomeEvento { get; set; }
        public DateTime DataEvento { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public string DescricaoEvento { get; set; }
    }
}
