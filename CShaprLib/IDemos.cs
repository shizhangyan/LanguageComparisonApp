using System.Collections.Generic;

namespace CShaprLib
{
    public interface IDemos
    {
        List<string> LoadFile();
        void PrintFullName(string firstName, string lastName);
    }
}