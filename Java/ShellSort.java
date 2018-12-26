package Aglo4;

import edu.princeton.cs.algs4.StdOut;

import java.util.Comparator;

// copy
public class ShellSort
{
    public static void sort(Comparable[] a)
    {
        int N = a.length;
        int h = 1;
        while(h < N/3) h = 3 * h + 1;
        while(h >= 1)
        {
            // 数组变为h有序
            for(int i = h; i < N; i++)
            {
                for(int j = i; j >= h && less(a[j], a[j - h]); j -= h)
                    exch(a, j, j-h);
            }
            h = h / 3;
        }
    }

    // is v < w ?
    private static boolean less(Comparable v, Comparable w) {
        return v.compareTo(w) < 0;
    }

    // is v < w ?
    private static boolean less(Comparator comparator, Object v, Object w) {
        return comparator.compare(v, w) < 0;
    }


    // exchange a[i] and a[j]
    private static void exch(Object[] a, int i, int j) {
        Object swap = a[i];
        a[i] = a[j];
        a[j] = swap;
    }


    /***************************************************************************
     *  Check if array is sorted - useful for debugging.
     ***************************************************************************/

    // is the array a[] sorted?
    private static boolean isSorted(Comparable[] a) {
        return isSorted(a, 0, a.length - 1);
    }

    // is the array sorted from a[lo] to a[hi]
    private static boolean isSorted(Comparable[] a, int lo, int hi) {
        for (int i = lo + 1; i <= hi; i++)
            if (less(a[i], a[i-1])) return false;
        return true;
    }

    // is the array a[] sorted?
    private static boolean isSorted(Object[] a, Comparator comparator) {
        return isSorted(a, comparator, 0, a.length - 1);
    }

    // is the array sorted from a[lo] to a[hi]
    private static boolean isSorted(Object[] a, Comparator comparator, int lo, int hi) {
        for (int i = lo + 1; i <= hi; i++)
            if (less(comparator, a[i], a[i-1])) return false;
        return true;
    }



    // print array to standard output
    private static void show(String text, Comparable[] a) {
        System.out.print(text + ": ");
        for (int i = 0; i < a.length; i++) {
            StdOut.print(a[i]);
        }
        System.out.println();
    }

    /**
     * Reads in a sequence of strings from standard input; selection sorts them;
     * and prints them to standard output in ascending order.
     *
     * @param args the command-line arguments
     */
    public static void main(String[] args) {
        String[] a = {"S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E"};
        show("before", a);
        Selection.sort(a);
        show("after", a);
    }
}
