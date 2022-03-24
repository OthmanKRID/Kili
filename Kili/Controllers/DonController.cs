﻿using Kili.Models.Dons;
using Kili.Models.Services;
using Kili.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Kili.Controllers
{
    //[Authorize]
    public class DonController : Controller 
    { 
            

        public IActionResult CreerDon()
        {

        return View();
        }


        [HttpPost]
        public IActionResult CreerDon(DonViewModel viewModel)
        {
            //if (!ModelState.IsValid) { 

            DonServices donServices = new DonServices();
            {
                int id = donServices.CreerDon(viewModel.Don.Montant, viewModel.Don.Recurrence, viewModel.Don.DonateurId);

                return Redirect("/home/index");
            }
            // } return View();
        }


        public IActionResult AfficherDon(int id)
        {
            if (id != 0)
            {
                DonServices donServices = new DonServices();
                {
                    Don don = donServices.ObtenirDon(id);
                    if (don == null)
                    {
                        return View("Error");
                    }
                    return View(new DonViewModel() { Don = don });
                }

            }
            return View("Error");
        }

        public IActionResult AfficherDons()
        {
            DonServices donServices = new DonServices();
                {
                    List<Don> listdon = donServices.ObtenirDons();
                    
                return View(listdon);
                }
        }

        public IActionResult ModifierDon(int id)
        {
            if (id != 0)
            {
                    DonServices donServices = new DonServices();
                    {
                    Don don = donServices.ObtenirDons().Where(r => r.Id == id).FirstOrDefault();

                    if (don == null)
                    {
                        return View("Error");
                    }
                    return View(new DonViewModel() { Don = don });
                }

            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult ModifierDon(DonViewModel viewModel)
        {

            if (viewModel.Don.Id != 0)
            {
                    DonServices donServices = new DonServices();
                    {
                    donServices.ModifierDon(viewModel.Don.Id, viewModel.Don.Montant, viewModel.Don.Recurrence);

                    return RedirectToAction("ModifierDon", new { @id = viewModel.Don.Id });
                }
            }
            else
            {
                return View("Error");
            }
        }

           

            public IActionResult SupprimerDon(int id)
        {
            if (id != 0)
            {
                    DonServices donServices = new DonServices();
                    {
                    Don don = donServices.ObtenirDons().Where(r => r.Id == id).FirstOrDefault();
                    if (don == null)
                    {
                        return View("Error");
                    }
                    donServices.SupprimerDon(id);
                    return Redirect("/home/index");
                }

            }
            return View("Error");
        }





}
}