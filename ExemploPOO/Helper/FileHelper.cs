
using System.IO;

namespace ExemploPOO.Helper;
using System.Collections.Generic;

    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho,"*(2).txt", SearchOption.AllDirectories); //Traga qualquer coisa com .txt

            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho)
        {
            var retorno =  Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos){
            Directory.Delete(caminho, apagarArquivos);
        }

        public void CriarArquivoTexto(string caminho, string conteudo){
            if(!File.Exists(caminho))
            {
            File.WriteAllText(caminho,conteudo);
            }
        }
        public void CriarArquivoStream(string caminho, List<string> conteudo)
        {
            //File é um classe
            using (var stream = File.CreateText(caminho)) //Garante que o arquivo seja liberado para outro prcesso
            foreach (var linha in conteudo){
                stream.WriteLine(linha); //Vai escrever a linha na stream e a stream vai escrever o arquivo
            }

        }
        public void AdicionarTexto(string caminho, string conteudo){
            File.AppendAllText(caminho, conteudo);
        }

        public void AdicionarTextoArquivoStream(string caminho, List<string> conteudo)
        {
            //File é um classe
            using (var stream = File.AppendText(caminho)) 
            foreach (var linha in conteudo){
                stream.WriteLine(linha); //Vai escrever a linha na stream e a stream vai escrever o arquivo
            }

        }

        public void LerArquivo(string caminho){
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }

        }
        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho)){
                while ((linha = stream.ReadLine())!=null)
                {
                     System.Console.WriteLine(linha);
                }
            }
        }
        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever); //também é possível sobrescrever aqui, igualmente em copiar arquivo
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever){
            File.Copy(caminho, novoCaminho, sobrescrever); // Pode ou não sobrescrever um arquivo de nome igual
        }
        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
        
    }

