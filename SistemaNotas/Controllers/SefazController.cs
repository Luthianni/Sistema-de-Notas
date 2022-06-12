using Microsoft.AspNetCore.Mvc;
using SistemaNotas.DTOs;
using SistemaNotas.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaNotas.Controllers
{
    public class SefazController : Controller
    {
        private readonly ISefazService service;

        public SefazController(ISefazService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            var list = await service.GetAllAsync();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpGet]
        [Route("ObterLista")]
        public async Task<IActionResult> ObterLista()
        {
            return Ok(await service.GetAllAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SefazDTO dto)
        {
           
                await service.AddAsync(dto);
           
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var correction = await service.GetByIdAsync(id);
            return View(correction);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SefazDTO sefaz)
        {
            await service.UpdateAsync(sefaz);
            return RedirectToAction("Index");
            
        }

        public async Task<IActionResult> Details(int id)
        {
            var detsefaz = await service.GetByIdAsync(id);
            return View(detsefaz);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var delsefaz = await service.GetByIdAsync(id);
            return View(delsefaz);
        }

        [HttpPost]
        public async Task<IActionResult> Deletar(int SefazId)
        {
            var delsefaz = await service.Delete(SefazId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Consulta(int Id)
        {
            var edicoes = await service.GetByIdAsync(Id);
            return View(edicoes);
        }
    }
}
