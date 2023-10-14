class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        Console.Write("Введіть ключ доступу (pro/exp): ");
        Console.ResetColor(); // сбрасываем в стандартный
        string key = Console.ReadLine().ToLower();

        DocumentWorker doc;

        if (key == "pro")
            doc = new ProDocumentWorker();
        else if (key == "exp")
            doc = new ExpertDocumentWorker();
        else
            doc = new DocumentWorker();

        doc.OpenDocument();
        doc.EditDocument();
        doc.SaveDocument();

        Console.ReadKey();
    }
}