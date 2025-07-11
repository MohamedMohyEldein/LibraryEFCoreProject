using LibraryEFCoreProj.LibraryContext;
using LibraryEFCoreProj.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryEFCoreProj
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (var context = new AppDBContext())
            {
                Library.MainMenu(context);
            }
        }



    }
}
