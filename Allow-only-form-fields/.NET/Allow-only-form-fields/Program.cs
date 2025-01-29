using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;

namespace Allow_only_form_fields
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
                    //Set document protection with a password, allowing only form fields to be modified.
                    document.Protect(ProtectionType.AllowOnlyFormFields, "password");
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
