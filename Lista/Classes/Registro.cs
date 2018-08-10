using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lista.Classes
{
    class Registro
    {
        public string num_linha;
        public string reg;
        


        
        public void MostrarTodosRegistros(string caminhoarquivo)
        {
            string pathfile = caminhoarquivo;
            StreamReader sr = new StreamReader(pathfile);
            char c;


            while (sr.Peek() > -1)
            {
                c = Convert.ToChar(sr.Read());
                Console.Write(c);
            }  
            
        }

        public string RetornaTipoRegistro(int numerolinha, string caminhoarquivo)
        {
            string c;            
            int numcharnacoluna = 1;
            int numcoluna = 1;
            int numlinha = 1;
            StreamReader sr = new StreamReader(caminhoarquivo);
            Registro regi = new Registro();
            StringBuilder monta_num_linha = new StringBuilder();
            StringBuilder monta_reg = new StringBuilder();
            StringBuilder monta_cod_depe = new StringBuilder();
            StringBuilder monta_indr_insc_munl = new StringBuilder();
            StringBuilder monta_cnpj_proprio = new StringBuilder();
            StringBuilder monta_tipo_depe = new StringBuilder();
            StringBuilder monta_endr_depe = new StringBuilder();
            StringBuilder monta_cnpj_unif = new StringBuilder();
            StringBuilder monta_cod_munc = new StringBuilder();
            StringBuilder monta_ctbl_propria = new StringBuilder();
            StringBuilder monta_dat_inic_para = new StringBuilder();
            StringBuilder monta_dat_fim_para = new StringBuilder();


            while (sr.Peek() > -1)
            {
                
                c = Convert.ToString(Convert.ToChar((sr.Read())));
                numcharnacoluna += 1;

                switch (c)
                {
                    case "|":
                        {
                            numcoluna += 1;
                            numcharnacoluna = 0;
                            monta_num_linha.Clear();
                            monta_reg.Clear();                                                        
                            break;
                        }                    
                    case "\n":
                        {
                            numlinha += 1;
                            numcharnacoluna = 0;
                            numcoluna = 1;
                            break;

                        }
                    default:
                        {

                            if (numlinha == numerolinha)
                            {
                                switch (numcoluna)
                                {
                                    case 1:
                                        {
                                            monta_num_linha.Append(c);
                                            regi.num_linha = monta_num_linha.ToString();
                                            break;
                                        }
                                    case 2:
                                        {
                                            monta_reg.Append(c);
                                            regi.reg = monta_reg.ToString();
                                            break;
                                        }
                                }
                                
                                
                            }
                            break;
                        }

                }

                

                
            }
            

            return regi.reg;
        }
               

    }
}
