using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lista.Classes
{
    class Registro0430 : Registro
    {        
        public string cod_depe;
        public string Sub_Titu;
        public string Des_Mista;
        public string Cod_Trib_DESIF;
        public string Valr_Cred_Mens;
        public string Valr_Debt_Mens;
        public string Rece_Decl;
        public string Dedu_Rece_Decl;
        public string Desc_Dedu;
        public string Base_Calc;
        public string Aliq_ISSQN;
        public string Inct_Fisc;
        public string Desc_Inct_Fisc;
        public string Valr_ISSQN_Retd;
        public string Motv_Nao_Exig;
        public string Proc_Motv_Nao_Exig;


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

        public Registro0430 RetornaRegistro(int numerolinha, string caminhoarquivo)
        {
            string c;            
            int numcharnacoluna = 1;
            int numcoluna = 1;
            int numlinha = 1;
            StreamReader sr = new StreamReader(caminhoarquivo);
            Registro0430 regi = new Registro0430();
            StringBuilder monta_num_linha = new StringBuilder();
            StringBuilder monta_reg = new StringBuilder();
            StringBuilder monta_cod_depe = new StringBuilder();
            StringBuilder monta_Sub_Titu = new StringBuilder();
            StringBuilder monta_Des_Mista = new StringBuilder();
            StringBuilder monta_Cod_Trib_DESIF = new StringBuilder();
            StringBuilder monta_Valr_Cred_Mens = new StringBuilder();
            StringBuilder monta_Valr_Debt_Mens = new StringBuilder();
            StringBuilder monta_Rece_Decl = new StringBuilder();
            StringBuilder monta_Dedu_Rece_Decl = new StringBuilder();
            StringBuilder monta_Desc_Dedu = new StringBuilder();
            StringBuilder monta_Base_Calc = new StringBuilder();
            StringBuilder monta_Aliq_ISSQN = new StringBuilder();
            StringBuilder monta_Inct_Fisc = new StringBuilder();
            StringBuilder monta_Desc_Inct_Fisc = new StringBuilder();
            StringBuilder monta_Valr_ISSQN_Retd = new StringBuilder();
            StringBuilder monta_Motv_Nao_Exig = new StringBuilder();
            StringBuilder monta_Proc_Motv_Nao_Exig = new StringBuilder();


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
                            monta_cod_depe.Clear();
                            monta_Sub_Titu.Clear();
                            monta_Des_Mista.Clear();
                            monta_Cod_Trib_DESIF.Clear();
                            monta_Valr_Cred_Mens.Clear();
                            monta_Valr_Debt_Mens.Clear();                            
                            monta_Rece_Decl.Clear();
                            monta_Dedu_Rece_Decl.Clear();
                            monta_Desc_Dedu.Clear();
                            monta_Base_Calc.Clear();
                            monta_Aliq_ISSQN.Clear();
                            monta_Inct_Fisc.Clear();
                            monta_Desc_Inct_Fisc.Clear();
                            monta_Valr_ISSQN_Retd.Clear();
                            monta_Motv_Nao_Exig.Clear();
                            monta_Proc_Motv_Nao_Exig.Clear();
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
                                    case 3:
                                        {
                                            monta_cod_depe.Append(c);
                                            regi.cod_depe = monta_cod_depe.ToString();
                                            break;
                                        }
                                    case 4:
                                        {
                                            monta_Sub_Titu.Append(c);
                                            regi.Sub_Titu = monta_Sub_Titu.ToString();
                                            break;
                                        }
                                    case 5:
                                        {
                                            monta_Des_Mista.Append(c);
                                            regi.Des_Mista = monta_Des_Mista.ToString();
                                            break;
                                        }
                                    case 6:
                                        {
                                            monta_Cod_Trib_DESIF.Append(c);
                                            regi.Cod_Trib_DESIF = monta_Cod_Trib_DESIF.ToString();
                                            break;
                                        }
                                    case 7:
                                        {
                                            monta_Valr_Cred_Mens.Append(c);
                                            regi.Valr_Cred_Mens = monta_Valr_Cred_Mens.ToString();
                                            break;
                                        }
                                    case 8:
                                        {
                                            monta_Valr_Debt_Mens.Append(c);
                                            regi.Valr_Debt_Mens = monta_Valr_Debt_Mens.ToString();
                                            break;
                                        }
                                    case 9:
                                        {
                                            monta_Rece_Decl.Append(c);
                                            regi.Rece_Decl = monta_Rece_Decl.ToString();
                                            break;
                                        }
                                    case 10:
                                        {
                                            monta_Dedu_Rece_Decl.Append(c);
                                            regi.Dedu_Rece_Decl = monta_Dedu_Rece_Decl.ToString();
                                            break;
                                        }
                                    case 11:
                                        {
                                            monta_Desc_Dedu.Append(c);
                                            regi.Desc_Dedu = monta_Desc_Dedu.ToString();
                                            break;
                                        }
                                    case 12:
                                        {
                                            monta_Base_Calc.Append(c);
                                            regi.Base_Calc = monta_Base_Calc.ToString();
                                            break;
                                        }
                                    case 13:
                                        {
                                            monta_Aliq_ISSQN.Append(c);
                                            regi.Aliq_ISSQN = monta_Aliq_ISSQN.ToString();
                                            break;
                                        }
                                    case 14:
                                        {
                                            monta_Inct_Fisc.Append(c);
                                            regi.Inct_Fisc = monta_Inct_Fisc.ToString();
                                            break;
                                        }
                                    case 15:
                                        {
                                            monta_Desc_Inct_Fisc.Append(c);
                                            regi.Desc_Inct_Fisc = monta_Desc_Inct_Fisc.ToString();
                                            break;
                                        }
                                    case 16:
                                        {
                                            monta_Valr_ISSQN_Retd.Append(c);
                                            regi.Valr_ISSQN_Retd = monta_Valr_ISSQN_Retd.ToString();
                                            break;
                                        }
                                    case 17:
                                        {
                                            monta_Motv_Nao_Exig.Append(c);
                                            regi.Motv_Nao_Exig = monta_Motv_Nao_Exig.ToString();
                                            break;
                                        }
                                    case 18:
                                        {
                                            monta_Proc_Motv_Nao_Exig.Append(c);
                                            regi.Proc_Motv_Nao_Exig = monta_Proc_Motv_Nao_Exig.ToString();
                                            break;
                                        }

                                }


                            }
                            break;
                        }

                }




            }


            return regi;
        }


    }


}
