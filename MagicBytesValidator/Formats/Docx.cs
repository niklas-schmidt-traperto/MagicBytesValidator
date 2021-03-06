using MagicBytesValidator.Models;

namespace MagicBytesValidator.Formats
{
    public class Docx : FileType
    {
        public Docx() : base(
                             "application/vnd.openxmlformats-officedocument.wordprocessingml.document", 
                             new[] { "docx" }, 
                             new[]
                             {
                                 new byte[] { 50, 75, 3, 4 },
                                 new byte[] { 50, 75, 5, 6 },
                                 new byte[] { 50, 75, 7, 8 }
                             })
        {
        }
    }
}