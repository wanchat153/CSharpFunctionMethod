﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*
int i = int.Parse(10);

Access Specifier = กำหนดขอบเขตการทำงานของฟังก์ชัน เช่น int
Returb Type = ค่าที่จะคืนกลับมา เช่น Parse
Method Name = ชื่อของ Function, Method, Variable(ตัวแปร หรือ var ตั้งให้สื่อความหมาย)
Parameter List = กำหนดว่า รับข้อมูลอะไรเข้าไปประมวลผลได้บ้าง เช่น int.Parse("10");
Method Body = code การทำงาน

<Access Specifier><Returb Type><Method Name>(Parameter List)
{
    Method Body
}
*/

namespace CSharpFunctionMethod
{
    internal class Program
    {
        //static = Keyword ฟังก์ชันการทำงานนั้นๆ ทำงานจาก blueprint ได้เลย
        static void Main(string[] args)
        {
            //sayHelloWorld10();
            Console.WriteLine(calulate());
            Console.ReadLine();
        }

        //private = ใช้งานเฉพาะภายใน class Program
        //void = จะไม่ return ค่าต่างๆ ออกไปใช้งาน
        private static void sayHelloWorld10()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " Hello World");
            }
        }

        private static int calulate()
        {
            int a = 10;
            int b = 6;
            int sum = a + b / 2;
            return sum;
        }
    }
}
