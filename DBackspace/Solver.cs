using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBackspace
{
    public class Solver
    {
        readonly string source;
        readonly string target;
        readonly Dictionary<string, bool> cache = new();

        bool? isSolvable;

        public int Steps { get; private set; }

        public Solver(string source, string target)
        {
            this.source = source;
            this.target = target;
        }

        public bool IsSolvable()
        {
            if (isSolvable.HasValue)
            {
                return isSolvable.Value;
            }

            if (target == source)
            {
                return true;
            }

            if (target.Length > source.Length)
            {
                return false;
            }

            //isSolvable =  IsSolvableRecursive(source, "");
            isSolvable = IsSolvableIterative();
            //isSolvable =  IsSolvableAI();
            //isSolvable =  IsSolvableMy();
            return isSolvable.Value;
        }

        private bool IsSolvableRecursive(string source, string stage)
        {
            string key = $"{source};{stage}";
            //Console.WriteLine(key);
            Steps++;
            if (cache.TryGetValue(key, out bool value))
            {
                return value;
            }

            if (source == "")
            {
                return stage == target;
            }

            bool append = IsSolvableRecursive(source[1..], stage + source[0]);
            bool delete = IsSolvableRecursive(source[1..], stage[..Math.Max(stage.Length - 1, 0)]);
            bool result = append || delete;
            _ = cache.TryAdd(key, result);
            return result;
        }

        private bool IsSolvableIterative()
        {
            Stack<Params> stack = new();
            stack.Push(new Params(source, ""));
            while (stack.TryPop(out var stackFrame))
            {
                string source = stackFrame.Source;
                string stage = stackFrame.Stage;
                string key = $"{source};{stage}";
                //Console.WriteLine(key);
                Steps++;
                if (!cache.ContainsKey(key))
                {
                    cache.Add(key, true);
                    if (source == "")
                    {
                        if (stage == target)
                        {
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    stack.Push(new Params(source[1..], stage + source[0]));
                    stack.Push(new Params(source[1..], stage[..Math.Max(stage.Length - 1, 0)]));
                }
            }

            return false;
        }

        private bool IsSolvableAI()
        {
            Stack<char> source = new(this.source);
            Stack<char> target = new(this.target);
            while (source.Any() && target.Any())
            {
                //Console.WriteLine(new string(target.ToArray()));
                Steps++;

                char available = source.Pop();
                char needed = target.Peek();
                if (available == needed)
                {
                    target.Pop();
                }
                else
                {
                    _ = source.TryPop(out _);
                }
            }

            return !target.Any();
        }
    }
}
