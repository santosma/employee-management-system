using employee_management_system.Contracts;
using employee_management_system.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);
            return Save();
        }

        public bool Exists(int id)
        {
            return _db.LeaveAllocations.Any(q => q.Id == id);
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            return _db.LeaveAllocations.ToList();
        }

        public LeaveAllocation FindById(int id)
        {
            return _db.LeaveAllocations.Find(id);
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }
                
        public bool Update(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Update(entity);
            return Save();
        }

        public bool validate(string employeeId, int leaveTypeId)
        {
            var period = DateTime.Now.Year;
            return FindAll().Where(
                q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId && q.YearPeriod == period).Any();
        }
    }
}
