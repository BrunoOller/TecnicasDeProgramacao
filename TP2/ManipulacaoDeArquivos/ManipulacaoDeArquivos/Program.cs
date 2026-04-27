var caminho = @"C:\Users\0201392511015\Desktop\TecnicasDeProgramacao\TP2\ManipulacaoDeArquivos\ManipulacaoDeArquivos\arquivo1.txt";

if (!File.Exists(caminho)) {
    File.WriteAllText(caminho, "Autor Desconhecido");
}

var novoTexto = "\nQuem conta seus vales espanta" + Environment.NewLine + "Água mole em pedra dura tanto bate até que fura \n Casa de ferreiro espeto é";
File.AppendAllText(caminho, novoTexto);
string conteudo = File.ReadAllText(caminho);
Console.WriteLine(conteudo);