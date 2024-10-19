using System.Linq.Expressions;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //Implementado!!
     
             if (Suite.Capacidade>=hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else{

                string mensagem = "O numero de hóspedes nao pode ser maior do que"+
                 " a capacidade da suite.";

                throw new Exception(mensagem);
                
            }

        }

       

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //Implementado
            int quantidade_hospedes = Hospedes.Count;
            return quantidade_hospedes;
        }

        public decimal CalcularValorDiaria()
        {
           //Implementado

            decimal calc_diaria = DiasReservados * Suite.ValorDiaria;
            decimal valor = calc_diaria;

          //Implementado
            if (DiasReservados>=10)
            {
                
                decimal val_com_desconto = calc_diaria - (calc_diaria * 0.1M);
                valor = val_com_desconto;
               
            }

            return valor;
        }
    }
}