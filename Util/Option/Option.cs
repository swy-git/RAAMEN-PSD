using System;

namespace Util.Option
{
    public abstract class Option<T>
    {
        public abstract void Match(Action<T> some, Action none);
        public abstract Option<TOut> Map<TOut>(Func<T, TOut> mapper);
        public abstract Option<TOut> Cast<TOut>() where TOut : class;
        public abstract T OrElse(T value);
    }

    public static class Option
    {
        public static Option<T> Some<T>(T value) => new Some<T>(value);
        public static Option<T> None<T>() => new None<T>();

        public static Option<T> ToOption<T>(this T nullableObject) =>
            nullableObject != null 
                ? Some(nullableObject) 
                : None<T>();
    }
}