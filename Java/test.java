import java.io.*;
import java.net.*;

public class test {
    public static void main(String[] args)
    {
        int s = 0;
        boolean flag = false;
        while(true)
        {
            flag = false;
            for (int i = 2; i <= s / 2; ++i)
            {
                if (s % i == 0)
                {
                    flag = true;
                    break;
                }
            }
            if(!flag)
            System.out.println(s);
            s++;
        }
    }
} 