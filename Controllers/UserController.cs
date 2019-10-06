﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using MyHero.Data;
using Microsoft.EntityFrameworkCore;
using MyHero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHero.Controllers
{
    public class UserController 
    {
        private ApplicationDbContext dbcontext;

        public UserController(ApplicationDbContext _dbcontext)
        {
            dbcontext = _dbcontext;
        }

        public Requestor GetRequestor(string _userid)
        {
            var req = dbcontext.User.Where(r => r.Id == _userid).Include(e => e.Requestor).FirstOrDefault();
            return req.Requestor;
        }

        public Hero GetHero(string _userid)
        {
            var hero = dbcontext.User.Where(r => r.Id == _userid).Include(e => e.Hero).FirstOrDefault();
            return hero.Hero;
        }
    }
}
