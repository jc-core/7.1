namespace Assignment7_1 {
    internal class SortFuncs {

        public static int[] SelectionSort(int[] scores) {

            int[] sorted = scores[..];

            for (int front = 0; front < sorted.Length - 1; front++) {

                int smallest = front;

                for (int check = front + 1; check < sorted.Length; check++)
                    if (sorted[check] < sorted[smallest])
                        smallest = check;

                int hold = sorted[front];
                sorted[front] = sorted[smallest];
                sorted[smallest] = hold;

            }

            return sorted;

        }

        public static int[] InsertionSort(int[] scores) {

            int[] sorted = scores[..];

            for (int next = 1; next < sorted.Length; next++) {

                int current = sorted[next];
                int back = next - 1;

                while (back >= 0 && sorted[back] > current) {
                    sorted[back + 1] = sorted[back];
                    back--;
                }

                sorted[back + 1] = current;

            }

            return sorted;

        }

        public static string MergeWords(string first, string second) {

            char[] merged = new char[first.Length + second.Length];

            int firstSpot = 0;
            int secondSpot = 0;
            int mergedSpot = 0;

            while (firstSpot < first.Length && secondSpot < second.Length) {
                merged[mergedSpot++] = first[firstSpot++];
                merged[mergedSpot++] = second[secondSpot++];
            }

            while (firstSpot < first.Length)
                merged[mergedSpot++] = first[firstSpot++];

            while (secondSpot < second.Length)
                merged[mergedSpot++] = second[secondSpot++];

            return new string(merged);

        }
    }
}
