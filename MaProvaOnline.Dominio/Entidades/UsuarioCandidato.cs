using System;

namespace MaProvaOnline.Dominio.Entidades
{
    public class UsuarioCandidato : EntityBase
    {
        public string NomeCompleto { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public bool IsAprovado { get; private set; }

        public UsuarioCandidato()
        {
            this.IsAprovado = false;
        }

        public UsuarioCandidato(int _id, string _nome, DateTime _dataNascimento, string _email, string _cpf, string _rg, bool _isAprovado)
        {
            this.NomeCompleto = _nome;
            this.DataNascimento = _dataNascimento;
            this.Email = _email;
            this.Cpf = _cpf;
            this.Rg = _rg;
            this.IsAprovado = _isAprovado;
        }

        public UsuarioCandidato(Guid hashGuid, int id, DateTime dataCadastro, bool isAtivo) : base(hashGuid, id, dataCadastro, isAtivo)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
