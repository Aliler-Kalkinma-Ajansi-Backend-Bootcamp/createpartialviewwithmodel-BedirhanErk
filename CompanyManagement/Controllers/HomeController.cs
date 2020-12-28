using CompanyManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var stf = new List<Staff>()
            {
                new Staff(){ Id=1,StaffName="Bedirhan",StaffSurname="Erkılıç",DepartmentName="Sales"},
                new Staff(){ Id=2,StaffName="Müslüm",StaffSurname="Gürses",DepartmentName="Accounting"},
                new Staff(){ Id=3,StaffName="Cem",StaffSurname="Karaca",DepartmentName="Finance"},
                new Staff(){ Id=4,StaffName="Kemal",StaffSurname="Sunal",DepartmentName="Marketing"},
                new Staff(){ Id=5,StaffName="Polat",StaffSurname="Alemdar",DepartmentName="Human Resources"},
                new Staff(){ Id=6,StaffName="Ali",StaffSurname="Salgın",DepartmentName="Management"},
                new Staff(){ Id=7,StaffName="Fatma",StaffSurname="Yeşil",DepartmentName="Sales"},
                new Staff(){ Id=8,StaffName="Ayşe",StaffSurname="Bahar",DepartmentName="Accounting"},
                new Staff(){ Id=9,StaffName="Can",StaffSurname="Koçak",DepartmentName="Sales"},
                new Staff(){ Id=10,StaffName="Merve",StaffSurname="Beyaz",DepartmentName="Human Resources"},
            };
            return View(stf);
        }
        public IActionResult Products()
        {
            var prd = new List<Products>()
            {
                new Products(){ Id=1,ProductName="Laptop",Stock=100,Brand="Lenovo",BuyingPrice=5000,SalePrice=7000},
                new Products(){ Id=2,ProductName="MobilPhone",Stock=200,Brand="Samsung",BuyingPrice=3000,SalePrice=5000},
                new Products(){ Id=3,ProductName="Headphone",Stock=50,Brand="Xiaomi",BuyingPrice=500,SalePrice=600},
                new Products(){ Id=4,ProductName="Keyboard",Stock=560,Brand="Logitech",BuyingPrice=200,SalePrice=500},
                new Products(){ Id=5,ProductName="Mouse",Stock=20,Brand="Logitech",BuyingPrice=100,SalePrice=200},
                new Products(){ Id=6,ProductName="Camera",Stock=20,Brand="Everest",BuyingPrice=1800,SalePrice=2000},
                new Products(){ Id=7,ProductName="Laptop",Stock=85,Brand="Acer",BuyingPrice=5600,SalePrice=6000},
                new Products(){ Id=8,ProductName="MobilPhone",Stock=40,Brand="Iphone",BuyingPrice=8900,SalePrice=9000},
                new Products(){ Id=9,ProductName="Mouse",Stock=890,Brand="Everest",BuyingPrice=50,SalePrice=80},
                new Products(){ Id=10,ProductName="Keyboard",Stock=320,Brand="Preo",BuyingPrice=20,SalePrice=50}

            };
            return View(prd);
        }
        public IActionResult Department()
        {
            var dpt = new List<Department>()
            {
                new Department(){ Id=1,DepartmentName="Sales" },
                new Department(){ Id=2,DepartmentName="Accounting" },
                new Department(){ Id=3,DepartmentName="Finance" },
                new Department(){ Id=4,DepartmentName="Marketing" },
                new Department(){ Id=5,DepartmentName="Human Resources" },
                new Department(){ Id=6,DepartmentName="Management" }
            };
            return View(dpt);
        }
        public IActionResult Customers()
        {
            var ctm = new List<Customers>()
            {
                new Customers(){Id=1,CustomerName="Ahmet",CustomerSurname="Hakkı",CustomerEmail="ahmethakkı@gmail.com"},
                new Customers(){Id=2,CustomerName="Süleyman",CustomerSurname="Seba",CustomerEmail="süleymanseba@hotmail.com"},
                new Customers(){Id=3,CustomerName="Çağatay",CustomerSurname="Uçmaz",CustomerEmail="çağatay@gmail.com"},
                new Customers(){Id=4,CustomerName="Mustafa",CustomerSurname="Uslu",CustomerEmail="mustafauslu@gmail.com"},
                new Customers(){Id=5,CustomerName="Mehmet",CustomerSurname="Çimen",CustomerEmail="mehmetçimen@gmail.com"},
                new Customers(){Id=6,CustomerName="Oktay",CustomerSurname="Bilgiç",CustomerEmail="oktaybilgiç@gmail.com"},
                new Customers(){Id=7,CustomerName="Adnan",CustomerSurname="Gezgin",CustomerEmail="adngezgin@outlook.com"},
                new Customers(){Id=8,CustomerName="Sefa",CustomerSurname="Can",CustomerEmail="sefacan@gmail.com"},
                new Customers(){Id=9,CustomerName="Rukiye",CustomerSurname="Çamur",CustomerEmail="çamurrukiye@gmail.com"},
                new Customers(){Id=10,CustomerName="Betül",CustomerSurname="Büyük",CustomerEmail="betülnüyük@gmail.com"},
                new Customers(){Id=11,CustomerName="Hamdi",CustomerSurname="Selanikli",CustomerEmail="selanikli@gmail.com"},
            };
            return View(ctm);
        }
        public IActionResult Category()
        {
            var ctg = new List<Category>()
            {
                new Category(){ Id=1,CategoryName="Laptop"},
                new Category(){ Id=2,CategoryName="MobilPhone"},
                new Category(){ Id=3,CategoryName="Headphone"},
                new Category(){ Id=4,CategoryName="Keyboard"},
                new Category(){ Id=5,CategoryName="Mouse"},
                new Category(){ Id=6,CategoryName="Camera"},
            };
            return View(ctg);
        }
    }
}
