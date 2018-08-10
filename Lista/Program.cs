using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista.Classes;
using System.IO;
using System.Text.RegularExpressions;


namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Registro reg = new Registro();
            Registro0400 reg0400 = new Registro0400();
            Registro0430 reg0430 = new Registro0430();
            string pathfile = "D:\\teste.txt";            
            List<Registro0400> listaderegistros0400 = new List<Registro0400>();
            List<Registro0430> listaderegistros0430 = new List<Registro0430>();
            string caminhoarquivosaida = "D:\\testeescrita.txt";
            StreamWriter sw = new StreamWriter(caminhoarquivosaida);
            //FileStream fs = new FileStream(pathfile,FileMode.Open);
            StreamReader sr = new StreamReader(pathfile);
            int numerodelinhas = 0;
            Regex re = new Regex("\r\n");
            String stringReader = sr.ReadToEnd();
            
            
            numerodelinhas = (re.Matches(stringReader).Count + 1);
            
            for (int i = 1; i <= numerodelinhas; i++) 
            {
                switch (reg.RetornaTipoRegistro(i, pathfile))
                {
                    case "0400":
                        {
                            listaderegistros0400.Add(reg0400.RetornaRegistro(i, pathfile));
                            
                            break;
                        }
                    case "0430":
                        {
                            listaderegistros0430.Add(reg0430.RetornaRegistro(i, pathfile));
                            
                            break;
                        }                         
                        
                }              

            }


            for (int i = 1; i <= numerodelinhas; i++)
            {


                foreach (Registro0400 r in listaderegistros0400)
                {
                    if (r.num_linha == i.ToString())
                    {

                    
                    Console.WriteLine(r.num_linha + "|" + r.reg + "|" + r.cod_depe + "|" + r.indr_insc_munl + "|" + r.cnpj_proprio + "|" + r.tipo_depe + "|" + r.endr_depe
                        + "|" + r.cnpj_unif + "|" + r.cod_munc + "|" + r.ctbl_propria + "|" + r.dat_inic_para + "|" + r.dat_fim_para);

                        
                    }
                }

                foreach (Registro0430 r in listaderegistros0430)
                {
                    if(r.num_linha == i.ToString())
                    {                    
                    Console.WriteLine(r.num_linha + "|" + r.reg + "|" + r.cod_depe + "|" + r.Sub_Titu + "|" + r.Des_Mista + "|" + r.Cod_Trib_DESIF + "|" + r.Valr_Cred_Mens
                        + "|" + r.Valr_Debt_Mens + "|" + r.Rece_Decl + "|" + r.Dedu_Rece_Decl + "|" + r.Desc_Dedu + "|" + r.Base_Calc + "|" + r.Aliq_ISSQN + "|" + r.Inct_Fisc + "|" + r.Desc_Inct_Fisc + "|" + r.Valr_ISSQN_Retd + "|" + r.Motv_Nao_Exig + "|" + r.Proc_Motv_Nao_Exig);

                        
                    }
                }
            }
            //sw.Close();
            Console.WriteLine();
            Console.WriteLine("Quantidade de registros 0400 adicionados " + listaderegistros0400.Count);
            Console.WriteLine("Quantidade de registros 0430 adicionados " + listaderegistros0430.Count);
            Console.ReadLine();

        }
    }
}
