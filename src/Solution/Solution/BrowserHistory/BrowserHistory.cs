using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution.BrowserHistory
{
    public class HistoryManager
    {
        private Stack<string> backStack = new Stack<string>();
        private Stack<string> forwardStack = new Stack<string>();
        private string currentPage = "";

        public void KunjungiHalaman(string url)
        {
            if (!string.IsNullOrEmpty(currentPage))
            {
                backStack.Push(currentPage);
            }
            currentPage = url;
            forwardStack.Clear();
        }

        public string Kembali()
        {
            if (backStack.Count == 0)
            {
                return "Tidak ada halaman sebelumnya.";
            }
            forwardStack.Push(currentPage);
            currentPage = backStack.Pop();
            return currentPage;
        }

        public string LihatHalamanSaatIni()
        {
            return currentPage;
        }

        public void TampilkanHistory()
        {
            var history = backStack.Reverse().ToList();
            history.Add(currentPage); 

            foreach (var page in history)
            {
                Console.WriteLine(page);
            }
        }
    }
}
