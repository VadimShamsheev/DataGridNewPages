using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Xaml.Behaviors.Media;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVVMLearn.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CompanyId { get; set; }
        public decimal Price { get; set; }
        public string Definition { get; set; }
        public string ImageSource { get; set; }

        public Company CompanyEntity { get; set; }
    }
}
