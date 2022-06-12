using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaNotas.DTOs
{
    public class SefazDTO
    {
        //Pessoais//
        [Key]
        public int SefazId { get; set; }
        public string Nome { get; set; }
        public string Identidade { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }

        //Endeço//
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Municipio { get; set; }
        public string EstadoUf { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }

        //NotaFiscal//
        public int NfNumero { get; set; }
        public string Danfe { get; set; }
        public string DataEmissao { get; set; }
        public string ValorNf { get; set; }
        public string UfEminente { get; set; }
        public string CnpjEminente { get; set; }
        public string RSocialEminente { get; set; }
        public string Observacao { get; set; }

        //Veiculo Geral//
        public string Chassi { get; set; }
        public string Renavam { get; set; }
        public string AnoFabricacao { get; set; }
        public string AnoModelo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}
