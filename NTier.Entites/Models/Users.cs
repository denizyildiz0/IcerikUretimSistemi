﻿using IcerikUretimSistemi.Entites.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Entites.Models
{
    public class Users:BaseEntity
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public ICollection<Posts>? Posts { get; set; }
        public ICollection<Comments>? Comments { get; set; }
        public ICollection<Likes>? Likes { get; set; }
        public ICollection<Follows>? Followers { get; set; }
        public ICollection<Follows>? Following { get; set; }
    }
}
