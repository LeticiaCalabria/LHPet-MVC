using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Inst. cliente
        Cliente cliente1 = new Cliente(01, "Leticia C.", "574.601.160-68", "leticiaC@email.com", "Xixa");
        Cliente cliente2 = new Cliente(02, "Lisa M.", "502.937.120-69", "lalisa128@hotmail.com", "Teddy");
        Cliente cliente3 = new Cliente(03, "Jennie Kim", "634.592.290-04", "JennieSolo@uol.com.br", "Kai");
        Cliente cliente4 = new Cliente(04, "Jisoo Kim", "342.555.560-08", "FlowerJisoo267@live.com", "Pipoca");
        Cliente cliente5 = new Cliente(05, "Rose Park", "521.025.950-13", "RosinhaParque@ymal.com", "Brigadeiro");

        //Lista de clientes

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        ViewBag.listaClientes = listaClientes;

        // Inst. fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "POCHITA S/A", "52.015.718/0001-55", "denji143@email.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Akamaru INC", "85.772.227/0001-08", "KiBa6519@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Bond Man Alt", "86.757.502/0001-87", "Forgeranya25@hotmail.com.");
        Fornecedor fornecedor4 = new Fornecedor(04, "Appa Airbender S/A", "94.736.520/0001-00", "AvaTarAang@live.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Tetsuya 2 KNB", "20.868.286/0001-39", "Kuroko11@ymal.com");

        //Lista de fornecedores

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);
        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
