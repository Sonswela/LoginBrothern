﻿using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class StudentService
    {

        private StudentRepository repository;

        public StudentService()
        {
            repository = new StudentRepository();
        }

        public List<Student> GetAllStudents()
        {
            return repository.GetAllStudents();
        }

        public void AddStudent(Student toAdd)
        {
            repository.AddStudent(toAdd);
        }

        public Student GetStudentById(int id)
        {
            return repository.GetStudentByID(id);
        }

        public void SaveEdits(Student toSave)
        {
            repository.SaveEdits(toSave);
        }

        public void DeleteStudent(Student toDelete)
        {
            repository.DeleteStudents(toDelete);
        }
    }
}