/*
## 作業一
## 日期：2017.03.04
## 姓名：王柏鈞
## 學號：F74046153
## 作業說明：
    - 以 C# 實做陣列排序
    - 規定
        - 需使用動態陣列
        - 需使用排序函式（sort function）
        - 需使用while迴圈使程式能持續執行
    - 額外製作：
        - 初次輸入防呆
            : 開始時將其他功能關閉，僅限使用輸入，避免未輸入任何資料便排序的可能
        - 新增兩種排序
            : 除規定之國文，亦新增以數學、英文成績作為排序依據

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int option,seat_num;
            int num_people;
            string[] name;
            int[]  chinese_grade, english_grade, math_grade,tmp;
            // 前製作業
            // 班級人數
            while(true){
                Console.WriteLine("1> 輸入 2> 印出 3> 排序 -1>離開");
                option = Convert.ToInt32(Console.ReadLine());
                if(option == 1){
                    Console.WriteLine("請輸入班級人數：（僅第一次輸入需要使用）");
                    num_people = Convert.ToInt32(Console.ReadLine());                
                    break;
                }
                else if(option == -1)
                    return;
                else
                    Console.WriteLine("必須先輸入班級人數，才能做其他功能");
                
                Console.WriteLine();
            }
            name          = new string[num_people];
            chinese_grade = new int[num_people];
            english_grade = new int[num_people];
            math_grade    = new int[num_people];
            tmp           = new int[num_people];
            // 進入迴圈
            while(true){
                Console.WriteLine("1> 輸入 2> 印出 3> 排序 -1>離開");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                    {
                        // 座號
                        Console.WriteLine("請輸入座號：");
                        seat_num = Convert.ToInt32(Console.ReadLine())-1;
                        // 姓名
                        Console.WriteLine("請輸入姓名：");
                        name[seat_num] =  Console.ReadLine();
                        // 國文成績
                        Console.WriteLine("請輸入國文成績：");
                        chinese_grade[seat_num] = Convert.ToInt32(Console.ReadLine());
                        // 英文成績
                        Console.WriteLine("請輸入英文成績：");
                        english_grade[seat_num] = Convert.ToInt32(Console.ReadLine());
                        // 數學成績
                        Console.WriteLine("請輸入數學成績：");
                        math_grade[seat_num] = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                    
                    case 2:
                    {
                        Console.WriteLine("（若未經過排序動作，則以座號大小排之）");
                        Console.WriteLine("座號\t國文\t英文\t數學\t姓名");
                        Console.WriteLine("====================================");
                        for (int i = 0; i < num_people; i++)
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",i+1 ,chinese_grade[i], english_grade[i], math_grade[i], name[i]);
                        }
                        Console.WriteLine();
                    }
                    break;

                    case 3:
                    {
                        Console.WriteLine("以何種成績做排序？1>國文 2>英文 3>數學");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch(option){
                            case 1:
                            {
                                Array.Copy(chinese_grade,0,tmp,0,num_people);
                                Array.Sort(tmp,name);
                                Array.Clear(tmp,0,num_people);

                                Array.Copy(chinese_grade,0,tmp,0,num_people);
                                Array.Sort(tmp,english_grade);
                                Array.Clear(tmp,0,num_people);

                                Array.Copy(chinese_grade,0,tmp,0,num_people);
                                Array.Sort(tmp,math_grade);
                                Array.Clear(tmp,0,num_people);

                                Array.Sort(chinese_grade);
                            }
                            break;

                            case 2:
                            {
                                Array.Copy(english_grade,0,tmp,0,num_people);
                                Array.Sort(tmp,name);
                                Array.Clear(tmp,0,num_people);

                                Array.Copy(english_grade,0,tmp,0,num_people);
                                Array.Sort(tmp,chinese_grade);
                                Array.Clear(tmp,0,num_people);

                                Array.Copy(english_grade,0,tmp,0,num_people);
                                Array.Sort(tmp,math_grade);
                                Array.Clear(tmp,0,num_people);
                                
                                Array.Sort(english_grade);
                            }
                            break;

                            case 3:
                            {
                                Array.Copy(math_grade,0,tmp,0,num_people);
                                Array.Sort(tmp,name);
                                Array.Clear(tmp,0,num_people);

                                Array.Copy(math_grade,0,tmp,0,num_people);
                                Array.Sort(tmp,english_grade);
                                Array.Clear(tmp,0,num_people);

                                Array.Copy(math_grade,0,tmp,0,num_people);
                                Array.Sort(tmp,chinese_grade);
                                Array.Clear(tmp,0,num_people);
                                
                                Array.Sort(math_grade);                                
                            }
                            break;

                            default:
                                Console.WriteLine("沒有此排序法");
                            break;
                        }
                    }
                    break;

                    case -1:
                        return;
                    break;

                    default:
                        Console.WriteLine();
                        break;
                }
                
            }


        }
    }
}