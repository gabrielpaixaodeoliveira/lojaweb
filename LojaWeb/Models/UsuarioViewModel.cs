﻿namespace LojaWeb.Models
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Login { get;  set; }
        public string Senha { get;  set; }
        public string Email { get;  set; }
        public int IdPerfil { get; set; }
    }
}
