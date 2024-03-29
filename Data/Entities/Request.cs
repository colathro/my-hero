using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyHero.Data
{
    public class Request
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime DateRequested { get; set; }

        public int Status { get; set; }

        public Hero Hero { get; set; }

        public Requestor Requestor { get; set; }

    }
}