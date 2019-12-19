using System;
using System.IO;


namespace R5T.Worcester
{
    public interface ITextSerializer<T>
    {
        T Deserialize(TextReader reader);

        void Serialize(TextWriter writer, T value);
    }
}
