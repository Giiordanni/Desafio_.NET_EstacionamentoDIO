using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento1.Models
{
    public class Estacionamento
    {
         private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();


        public Estacionamento(){
            this.precoInicial = 5;
            this.precoPorHora = 2;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            foreach(string veiculo in veiculos){
                if(veiculo.ToUpper() == placa.ToUpper()){
                    Console.WriteLine("Desculpe, esse veículo já está estacionado aqui.");
                    return;
                }
            }
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) {
                Console.WriteLine("Digite a quanitdade de horas que o veículo permaneceu estacionado: ");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + (horas * precoPorHora);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
            }else{
               Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
            
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos) { 
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public decimal getPrecoInicial()
        {
            return this.precoInicial;
        }

        public decimal getPrecoPorHora()
        {
            return this.precoPorHora;
        }

    }
}