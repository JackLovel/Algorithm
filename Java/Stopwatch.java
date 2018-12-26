package Aglo4;

// Caluate a program run need time 
import edu.princeton.cs.algs4.*;

public class Stopwatch {
    private final long start;

    public Stopwatch(){
        start = System.currentTimeMillis();
    }

    public double elapsedTime(){
        long now = System.currentTimeMillis(); // 毫秒
        return (now - start) / 1000.0;         // 转化为秒
    }

    private static void main(String[] args){
        int N = Integer.parseInt(args[0]);
        int[] a = new int[N];
        for(int i = 0; i < N; i++)
            a[i] = StdRandom.uniform(-1000000, 1000000);
        Stopwatch timer = new Stopwatch();
        int cnt = ThreeSum.count(a);
        double time = timer.elapsedTime();     // 所需要时间
        StdOut.println(cnt + " tripes " + time + " seconds " );
    }
}
