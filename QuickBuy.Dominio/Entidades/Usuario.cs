﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionaCritica("E-mail deve ser informado");
            if (string.IsNullOrEmpty(Nome))
                AdicionaCritica("Nome de usuario deve ser informado");
            if (string.IsNullOrEmpty(Senha))
                AdicionaCritica("Senha de usuario deve ser informada");

        }
    }
}
