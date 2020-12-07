namespace POO_Heranca.classes
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;
        public string inscricaoEstadual;

        public bool ValidarCNPJ(string documento){

            if (documento != "")
            {
                return true;
            }else{
            return false;
            }

        }

    }//PJ
}