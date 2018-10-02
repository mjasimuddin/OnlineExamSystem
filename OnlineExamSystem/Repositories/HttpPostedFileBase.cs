using System.IO;

namespace OnlineExamSystem.Repositories
{
    public class HttpPostedFileBase
    {
        internal readonly Stream InputStream;
        internal readonly int ContentLength;
    }
}