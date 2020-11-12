﻿using _P__MVC___Beginner.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace _P__MVC___Beginner.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            PokemonAPI allpokemon;

            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync("http://pokeapi.co/api/v2/pokemon?offset0&limit=1100").Result;

                allpokemon = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }


            return View(allpokemon.results);
        }

        public ActionResult Info(string id)
        {
            PokemonInfo info;


            return View();
        }

    }
}