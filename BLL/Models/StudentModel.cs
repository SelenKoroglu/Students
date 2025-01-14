﻿#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Models
{
    internal class StudentModel
    {
        public Student Record { get; }
        public int Id => Record.Id;
        public string Name => Record.Name;

        public string Surname => Record.Surname;

        public DateTime BirthDate => Record.BirthDate;

        public decimal Gpa => Record.Gpa;

    }

}
