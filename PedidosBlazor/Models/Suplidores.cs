﻿using PedidosBlazor.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosBlazor.Models
{
    public class Suplidores
    {
        [Key]
        public int SuplidorId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombres { get; set; }
    }
}