﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {
        public static IEnumerable<T> Reverse<T>(IEnumerable<T> source) => source.Reverse();

        public static IEnumerable<T> Drop<T>(int count, IEnumerable<T> source) => source.Skip(count);

        public static IEnumerable<T> Take<T>(int count, IEnumerable<T> source) => source.Take(count);

        public static IEnumerable<T> Sort<T>(IEnumerable<T> source) => source.OrderBy(x => x);

        public static IEnumerable<T> Unique<T>(IEnumerable<T> source) => source.Distinct();

        public static IEnumerable<T> DefaultTo<T>(T value, IEnumerable<T> source) => source.DefaultIfEmpty(value);

        public static T First<T>(IEnumerable<T> source) => source.First();

        public static T Last<T>(IEnumerable<T> source) => source.Last();
    }
}