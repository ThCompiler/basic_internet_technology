using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace SparseMatrix {
    public class MatrixV3<T>: Matrix<T> {

        int maxZ;

        public MatrixV3(int px, int py, int pz, T nullElementParam = default) 
               : base(px, py, nullElementParam) {
            maxZ = pz;
        }

        void CheckBounds(int x, int y, int z) {
            CheckBounds(x, y);
            if (z < 0 || z >= maxZ) 
                    throw new Exception("z=" + z + " выходит за границы");
        }

        string DictKey(int x, int y, int z) {
            return DictKey(x, y) + "_" + z.ToString();
        }

        public T this[int x, int y, int z] {
            get {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);

                if (_matrix.ContainsKey(key)) {
                    return _matrix[key];
                }
                else {
                    return nullElement;
                }
            }
            set {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                _matrix.Add(key, value);
            }
        }

        public new T this[int x, int y] {
            get {
                throw new NotSupportedException("Метод не поддерживается.");
            }
            set {
                throw new NotSupportedException("Метод не поддерживается.");
            }
        }

        public override string ToString() {
            StringBuilder b = new StringBuilder();
            for (int k = 0; k < maxZ; k++) {
                b.Append("[");

                for (int j = 0; j < maxY; j++) {
                    if (j > 0) b.Append(",\t");
                    b.Append("[");

                    for (int i = 0; i < maxX; i++) {
                        if (i > 0) b.Append(";\t");
                        b.Append(this[i, j, k]?.ToString() ?? "null");
                    }

                    b.Append("]");
                }
                b.Append("]\n");
            }

            return b.ToString();
        }
    }
}