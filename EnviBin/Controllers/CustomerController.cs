using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Customers.Base.Entities;
using EnviBin.Web.Datastore;
using Microsoft.AspNetCore.Mvc;
using static EnviBin.Web.Site.Controllers.CustomerController;

namespace EnviBin.Web.Site.Controllers
{
    public class CustomerController : Controller
    {
        private readonly EnviBinDbContext _db;
        public CustomerController(EnviBinDbContext db)
        {
            db = _db;
        }

        public IEnumerable<Customer> Customers;
        public class Customer
        {
            [Key]
            public int Id { get; set; }


            [Required]
            [Display(Name = "Name")]
            public string CostumerName { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string CostumerEmail { get; set; }

            [Required]
            [Display(Name = "Telephone")]
            public string CostumerTelephone { get; set; }

            [Required]
            [Display(Name = "CompanyName")]
            public string CostumerCompanyName { get; set; }

            [Required]
            [Display(Name = "VatNumber")]
            public string CostumerVatNo { get; set; }

            [Required]
            [Display(Name = "Costumer Province")]
            public string CostumerProvince { get; set; }

            [Required]
            [Display(Name = "Street")]
            public string CostumerStreet { get; set; }

            [Required]
            [Display(Name = "BillingAddress")]
            public string BillingAddress { get; set; }

            [Required]
            [Display(Name = "Costumer Area")]
            public string CostumerArea { get; set; }

            [Required]
            [Display(Name = "Town")]
            public string CostumerTown { get; set; }

            [Required]
            [Display(Name = "Postal/Zip")]
            public string CostumerPostal { get; set; }

            [Required]
            [Display(Name = "Costumer Suburb")]
            public string CostumerSuburb { get; set; }

        }

       
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
