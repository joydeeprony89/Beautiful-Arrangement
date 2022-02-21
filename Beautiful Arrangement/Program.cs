using System;

namespace Beautiful_Arrangement
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      int n = 3;
      Solution s = new Solution();
      var result = s.CountArrangement(n);
      Console.WriteLine(result);
    }
  }

  public class Solution
  {
    int count = 0;
    public int CountArrangement(int n)
    {
      bool[] visited = new bool[n + 1];

      Helper(n, 1, visited);
      return count;
    }

    void Helper(int length, int pos, bool[] visited)
    {
      if (pos > length)
      {
        count++;
        return;
      }
      for(int i = 1; i <= length; i++)
      {
        if (!visited[i] && (pos % i == 0 || i % pos == 0))
        {
          visited[i] = true;
          Helper(length, pos + 1, visited);
          visited[i] = false;
        }
      }
    }
  }
}
