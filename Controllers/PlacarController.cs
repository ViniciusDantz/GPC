using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using GPC.Services;
using GPC.Models.ViewModels;
using GPC.Models;

namespace GPC.Controllers
{
    public class PlacarController : Controller
    {
        private readonly PlacarService _placarService;

        public PlacarController(PlacarService placarservice)
        {
            _placarService = placarservice;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _placarService.FindAllAsync();
            return View(list);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastro(PlacarViewModel formview)
        {
            if (!ModelState.IsValid || formview.Placar.Pontos < 0)
            {
                TempData["Message"] = "Um erro ocorreu durante o processo de cadastro, "
                +"verifique se os campos estão preenchidos corretamente.";
                TempData["Titulo"] = "Erro!";
                TempData["CssClassName"] = "alert-error bg-danger";
                return View(formview);
            }
            try {
                await _placarService.InsertAsync(formview.Placar);
                TempData["Message"] = $"Placar cadastrado com sucesso.";
                TempData["Titulo"] = "Sucesso!";
                TempData["CssClassName"] = "alert-success bg-success";
                ModelState.Clear();
                return View();
            } catch(Exception) {
                TempData["Message"] = "Um erro ocorreu durante o processo de cadastro.";
                TempData["Titulo"] = "Erro!";
                TempData["CssClassName"] = "alert-error bg-danger";
                return RedirectToAction("Error");
            }
        }

        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Placar não encontrado, tente novamente." });
            }

            var placar = await _placarService.FindByIdAsync(id.Value);
            if (placar == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Placar inválido." });
            }
            return View(new PlacarViewModel { Placar = placar });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, PlacarViewModel formview)
        {
            try {
                if (id != formview.Placar.Id)
                {
                    return RedirectToAction(nameof(Error), new { message = "Placar não corresponde com o dado fornecido." });
                }   
                if (!ModelState.IsValid || formview.Placar.Pontos <= 0 || formview.Placar.IdJogador <= 0)
                {
                    TempData["Message"] = "Um erro ocorreu durante o processo de edição, "
                    +"verifique se os campos estão preenchidos corretamente.";
                    TempData["Titulo"] = "Erro!";
                    TempData["CssClassName"] = "alert-error bg-danger";
                    return View(new PlacarViewModel { Placar = formview.Placar, NomeAntigo = formview.NomeAntigo });
                }
                if(formview.NomeAntigo != null){
                    /* formview.Placar.Nome = Utils.removeBadChars(formview.Placar.Nome);
                    formview.Placar.Nacionalidade = Utils.removeBadChars(formview.Placar.Nacionalidade);
                    // Nome
                    formview.Placar.Nome = formview.Placar.Nome.Trim();
                    formview.Placar.Nome = Regex.Replace(formview.Placar.Nome, @"\s+", " ");
                    if(formview.Placar.Nome.Length < 3){
                        ModelState.AddModelError(String.Empty, "'Nome' deve ter no mínimo 3 caracteres.");
                        return View(formview);
                    } */
                    await _placarService.UpdateAsync(formview.Placar);
                    TempData["Message"] = $"Placar editado com sucesso.";
                    TempData["Titulo"] = "Sucesso!";
                    TempData["CssClassName"] = "alert-success bg-success";
                    return RedirectToAction(nameof(Index));
                }else{
                    TempData["Message"] = "Um erro ocorreu durante o processo de edição, procure o placar novamente.";
                    TempData["Titulo"] = "Erro!";
                    TempData["CssClassName"] = "alert-error bg-danger";
                    return View(new PlacarViewModel { NomeAntigo = formview.NomeAntigo });
                }
            } catch(Exception e) {
                TempData["Message"] = "Um erro ocorreu durante o processo de edição.";
                TempData["Titulo"] = "Erro!";
                TempData["CssClassName"] = "alert-error bg-danger";
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Placar não encontrado, tente novamente." });
            }

            var placar = await _placarService.FindByIdAsync(id.Value);
            if (placar == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Placar inválido." });
            }

            return View(placar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Placar placar)
        {
            try {
                if (id != placar.Id)
                {
                    return RedirectToAction(nameof(Error), new { message = "Placar com código incorreto" });
                }
                if(await _placarService.FindByIdAsync(id) == null){
                    TempData["Message"] = $"O placar pode não existir mais, procure-o novamente.";
                    TempData["Titulo"] = "Espere!";
                    TempData["CssClassName"] = "alert-info bg-info";
                    return RedirectToAction(nameof(Index));
                }else{
                    await _placarService.RemoveAsync(id);
                    TempData["Message"] = $"Placar removido com sucesso.";
                    TempData["Titulo"] = "Sucesso!";
                    TempData["CssClassName"] = "alert-success bg-success";
                    return RedirectToAction(nameof(Index));
                }
            } catch(Exception e) {
                TempData["Message"] = "Um erro ocorreu durante o processo de remoção.";
                TempData["Titulo"] = "Erro!";
                TempData["CssClassName"] = "alert-error bg-danger";
                return RedirectToAction("Error", new { message = e.Message });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
