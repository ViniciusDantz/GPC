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
    public class JogadorController : Controller
    {
        private readonly JogadorService _jogadorService;

        public JogadorController(JogadorService jogadorservice)
        {
            _jogadorService = jogadorservice;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _jogadorService.FindAllAsync();
            return View(list);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastro(Jogador jogador)
        {
            if (!ModelState.IsValid || jogador.Idade <= 0)
            {
                TempData["Message"] = "Um erro ocorreu durante o processo de cadastro, "
                +"verifique se os campos estão preenchidos corretamente.";
                TempData["Titulo"] = "Erro!";
                TempData["CssClassName"] = "alert-error bg-danger";
                return View(jogador);
            }
            try {
                jogador.Nome = Utils.removeBadChars(jogador.Nome);
                jogador.Nacionalidade = Utils.removeBadChars(jogador.Nacionalidade);
                // Nome
                jogador.Nome = jogador.Nome.Trim();
                jogador.Nome = Regex.Replace(jogador.Nome, @"\s+", " ");
                if(jogador.Nome.Length < 3){
                    ModelState.AddModelError(String.Empty, "'Nome' deve ter no mínimo 3 caracteres.");
                    return View(jogador);
                }
                if(jogador.Nacionalidade != null){
                    // Nacionalidade
                    jogador.Nacionalidade = jogador.Nacionalidade.Trim();
                    jogador.Nacionalidade = Regex.Replace(jogador.Nacionalidade, @"\s+", " ");
                }
                if(await _jogadorService.ExistEqual(jogador)){
                    TempData["Message"] = $"Um(a) jogador(a) com o mesmo nome já está cadastrado(a), escolha um nome diferente.";
                    TempData["Titulo"] = "Espere!";
                    TempData["CssClassName"] = "alert-info bg-info";
                    return View(jogador);
                }else{
                    await _jogadorService.InsertAsync(jogador);
                    TempData["Message"] = $"Jogador(a) '{jogador.Nome}' cadastrado(a) com sucesso.";
                    TempData["Titulo"] = "Sucesso!";
                    TempData["CssClassName"] = "alert-success bg-success";
                    ModelState.Clear();
                    return View();
                }
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
                return RedirectToAction(nameof(Error), new { message = "Jogador(a) não encontrado(a), tente novamente." });
            }

            var jogador = await _jogadorService.FindByIdAsync(id.Value);
            if (jogador == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Jogador(a) inválido." });
            }
            return View(new JogadorViewModel { Jogador = jogador , NomeAntigo = jogador.Nome });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, JogadorViewModel formview)
        {
            try {
                if (id != formview.Jogador.Id)
                {
                    return RedirectToAction(nameof(Error), new { message = "Jogador(a) não corresponde com o dado fornecido." });
                }   
                if (!ModelState.IsValid || formview.Jogador.Idade <= 0)
                {
                    TempData["Message"] = "Um erro ocorreu durante o processo de edição, "
                    +"verifique se os campos estão preenchidos corretamente.";
                    TempData["Titulo"] = "Erro!";
                    TempData["CssClassName"] = "alert-error bg-danger";
                    return View(new JogadorViewModel { Jogador = formview.Jogador, NomeAntigo = formview.NomeAntigo });
                }
                if(formview.NomeAntigo != null){
                    formview.Jogador.Nome = Utils.removeBadChars(formview.Jogador.Nome);
                    formview.Jogador.Nacionalidade = Utils.removeBadChars(formview.Jogador.Nacionalidade);
                    // Nome
                    formview.Jogador.Nome = formview.Jogador.Nome.Trim();
                    formview.Jogador.Nome = Regex.Replace(formview.Jogador.Nome, @"\s+", " ");
                    if(formview.Jogador.Nome.Length < 3){
                        ModelState.AddModelError(String.Empty, "'Nome' deve ter no mínimo 3 caracteres.");
                        return View(formview);
                    }
                    if(formview.Jogador.Nacionalidade != null){
                        // Nacionalidade
                        formview.Jogador.Nacionalidade = formview.Jogador.Nacionalidade.Trim();
                        formview.Jogador.Nacionalidade = Regex.Replace(formview.Jogador.Nacionalidade, @"\s+", " ");
                    }
                    if(formview.NomeAntigo.Equals(formview.Jogador.Nome) == false){
                        if(await _jogadorService.ExistEqual(formview.Jogador)){
                            TempData["Message"] = $"Um(a) jogador(a) com o mesmo nome já está cadastrado(a), escolha um nome diferente.";
                            TempData["Titulo"] = "Espere!";
                            TempData["CssClassName"] = "alert-info bg-info";
                            return View(new JogadorViewModel { Jogador = formview.Jogador, NomeAntigo = formview.NomeAntigo });
                        }
                    }
                    await _jogadorService.UpdateAsync(formview.Jogador);
                    TempData["Message"] = $"Jogador(a) '{formview.Jogador.Nome}' editado(a) com sucesso.";
                    TempData["Titulo"] = "Sucesso!";
                    TempData["CssClassName"] = "alert-success bg-success";
                    return RedirectToAction(nameof(Index));
                }else{
                    TempData["Message"] = "Um erro ocorreu durante o processo de edição, procure-o novamente.";
                    TempData["Titulo"] = "Erro!";
                    TempData["CssClassName"] = "alert-error bg-danger";
                    return View(new JogadorViewModel { NomeAntigo = formview.NomeAntigo });
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
                return RedirectToAction(nameof(Error), new { message = "Jogador(a) não encontrado(a), tente novamente." });
            }

            var jogador = await _jogadorService.FindByIdAsync(id.Value);
            if (jogador == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Jogador(a) inválido." });
            }

            return View(jogador);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Jogador jogador)
        {
            try {
                if (id != jogador.Id)
                {
                    return RedirectToAction(nameof(Error), new { message = "Jogador(a) com código incorreto" });
                }
                if(await _jogadorService.FindByIdAsync(id) == null){
                    TempData["Message"] = $"O(A) jogador(a) pode não existir mais, procure-o(a) novamente.";
                    TempData["Titulo"] = "Espere!";
                    TempData["CssClassName"] = "alert-info bg-info";
                    return RedirectToAction(nameof(Index));
                }else{
                    await _jogadorService.RemoveAsync(id);
                    TempData["Message"] = $"Jogador(a) '{jogador.Nome}' removido(a) com sucesso.";
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
