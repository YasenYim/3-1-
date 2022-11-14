using System;
using System.Collections.Generic;

namespace _3_1_列表
{
    class Program
    {
        static void PrintList(List<int> list)
        {
            for (int i = 0;i<list.Count;i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        static void PrintList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 8,9,10};
            List<int> list = new List<int>();
            List<int> list2 = new List<int> { 3, 4, 5, 6 };

            // 添加元素
            list.Add(1);         // Add在尾部添加
            list.Add(2);
            list.Add(3);         //[1,2,3]


            // 范围添加
            list.AddRange(array);           // [1,2,3,8,9,10]
            list.AddRange(list2);           // [1,2,3,8,9,10,3,4,5,6]

            // 删除
            //list.Remove

            // 按下标删除元素，后面的元素会往前挪
            list.RemoveAt(0);           // [2,3,8,9,10,3,4,5,6]
            list.RemoveAt(1);           // [3,8,9,10,3,4,5,6]


            // 按内容删除元素
            list.Remove(9);             // [3,8,10,3,4,5,6]

            // 下标访问
            int n = list[2];             // n == 10;
            n = list[list.Count - 1];    // n == 6  最后一个元素
            list[list.Count - 1] = 999;

            // 在中间插入元素. Insert(下标，元素)  在下标之前插入元素
            list.Insert(0, 0);             // [0,3,8,10,3,4,5,999]

            // 遍历
            PrintList(list);

            List<string> strList = new List<string>();
            strList.Add("一");
            strList.Add("二");
            strList.Add("三");

            PrintList(strList);

            // 更多方法
            int index = list.IndexOf(999);    // 7
            list.Sort();                      // 从小到大排序
            list.Reverse();                   // 翻转
            list.LastIndexOf(999);
            int[] temp = list.ToArray();      // 把list转化成一个数组

            Console.ReadKey();
        }
    }
}
