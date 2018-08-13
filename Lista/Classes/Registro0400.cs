using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lista.Classes
{
    class Registro0400 : Registro
    {
        public string cod_depe;
        public string indr_insc_munl;
        public string cnpj_proprio;
        public string tipo_depe;
        public string endr_depe;
        public string cnpj_unif;
        public string cod_munc;
        public string ctbl_propria;
        public string dat_inic_para;
        public string dat_fim_para;



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

        public Registro0400 RetornaRegistro(int numerolinha, string caminhoarquivo)
        {
            string c;
            int numcharnacoluna = 1;
            int numcoluna = 1;
            int numlinha = 1;
            StreamReader sr = new StreamReader(caminhoarquivo);
            Registro0400 regi = new Registro0400();
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
                            monta_cod_depe.Clear();
                            monta_indr_insc_munl.Clear();
                            monta_cnpj_proprio.Clear();
                            monta_tipo_depe.Clear();
                            monta_endr_depe.Clear();
                            monta_cnpj_unif.Clear();
                            monta_cod_munc.Clear();
                            monta_ctbl_propria.Clear();
                            monta_dat_inic_para.Clear();
                            monta_dat_fim_para.Clear();
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
                                            monta_indr_insc_munl.Append(c);
                                            regi.indr_insc_munl = monta_indr_insc_munl.ToString();
                                            break;
                                        }
                                    case 5:
                                        {
                                            monta_cnpj_proprio.Append(c);
                                            regi.cnpj_proprio = monta_cnpj_proprio.ToString();
                                            break;
                                        }
                                    case 6:
                                        {
                                            monta_tipo_depe.Append(c);
                                            regi.tipo_depe = monta_tipo_depe.ToString();
                                            break;
                                        }
                                    case 7:
                                        {
                                            monta_endr_depe.Append(c);
                                            regi.endr_depe = monta_endr_depe.ToString();
                                            break;
                                        }
                                    case 8:
                                        {
                                            monta_cnpj_unif.Append(c);
                                            regi.cnpj_unif = monta_cnpj_unif.ToString();
                                            break;
                                        }
                                    case 9:
                                        {
                                            monta_cod_munc.Append(c);
                                            regi.cod_munc = monta_cod_munc.ToString();
                                            break;
                                        }
                                    case 10:
                                        {
                                            monta_ctbl_propria.Append(c);
                                            regi.ctbl_propria = monta_ctbl_propria.ToString();
                                            break;
                                        }
                                    case 11:
                                        {
                                            monta_dat_inic_para.Append(c);
                                            regi.dat_inic_para = monta_dat_inic_para.ToString();
                                            break;
                                        }
                                    case 12:
                                        {
                                            monta_dat_fim_para.Append(c);
                                            regi.dat_fim_para = monta_dat_fim_para.ToString();
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

        private Registro0400 RetiraZeroDoRegistro(Registro0400 reg)
        {
            Registro0400 regi = new Registro0400();
            regi = reg;

            regi.cod_depe = regi.cod_depe.TrimStart('0');
            regi.cnpj_proprio = regi.cnpj_proprio.TrimStart('0');
            regi.cnpj_unif = regi.cnpj_unif.TrimStart('0');


            return regi;

        }

        public void ListaRegistro(Registro0400 r)
        {
            Console.WriteLine(r.num_linha + "|" + r.reg + "|" + r.cod_depe + "|" + r.indr_insc_munl + "|" + r.cnpj_proprio + "|" + r.tipo_depe + "|" + r.endr_depe
                    + "|" + r.cnpj_unif + "|" + r.cod_munc + "|" + r.ctbl_propria + "|" + r.dat_inic_para + "|" + r.dat_fim_para);
        }
    }
    
}
