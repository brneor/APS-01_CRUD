using APS01_Dominio.DAOs;
using APS01_Dominio.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace APS01_CRUD.ViewModels
{
    class ProdutoViewModel : BaseViewModel<Produto>
    {
        public ProdutoViewModel(ITelaCadastro<Produto> telaCadastro) : base(telaCadastro)
        {
            PreencherLista();
        }

        protected override IDAO<Produto> GetDAO()
        {
            return dao;
        }

        private ProdutoDAO dao = new ProdutoDAO();
    }
}
