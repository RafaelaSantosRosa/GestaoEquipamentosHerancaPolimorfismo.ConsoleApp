using System;

namespace GestaoEquipamentos.ConsoleApp.Dominio
{
    public class Solicitante
    {
        public int id;
        public string nome;
        public string email;
        public int numero;

        public Solicitante()
        {
            id = GeradorId.GerarIdEquipamento();
        }

        public Solicitante(int idSelecionado)
        {
            id = idSelecionado;
        }

        public string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(nome))
                resultadoValidacao += "O campo Nome é obrigatório \n";

            if (nome.Length < 6)
                resultadoValidacao += "O campo Nome não pode ter menos de 6 letras \n";

            if (string.IsNullOrEmpty(email))
                resultadoValidacao += "O campo Email é obrigatório \n";

            if (string.IsNullOrEmpty(resultadoValidacao))
                resultadoValidacao = "SOLICITANTE_VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            Solicitante solicitante = (Solicitante)obj;

            if (solicitante != null && solicitante.id == this.id)
                return true;
            else
                return false;
        }
    }
}
