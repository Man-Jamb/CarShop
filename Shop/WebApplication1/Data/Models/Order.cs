using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Имя")]
        [StringLength(40)]
        [Required(ErrorMessage = "Длина имени не менее 3 символов")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(40)]
        [Required(ErrorMessage = "Длина фамилии не менее 3 символов")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(80)]
        [Required(ErrorMessage = "Длина адреса не менее 5 символов")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина телефона не менее 7 символов")]
        public string phone { get; set; }

        [Display(Name = "Адрес электронной почты")]
        [DataType(DataType.EmailAddress)]
        [StringLength(40)]
        [Required(ErrorMessage = "Длина почты не менее 3 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
