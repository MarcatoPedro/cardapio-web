using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CardapioWeb.Context;
using CardapioWeb.Models;

namespace CardapioWeb.Views
{
    public class ListarProdutosModel : PageModel
    {
        private readonly CardapioWeb.Context.AppDBContext _context;

        public ListarProdutosModel(CardapioWeb.Context.AppDBContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Produtos != null)
            {
                Produto = await _context.Produtos.ToListAsync();
            }
        }
    }
}
