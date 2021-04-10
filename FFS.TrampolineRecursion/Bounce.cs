using System;

namespace FFS.TrampolineRecursion
{
    public class Bounce<T>
    {
        private readonly bool _isFinalResult;
        private readonly T _result;
        private readonly Func<Bounce<T>> _nextBounce;

        public Bounce(T result, bool isFinalResult, Func<Bounce<T>> bounceFunc)
        {
            _isFinalResult = isFinalResult;
            _result = result;
            _nextBounce = bounceFunc;
        }

        public bool IsFinalResult { get { return _isFinalResult; } }
        public T Result { get { return _result; } }
        public Func<Bounce<T>> NextBounce { get { return _nextBounce; } }
    }
}
