using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Notificacoes
{
    public class Notifica
    {
        public Notifica()
        {
            notificacoes = new List<Notifica>();
        }
        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string mensagem { get; set; }

        [NotMapped]
        public List<Notifica> notificacoes { get; set; }

        public bool ValidarPropriedadeString(string valor, string NomePropriedade){
            if(string.IsNullOrWhiteSpace(valor)||string.IsNullOrWhiteSpace(NomePropriedade)){
                notificacoes.Add(new Notifica{
                    mensagem = "Campo Obrigatório",
                    NomePropriedade = NomePropriedade
                });

                return false;
            }

            return true;
        }

        public bool ValidarPropriedadeInt(int valor, string NomePropriedade){
            if(valor < 1 ||string.IsNullOrWhiteSpace(NomePropriedade)){
                notificacoes.Add(new Notifica{
                    mensagem = "Campo Obrigatório",
                    NomePropriedade = NomePropriedade
                });

                return false;
            }

            return true;
        }
    }
}