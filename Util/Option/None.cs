using System;

namespace Util.Option
{
    public class None<T> : Option<T>
    {
        internal None() {}
        public override void Match(Action<T> some, Action none) => none();
        public override Option<TOut> Map<TOut>(Func<T, TOut> mapper) => new None<TOut>();
        public override Option<TOut> Cast<TOut>() => new None<TOut>();
        public override T OrElse(T value) => value;
    }
}