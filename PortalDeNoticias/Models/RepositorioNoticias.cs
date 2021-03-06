﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null) CriarNoticias();
                return noticias;                
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Brasil Octa Campeão Mundial de Futebol",
                Autor = "Jose Eduardo",
                Data = DateTime.Today,
                Conteudo = "Apos um jogo dramartico contra a seleção da Alemanha, finalmente a seleção Brasileira consegui seu oitavo" +
                "titulo mundial de futebol, um feito e tanto para nossosatletas que tanto se dedicaram"
            });

            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Jairo Bolsonaro é Eleito Presidente do Brasil",
                Autor = "Jose Eduardo",
                Data = DateTime.Today,
                Conteudo = "Apos eleições conturbadas o Brasil tem um novo presidente, Jair Bolsonaro foi eleito com 55% dos votos, nas eleições do ultimo domingo."
            });

            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Fabio Junior se casa pela 16 Vez",
                Autor = "Jose Eduardo",
                Data = DateTime.Today,
                Conteudo = "Teste de cadastro de uma noticia onde informamos que o Sr Jabio Junior se casou mais uma vez, claro que isso não passa de uma brincadeira para termos posts, para podermos testar nosso projeto"
            });

            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Cientista Brasileiro descobre a cura do cancer",
                Autor = "Jose Eduardo",
                Data = DateTime.Today,
                Conteudo = "Apos um jogo dramartico contra a seleção da Alemanha, finalmente a seleção Brasileira consegui seu 5" +
                "titulo mundial de futebol, um feito e tanto para nossosatletas que tanto se dedicaram"
            });

            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Brasil se torna a Segunda Maior Economia do Mundo",
                Autor = "Jose Eduardo",
                Data = DateTime.Today,
                Conteudo = "Apos um jogo dramartico contra a seleção da Alemanha, finalmente a seleção Brasileira consegui seu 5" +
                "titulo mundial de futebol, um feito e tanto para nossosatletas que tanto se dedicaram"
            });
        }
    }
}