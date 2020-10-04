using APS01_Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APS01_CRUD.ViewModels
{
    public interface ITelaCadastro<T> where T : Model, new()
    {
        void Abrir(BaseViewModel<T> viewModel);
        void Fechar();
    }
}
