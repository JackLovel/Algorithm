package Aglo4;

import edu.princeton.cs.algs4.*;

// copy from edu_princeton_cs_algs4
public class Quick {

    public static void sort(Comparable[] a){
        StdRandom.shuffle(a);
        sort(a, 0, a.length - 1);
    }

    private static void sort(Comparable[] a, int lo, int hi){
        if(hi <= lo) return;
        int j = parition(a, lo, hi);   // 切分
        sort(a, lo, j - 1);
        sort(a, j + 1, hi);
    }

    private static boolean less(Comparable v, Comparable w){
        return v.compareTo(w) < 0;
    }

    private static void exch(Object[] a, int i, int j){
        Object swap = a[i];
        a[i] = a[j];
        a[j] = swap;
    }

    private static int parition(Comparable[] a, int lo, int hi) {
        // a[lo..i-1] a[i] [a+i..hi]
        int i = lo, j = hi + 1;
        Comparable v = a[lo];
        while (true)
        {
            while(less(a[++i], v)) if(i == hi) break;
            while(less(v, a[--j])) if(j == lo) break;
            if(i >= j) break;
            exch(a, i, j);
        }
        exch(a, lo, j);
        return j;  // a[lo..j-1] <= a[j] <= a[j+1..hi]
    }

    private static void show(String text, Comparable[] a) {
        System.out.print(text + ": ");
        for (int i = 0; i < a.length; i++) {
            System.out.print(a[i]);
        }
        System.out.println();
    }
    public static void main(String args[]){
        String[] a = {"R", "A", "T", "E", "L", "E", "P", "U", "I", "M", "Q", "C",
                      "X", "O", "S"};
        show("before",a);
        sort(a);
        show("after", a);
    }
}
