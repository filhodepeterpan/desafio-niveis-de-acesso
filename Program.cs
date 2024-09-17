using System;

class Program{
    static void Main(){
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string[] funcionarios = {"Maria", "João", "Geraldo", "Márcia", "Camila", "Mauro", "Pedro", "Jhonatan", "Daiane", "Gustavo"};
        string [] funcoes = {"Admnistrador", "Operador", "Operador", "Gerente", "Gerente", "Operador", "Operador", "Admnistrador", "Admnistrador", "Operador"};

        int nivelDeAcessoMaria = 36;
        int nivelDeAcessoJoao = 13;
        int nivelDeAcessoGeraldo = 12;
        int nivelDeAcessoMarcia = 19;
        int nivelDeAcessoCamila = 28;
        int nivelDeAcessoMauro = 15;
        int nivelDeAcessoPedro = 20;
        int nivelDeAcessoJhonatan = 58;
        int nivelDeAcessoDaiane = 41;
        int nivelDeAcessoGustavo = 18;
        int nivelDeAcesso = 0;

        string funcionarioAtual = "";
        string funcaoAtual = "";
        string permissao = "";
        string colunaFuncionario = "FUNCIONARIO";
        string colunaCargo = "CARGO";
        string colunaNivel = "NÍVEL";
        string colunaPermissao = "PERMISSÃO";

        Console.WriteLine($"{colunaFuncionario.PadRight(12)}\t{colunaCargo.PadRight(16)}\t{colunaNivel.PadRight(8)}\t{colunaPermissao}");
        Console.Write("\n");

        int indice = 0;

        foreach(string funcionario in funcionarios){

            if(funcionario == "Maria"){
                funcionarioAtual = "Maria";
                nivelDeAcesso = nivelDeAcessoMaria;
            }
            else if(funcionario == "João"){
                funcionarioAtual = "João";
                nivelDeAcesso = nivelDeAcessoJoao;
            }
            else if(funcionario == "Geraldo"){
                funcionarioAtual = "Geraldo";
                nivelDeAcesso = nivelDeAcessoGeraldo;
            }
            else if(funcionario == "Márcia"){
                funcionarioAtual = "Márcia";
                nivelDeAcesso = nivelDeAcessoMarcia;
            }
            else if(funcionario == "Camila"){
                funcionarioAtual = "Camila";
                nivelDeAcesso = nivelDeAcessoCamila;
            }
            else if(funcionario == "Mauro"){
                funcionarioAtual = "Mauro";
                nivelDeAcesso = nivelDeAcessoMauro;
            }
            else if(funcionario == "Pedro"){
                funcionarioAtual = "Pedro";
                nivelDeAcesso = nivelDeAcessoPedro;
            }
            else if(funcionario == "Jhonatan"){
                funcionarioAtual = "Jhonatan";
                nivelDeAcesso = nivelDeAcessoJhonatan;
            }
            else if(funcionario == "Daiane"){
                funcionarioAtual = "Daiane";
                nivelDeAcesso = nivelDeAcessoDaiane;
            }
            else if(funcionario == "Gustavo"){
                funcionarioAtual = "Gustavo";
                nivelDeAcesso = nivelDeAcessoGustavo;
            }

            funcaoAtual = funcoes[indice];

            if(funcaoAtual.Contains("Admnistrador")){
                funcaoAtual = "Administrador";
                permissao = nivelDeAcesso > 55 ? "✅" : "⛔";
            }
            else if(funcaoAtual.Contains("Gerente")){
                funcaoAtual = "Gerente";
                permissao = nivelDeAcesso > 20 ? "✅" : "⛔";
            }
            else{
                funcaoAtual = "Operador";
                permissao = "⛔";
            }

            Console.WriteLine($"{funcionarioAtual.PadRight(12)}\t{funcaoAtual.PadRight(16)}\t{nivelDeAcesso.ToString().PadRight(12)}\t{permissao}");
            Console.Write("\n");

            indice++;
        }
    }
}
