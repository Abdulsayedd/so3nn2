using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace so3nn2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SortedDictionary<int,int> map = new SortedDictionary<int,int>();
        FileStream fs;StreamReader sr;StreamWriter sw;
        FileStream fs1; StreamReader sr1; StreamWriter sw1;
        public void op()
        {
            fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);sr = new StreamReader(fs);sw = new StreamWriter(fs);
        }
        public void op1()
        {
            fs1 = new FileStream("ind.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);sr1 = new StreamReader(fs1);sw1 = new StreamWriter(fs1);
        }
        public void cl() { fs.Close(); }
        public void cl1() { fs1.Close(); }
        public void t2m()
        {
            map.Clear();    op();    string l;  int c = 0;
            while((l=sr.ReadLine())!=null)
            {
                if (l[0] == '*') continue;
                string[] arr = l.Split('|');
                map.Add(int.Parse(arr[0]), c);
                c += l.Length + 2;
            }
            cl();
        }
        public void read()
        {
            op();   string l;
            while ((l = sr.ReadLine()) != null)
            {
                if (l[0] == '*') continue;
                bigtxt.Text += l+"\r\n";
            }
            cl();   bigtxt.Text += "========================\r\n";
        }
        public void ins()
        {
            op();   fs.Seek(0, SeekOrigin.End);
            sw.Write(idtxt.Text + '|' + nametxt.Text + '|' + balancetxt.Text+"\r\n");
            sw.Flush();     cl();   t2m();
        }
        public bool bs(int[] arr , int x)
        {
            int st = 0,      end = arr.Length-1,      mid;
            while(st<=end)
            {
                mid = (st + end) / 2;
                if (arr[mid] == x) return true;
                if (arr[mid] > x)end = mid - 1;
                if(arr[mid]<x) st = mid + 1;
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e){t2m();}
        private void insbtn_Click(object sender, EventArgs e)
        {
            int[] arr = map.Keys.ToArray();
            if (bs(arr, int.Parse(idtxt.Text)))
            {
                MessageBox.Show("Already exists!");
            }
            else ins();
        }
        private void readbtn_Click(object sender, EventArgs e) { read(); }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            int[] arr = map.Keys.ToArray();
            if (bs(arr, int.Parse(idtxt.Text))) MessageBox.Show("Found!");
            else MessageBox.Show("Not Found!");
        }
        public void del()
        {
            op();   string l;   int c = 0;
            while ((l = sr.ReadLine()) != null)
            {
                string[] arr = l.Split('|');
                if (l[0]!='*' && arr[0]==idtxt.Text)
                {
                    fs.Seek(c, SeekOrigin.Begin);
                    sw.Write('*');
                    sw.Flush();
                    break;
                }
                c += l.Length + 2;
            }
            cl();
        }
        private void delbtn_Click(object sender, EventArgs e)
        {
            int[] arr = map.Keys.ToArray();
            if (bs(arr, int.Parse(idtxt.Text)))
            {
                del();  t2m();
            }
            else MessageBox.Show("Not Found!");
        }
        public void rewrite()
        {
            op1();
            foreach (var i in map)
            {
                sw1.Write(i.Key + "\t" + i.Value + "\r\n");
                sw1.Flush();
            }
            cl1();
        }
        private void rebtn_Click(object sender, EventArgs e) { rewrite(); }
        private void clsbtn_Click(object sender, EventArgs e) { Environment.Exit(0); }
    }
}
