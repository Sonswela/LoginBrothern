using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories
{
    public class StudentRepository
    {
        private ApplicationDbContext context;

        public StudentRepository()
        {
            context = new ApplicationDbContext();
        }

        public List<Student> GetAllStudents()
        {
            return context.students.ToList();
        }
        
        public void AddStudent(Student toAdd)
        {
            context.students.Add(toAdd);
            context.SaveChanges();
        }

        public Student GetStudentByID(int id)
        {
            return context.students.Find(id);
        }

        public void SaveEdits(Student toSave)
        {
            context.Entry(toSave).State = EntityState.Modified;
            context.SaveChanges();

        }
        public void DeleteStudents(Student toDelete)
        {
            context.students.Remove(toDelete);
            context.SaveChanges();
        }
    }
}