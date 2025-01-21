using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;

namespace Decrypt_password_protected_document
{
    class Program
    {
        static void Main(string[] args)
        {
            //Open the file as Stream.
            using (FileStream fileStream = new FileStream(Path.GetFullPath(@"Data/Template.docx"), FileMode.Open, FileAccess.ReadWrite))
            {
                //Open the encrypted Word document.
                using (WordDocument document = new WordDocument(fileStream, FormatType.Docx, "syncfusion"))
                {
                    //Removes encryption in Word document.            
                    document.RemoveEncryption();
                    // Save the Word document.
                    using (FileStream outputStream = new FileStream(Path.GetFullPath("../../../Result.docx"), FileMode.Create, FileAccess.ReadWrite))
                    {
                        document.Save(outputStream, FormatType.Docx);
                    }
                }
            }
        }
    }
}
