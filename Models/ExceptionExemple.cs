namespace ExceptionHandling.Models
{
    //Exemplo para mostrar o caminho de uma exception.
    //Lemos de baixo para cima.
    public class ExceptionExemple
    {
        public void Metodo1()
        {
            Metodo2();
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção.");
        }
    }
}