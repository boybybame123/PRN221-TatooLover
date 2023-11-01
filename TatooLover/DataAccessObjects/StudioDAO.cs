﻿using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class StudioDAO
    {
        Prn221TatooLoverContext db = new Prn221TatooLoverContext();
        public List<Studio> GetStudios() => db.Studios.ToList();
        public Studio GetStudioByCode(string code)
        {
            var studio =  db.Studios.FirstOrDefault(s => s.Code.Equals(code));

            if (studio == null)
            {
                throw new Exception();
            }
            return studio;
        }
    }
}
