using System;

namespace DecorationIssue
{
    public interface IQueryHandler<T>
    {
        T Handle();
    }

    public class GetIntQueryHandler : IQueryHandler<int>
    {
        public int Handle()
        {
            Console.WriteLine("int");
            return 0;
        }
    }

    public class GetDoubleQueryHandler : IQueryHandler<double>
    {
        public double Handle()
        {
            Console.WriteLine("double");
            return 0.0;
        }
    }

    public interface IMySpecialHandler : IQueryHandler<string> { }

    public class MySpecialHandler : IMySpecialHandler
    {
        public string Handle()
        {
            Console.WriteLine("string");
            return "";
        }
    }

    public class Decorator<T> : IQueryHandler<T>
    {
        private readonly IQueryHandler<T> _inner;

        public Decorator(IQueryHandler<T> inner)
        {
            _inner = inner;
        }

        public T Handle()
        {
            Console.WriteLine("string");
            return _inner.Handle();
        }
    }
}
