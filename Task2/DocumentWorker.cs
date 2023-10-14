using System;

class DocumentWorker
{
    public void OpenDocument()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Документ відкритий");
    }

    public void EditDocument()
    {
        Console.WriteLine("Редагування документа доступне у версії - Про");
    }

    public void SaveDocument()
    {
        Console.WriteLine("Збереження документа доступне у версії - Про");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public new void EditDocument()
    {
        Console.WriteLine("Документ відредаговано.");
    }

    public new void SaveDocument()
    {
        Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public new void SaveDocument()
    {
        Console.WriteLine("Документ збережено у новому форматі");
    }
}