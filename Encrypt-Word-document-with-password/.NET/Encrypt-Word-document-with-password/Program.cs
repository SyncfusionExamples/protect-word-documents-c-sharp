using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Data;
using System.IO;

namespace Encrypt_Word_document_with_password
{
    class Program
    {
        static void Main(string[] args)
        {
            //Open the file as a stream.
            using (FileStream fileStream = new FileStream(Path.GetFullPath(@"Data/Template.docx"), FileMode.Open, FileAccess.ReadWrite))
            {
                //Load an existing Word document.
                using (WordDocument document = new WordDocument(fileStream, FormatType.Docx))
                {
                    //Encrypt the Word document with a password.           
                    document.EncryptDocument("password");
                    // Save the Word document.
                    using (FileStream outputStream = new FileStream(Path.GetFullPath(@"../../../Result.docx"), FileMode.Create, FileAccess.ReadWrite))
                    {
                        document.Save(outputStream, FormatType.Docx);
                    }
                }
            }
        }
    }
}
