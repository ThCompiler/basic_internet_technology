using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SearchString {
    class AzyncSearch {
        static public long NumberThread = 10;

        public AzyncSearch() {
            Text = new List<string>();
            _Statistic = new List<(long parametr, long time)>();
        }
        public AzyncSearch(List<string> text) {
            Text = text;
            _Statistic = new List<(long parametr, long time)>();
        }

        public List<(long length_string, long time)> GetStatistic {
            get { return _Statistic; }
        }

        public (long length_string, long time) GetLastStatistic {
            get { return _Statistic[_Statistic.Count - 1]; }
        }

        public (List<string> found_string, List<long> time) Search(string word, long save_parametr) {
            var timer = new Stopwatch();
            var Tasks = new List<Task<(List<string> found_string, long time)>>();

            int lenSubArray = Text.Count / (int)NumberThread;

            for(int i = 0; i < NumberThread; ++i) {
                List<string> tmp = Text.GetRange(i * lenSubArray
                                            , Math.Min(Text.Count - i * lenSubArray, lenSubArray));

                Tasks.Add(new Task<(List<string> found_string, long time)>(
                    _AskSearch, new Tuple<List<string>, string>(tmp, word)));
            }

            timer.Start();
            foreach (var i in Tasks) {
                i.Start();
            }
            Task.WaitAll(Tasks.ToArray());
            timer.Stop();

            (List<string> found_string, List<long> time) ans = (new List<string>(), new List<long>());
            foreach (var task in Tasks) {
                ans.found_string.AddRange(task.Result.found_string);
                ans.time.Add(task.Result.time);
            }


            _Statistic.Add((save_parametr, timer.ElapsedTicks));
            return ans;
        }
        
        static public Func<string, string, bool> IsEquls;

        private (List<string> found_string, long time) _AskSearch(object paramObj) {
            List<string> text = ((Tuple<List<string>, string>)paramObj).Item1;
            string word = ((Tuple<List<string>, string>)paramObj).Item2;

            (List<string> found_string, long time) ans = (new List<string>(), new long());
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            foreach (var s in text) {
                if (IsEquls(s, word)) {
                    ans.found_string.Add(s);
                }
            }
            stopwatch.Stop();

            ans.time = stopwatch.ElapsedTicks;
            return ans;
        }

        public List<string> Text { get; }

        private List<(long parametr, long time)> _Statistic;
    }
}