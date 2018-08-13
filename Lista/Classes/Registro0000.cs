using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lista.Classes
{
    class Registro0000 : Registro
    {
        public string CNPJ;
        public string Nome;
        public string Tipo_Inti;
        public string Cod_Munc;
        public string Ano_Mes_Inic_Cmpe;
        public string Ano_Mes_Fim_Cmpe;
        public string Modu_Decl;
        public string Tipo_Decl;
        public string Prtc_Decl_Ante;
        public string Tipo_Cnso;
        public string CNPJ_Resp_Rclh;
        public string Idn_Versao;
        public string Tipo_Arred;

        public new void MostrarTodosRegistros(string caminhoarquivo)
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

        public Registro0000 RetornaRegistro(int numerolinha, string caminhoarquivo)
        {
            string c;
            int numcharnacoluna = 1;
            int numcoluna = 1;
            int numlinha = 1;
            StreamReader sr = new StreamReader(caminhoarquivo);
            Registro0000 regi = new Registro0000();
            StringBuilder monta_num_linha = new StringBuilder();
            StringBuilder monta_reg = new StringBuilder();
            StringBuilder monta_CNPJ = new StringBuilder();
            StringBuilder monta_Nome = new StringBuilder();
            StringBuilder monta_Tipo_Inti = new StringBuilder();
            StringBuilder monta_Cod_Munc = new StringBuilder();
            StringBuilder monta_Ano_Mes_Inic_Cmpe = new StringBuilder();
            StringBuilder monta_Ano_Mes_Fim_Cmpe = new StringBuilder();
            StringBuilder monta_Modu_Decl = new StringBuilder();
            StringBuilder monta_Tipo_Decl = new StringBuilder();
            StringBuilder monta_Prtc_Decl_Ante = new StringBuilder();
            StringBuilder monta_Tipo_Cnso = new StringBuilder();
            StringBuilder monta_CNPJ_Resp_Rclh = new StringBuilder();
            StringBuilder monta_Idn_Versao = new StringBuilder();
            StringBuilder monta_Tipo_Arred = new StringBuilder();


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
                            monta_CNPJ.Clear();
                            monta_Nome.Clear();
                            monta_Tipo_Inti.Clear();
                            monta_Cod_Munc.Clear();
                            monta_Ano_Mes_Inic_Cmpe.Clear();
                            monta_Ano_Mes_Fim_Cmpe.Clear();
                            monta_Modu_Decl.Clear();
                            monta_Tipo_Decl.Clear();
                            monta_Prtc_Decl_Ante.Clear();
                            monta_Tipo_Cnso.Clear();
                            monta_CNPJ_Resp_Rclh.Clear();
                            monta_Idn_Versao.Clear();
                            monta_Tipo_Arred.Clear();
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
                                            monta_CNPJ.Append(c);
                                            regi.CNPJ = monta_CNPJ.ToString();
                                            break;
                                        }
                                    case 4:
                                        {
                                            monta_Nome.Append(c);
                                            regi.Nome = monta_Nome.ToString();
                                            break;
                                        }
                                    case 5:
                                        {
                                            monta_Tipo_Inti.Append(c);
                                            regi.Tipo_Inti = monta_Tipo_Inti.ToString();
                                            break;
                                        }
                                    case 6:
                                        {
                                            monta_Cod_Munc.Append(c);
                                            regi.Cod_Munc = monta_Cod_Munc.ToString();
                                            break;
                                        }
                                    case 7:
                                        {
                                            monta_Ano_Mes_Inic_Cmpe.Append(c);
                                            regi.Ano_Mes_Inic_Cmpe = monta_Ano_Mes_Inic_Cmpe.ToString();
                                            break;
                                        }
                                    case 8:
                                        {
                                            monta_Ano_Mes_Fim_Cmpe.Append(c);
                                            regi.Ano_Mes_Fim_Cmpe = monta_Ano_Mes_Fim_Cmpe.ToString();
                                            break;
                                        }
                                    case 9:
                                        {
                                            monta_Modu_Decl.Append(c);
                                            regi.Modu_Decl = monta_Modu_Decl.ToString();
                                            break;
                                        }
                                    case 10:
                                        {
                                            monta_Tipo_Decl.Append(c);
                                            regi.Tipo_Decl = monta_Tipo_Decl.ToString();
                                            break;
                                        }
                                    case 11:
                                        {
                                            monta_Prtc_Decl_Ante.Append(c);
                                            regi.Prtc_Decl_Ante = monta_Prtc_Decl_Ante.ToString();
                                            break;
                                        }
                                    case 12:
                                        {
                                            monta_Tipo_Cnso.Append(c);
                                            regi.Tipo_Cnso = monta_Tipo_Cnso.ToString();
                                            break;
                                        }
                                    case 13:
                                        {
                                            monta_CNPJ_Resp_Rclh.Append(c);
                                            regi.CNPJ_Resp_Rclh = monta_CNPJ_Resp_Rclh.ToString();
                                            break;
                                        }
                                    case 14:
                                        {
                                            monta_Idn_Versao.Append(c);
                                            regi.Idn_Versao = monta_Idn_Versao.ToString();
                                            break;
                                        }
                                    case 15:
                                        {
                                            monta_Tipo_Arred.Append(c);
                                            regi.Tipo_Arred = monta_Tipo_Arred.ToString();
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
