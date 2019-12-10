using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AgendaTrabalhoFinal.Model
{
    public class Evento
    {
        private uint iD;
        private string nomeEvento;
        private DateTime dataEvento;
        private TimeSpan horaInicial;
        private TimeSpan horaFinal;

        [PrimaryKey, AutoIncrement]
        public uint ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string NomeEvento
        {
            get { return nomeEvento; }
            set { nomeEvento = value; }
        }
        public DateTime DataEvento
        {
            get { return dataEvento; }
            set { dataEvento = value; }
        }
        public TimeSpan HoraInicial
        {
            get { return horaInicial; }
            set { horaInicial = value; }
        }
        public TimeSpan HoraFinal
        {
            get { return horaFinal; }
            set { horaFinal = value; }
        }
        public string DescricaoEvento { get; set; }

        public string ExibicaoEvento => "[" + DataEvento.ToString("dd/MM/yyyy") + " " + HoraInicial + "] - " +  nomeEvento;
        public string DataEventoFormatado => "[" + DataEvento.ToString("dd/MM/yyyy") + "]";
        public string HoraInicialFormatado => "[" + HoraInicial + "]";
        public string HoraFinalFormatado => "[" + HoraFinal + "]";
    }
}
