using System;

namespace CompareString {
    class MyEqualerString {
        static public long LevenshteinDistance(string s1, string s2, long k = long.MaxValue) {
            if (s1.Length is 0) return s2.Length;
            if (s2.Length is 0) return s1.Length;

            int size = s2.Length + 1;
            bool use_optimaze = !k.Equals(long.MaxValue);

            long[][] D = new long[2][] { new long[size], new long[size] };

            D[0][0] = 0;
            D[1][0] = 1;
            for (int j = 1; j <= s2.Length; ++j) {
                D[0][j] = j;
            }

            for (int i = 1; i <= s1.Length; ++i) {
                for (int j = i; j <= s2.Length; ++j) {
                    D[1][j] = Math.Min(D[0][j] + 1, Math.Min(D[1][j - 1] + 1,
                                    D[0][j - 1] + (s1[i - 1] == s2[j - 1] ? 0 : 1)));
                }

                D[1].CopyTo(D[0], 0);
                D[1][0] = i + 1;

                if (use_optimaze) {
                    if (D[1][Math.Min(i, size - 1)] > k) {
                        return k;
                    }
                }
            }

            return D[Math.Min(1, s1.Length - 1)][size - 1];
        }

        static public long Damerau_LevenshteinDistance(string s1, string s2, long k = long.MaxValue) {
            if (s1.Length is 0) return s2.Length;
            if (s2.Length is 0) return s1.Length;

            int size = s2.Length + 1;
            bool use_optimaze = !k.Equals(long.MaxValue);

            long[][] D = new long[3][] { new long[size],
                                        new long[size], new long[size] };

            D[0][0] = 0;
            D[1][0] = 1;
            D[2][0] = 2;

            for (int j = 1; j <= s2.Length; ++j) {
                D[0][j] = j;
            }

            for (int j = 1; j <= s2.Length; ++j) {
                D[1][j] = Math.Min(D[0][j] + 1, Math.Min(D[1][j - 1] + 1,
                                    D[0][j - 1] + (s1[0] == s2[j - 1] ? 0 : 1)));
            }

            for (int i = 2; i <= s1.Length; ++i) {
                for (int j = i - 2; j <= s2.Length; ++j) {
                    if (j == 0) continue;

                    D[2][j] = Math.Min(D[1][j] + 1, Math.Min(D[2][j - 1] + 1,
                                    Math.Min(D[1][j - 1] + (s1[i - 1] == s2[j - 1] ? 0 : 1)
                                    , ((j - 2 >= 0 && s1[i - 1] == s2[j - 2]
                                    && s2[j - 1] == s1[i - 2])
                                    ? D[0][j - 2] + 1 : int.MaxValue))));
                }

                D[1].CopyTo(D[0], 0);
                D[2].CopyTo(D[1], 0);
                D[2][0] = i + 1;

                if (use_optimaze) {
                    if (D[1][Math.Min(i, size - 1)] > k) {
                        return k;
                    }
                }
            }

            return D[s1.Length < 2 ? 1 : 2][size - 1];
        }

        static public bool Equal(string s1, string s2,
                            Func<string, string, long, long> get_distance,
                            long k = 0) {
            return get_distance(s1, s2, k + 1) <= k;
        }
    }
}