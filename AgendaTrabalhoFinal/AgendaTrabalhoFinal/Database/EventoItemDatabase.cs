using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using AgendaTrabalhoFinal.Model;

namespace AgendaTrabalhoFinal.Database
{
    public class EventoItemDatabase
    {
        readonly SQLiteAsyncConnection database;

        public EventoItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Evento>().Wait();
        }

        public Task<List<Evento>> GetItemsAsync()
        {
            return database.Table<Evento>().ToListAsync();
        }

        public Task<Evento> GetItemAsync(uint id)
        {
            return database.Table<Evento>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Evento item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Evento item)
        {
            return database.DeleteAsync(item);
        }
    }
}
