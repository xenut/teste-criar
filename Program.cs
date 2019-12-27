using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace teste_grupo_criar___kart
{



    class Corredor //para armazenar os dados
    {
        public DateTime hora { get; set; }
        public int codigo { get; set; }
        public string piloto { get; set; }
        public int volta { get; set; }
        public decimal tempo { get; set; }
        public decimal media { get; set; }
        public decimal mediaTotal { get; set; }
        public decimal tempoTotal { get; set; }
    }
    class TesteKart 
    {

        static void Main(string[] args)
        {
            //le todo o arquivo lembrando de mudar o diretorio do arquivo .log
            string arquivo = System.IO.File.ReadAllText(@"C:\Users\Nelson\Documents\teste\corrida.log");

            char[] separador = { '-', ' ' };

            Corredor c = new Corredor();

            if (arquivo == null ) //checando se arquivo está vazio
            {
                Console.WriteLine("Arquivo vazio.");
            }

            else
            {//se tiver dados ele continua:
                
                // quebrando em array tirando espacos em branco
                String[] strlist = arquivo.Split(separador,
                       StringSplitOptions.RemoveEmptyEntries);

                //pega os dados de cada linha e adiciona na lista em seu respectivo objeto

                //for (int a = 1; a < 24; a++) //estava repetindo o resultados e não conseguindo ordenar tive que preencher manual
                //{ //posicao no array e sempre repetida em intervalos de 7, por isso 7*i
                //new Corredor() {hora = Convert.ToDateTime(strlist[3+(7*i)]), codigo = Convert.ToInt32(strlist[4 + (7*i)]), piloto = (strlist[6 + (7*i)]), volta = Convert.ToInt32(strlist[7 + (7*i)]), tempo = Convert.ToDecimal(strlist[8 + (7*i)]), media = Convert.ToDecimal(strlist[9 + (7*i)]) }
                //} //ele atribui corretamente
                {
                    List<Corredor> lista = new List<Corredor>()
                {
                    new Corredor() { hora = Convert.ToDateTime(strlist[3+7]), codigo = Convert.ToInt32(strlist[4 + (7)]), piloto = (strlist[6 + (7)]), volta = Convert.ToInt32(strlist[7 + (7)]), tempo = Convert.ToDecimal(strlist[8 + (7)]), media = Convert.ToDecimal(strlist[9 + (7)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (14)]), piloto = (strlist[6 + (14)]), volta = Convert.ToInt32(strlist[7 + (14)]), tempo = Convert.ToDecimal(strlist[8 + (14)]), media = Convert.ToDecimal(strlist[9 + (14)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (21)]), piloto = (strlist[6 + (21)]), volta = Convert.ToInt32(strlist[7 + (21)]), tempo = Convert.ToDecimal(strlist[8 + (21)]), media = Convert.ToDecimal(strlist[9 + (21)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (28)]), piloto = (strlist[6 + (28)]), volta = Convert.ToInt32(strlist[7 + (28)]), tempo = Convert.ToDecimal(strlist[8 + (28)]), media = Convert.ToDecimal(strlist[9 + (28)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (35)]), piloto = (strlist[6 + (35)]), volta = Convert.ToInt32(strlist[7 + (35)]), tempo = Convert.ToDecimal(strlist[8 + (35)]), media = Convert.ToDecimal(strlist[9 + (35)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (42)]), piloto = (strlist[6 + (42)]), volta = Convert.ToInt32(strlist[7 + (42)]), tempo = Convert.ToDecimal(strlist[8 + (42)]), media = Convert.ToDecimal(strlist[9 + (42)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (49)]), piloto = (strlist[6 + (49)]), volta = Convert.ToInt32(strlist[7 + (49)]), tempo = Convert.ToDecimal(strlist[8 + (49)]), media = Convert.ToDecimal(strlist[9 + (49)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (56)]), piloto = (strlist[6 + (56)]), volta = Convert.ToInt32(strlist[7 + (56)]), tempo = Convert.ToDecimal(strlist[8 + (56)]), media = Convert.ToDecimal(strlist[9 + (56)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (63)]), piloto = (strlist[6 + (63)]), volta = Convert.ToInt32(strlist[7 + (63)]), tempo = Convert.ToDecimal(strlist[8 + (63)]), media = Convert.ToDecimal(strlist[9 + (63)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (70)]), piloto = (strlist[6 + (70)]), volta = Convert.ToInt32(strlist[7 + (70)]), tempo = Convert.ToDecimal(strlist[8 + (70)]), media = Convert.ToDecimal(strlist[9 + (70)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (77)]), piloto = (strlist[6 + (77)]), volta = Convert.ToInt32(strlist[7 + (77)]), tempo = Convert.ToDecimal(strlist[8 + (77)]), media = Convert.ToDecimal(strlist[9 + (77)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (84)]), piloto = (strlist[6 + (84)]), volta = Convert.ToInt32(strlist[7 + (84)]), tempo = Convert.ToDecimal(strlist[8 + (84)]), media = Convert.ToDecimal(strlist[9 + (84)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (91)]), piloto = (strlist[6 + (91)]), volta = Convert.ToInt32(strlist[7 + (91)]), tempo = Convert.ToDecimal(strlist[8 + (91)]), media = Convert.ToDecimal(strlist[9 + (91)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (98)]), piloto = (strlist[6 + (98)]), volta = Convert.ToInt32(strlist[7 + (98)]), tempo = Convert.ToDecimal(strlist[8 + (98)]), media = Convert.ToDecimal(strlist[9 + (98)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (105)]), piloto = (strlist[6 + (105)]), volta = Convert.ToInt32(strlist[7 + (105)]), tempo = Convert.ToDecimal(strlist[8 + (105)]), media = Convert.ToDecimal(strlist[9 + (105)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (112)]), piloto = (strlist[6 + (112)]), volta = Convert.ToInt32(strlist[7 + (112)]), tempo = Convert.ToDecimal(strlist[8 + (112)]), media = Convert.ToDecimal(strlist[9 + (112)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (119)]), piloto = (strlist[6 + (119)]), volta = Convert.ToInt32(strlist[7 + (119)]), tempo = Convert.ToDecimal(strlist[8 + (119)]), media = Convert.ToDecimal(strlist[9 + (119)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (126)]), piloto = (strlist[6 + (126)]), volta = Convert.ToInt32(strlist[7 + (126)]), tempo = Convert.ToDecimal(strlist[8 + (126)]), media = Convert.ToDecimal(strlist[9 + (126)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (133)]), piloto = (strlist[6 + (133)]), volta = Convert.ToInt32(strlist[7 + (133)]), tempo = Convert.ToDecimal(strlist[8 + (133)]), media = Convert.ToDecimal(strlist[9 + (133)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (140)]), piloto = (strlist[6 + (140)]), volta = Convert.ToInt32(strlist[7 + (140)]), tempo = Convert.ToDecimal(strlist[8 + (140)]), media = Convert.ToDecimal(strlist[9 + (140)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (147)]), piloto = (strlist[6 + (147)]), volta = Convert.ToInt32(strlist[7 + (147)]), tempo = Convert.ToDecimal(strlist[8 + (147)]), media = Convert.ToDecimal(strlist[9 + (147)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (154)]), piloto = (strlist[6 + (154)]), volta = Convert.ToInt32(strlist[7 + (154)]), tempo = Convert.ToDecimal(strlist[8 + (154)]), media = Convert.ToDecimal(strlist[9 + (154)]) },
                    new Corredor() { codigo = Convert.ToInt32(strlist[4 + (161)]), piloto = (strlist[6 + (161)]), volta = Convert.ToInt32(strlist[7 + (161)]), tempo = Convert.ToDecimal(strlist[8 + (161)]), media = Convert.ToDecimal(strlist[9 + (161)]) },
                };

                    //Filtra os resultados e apresenta o podium:
                    int i = 1;
                    var resultado = lista.GroupBy(x => x.codigo).Select(x => new { Cont = (i++), Hora = x.Sum(y => y.tempo), Nome = x.First().piloto, Cd = x.First().codigo, Lap = x.Last().volta, Med = x.Sum(y=> y.media) });
                    Console.WriteLine("O resultado da corrida e:");
                    foreach (var res in resultado)
                    {
                        Console.WriteLine("Posicao de chegada:" + res.Cont + " " + res.Nome + " " + res.Cd + "\t Numero de voltas completadas:" + res.Lap + "\t O tempo total foi de:" + res.Hora + " segundos." +"\n A velocidade media foi de:" + res.Med/res.Lap + "Km/h") ;
                    }
                    
                    Console.WriteLine("Pressione qualquer tecla para sair.");
                }


            }
        }
    }
}