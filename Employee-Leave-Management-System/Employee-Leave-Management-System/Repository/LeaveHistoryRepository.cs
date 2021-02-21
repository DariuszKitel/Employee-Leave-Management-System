using Employee_Leave_Management_System.Contracts;
using Employee_Leave_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Leave_Management_System.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICollection<LeaveHistory> FindAll()
        {
            return _db.LeaveHistories.ToList();
        }

        public LeaveHistory FindById(int id)
        {
            return _db.LeaveHistories.Find(id);
        }
        public bool Create(LeaveHistory entity)
        {
            _db.LeaveHistories.Add(entity);
            return Save();
        }
        public bool Delete(LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);
            return Save();
        }
        public bool Save()
        {
            var saved = _db.SaveChanges();
            return saved > 0;
        }
        public bool Update(LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);
            return Save();
        }
    }
}
