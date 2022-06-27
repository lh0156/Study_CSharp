using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Using은 Import와 같다고 생각해도 될 것 같다.
 */

/*
    nameSpace는 어떤 보따리를 만드는 것
    HelloCSharp안에 program이라는 클래스를 포함하고
    Window OS가 이 HelloCSharp이라는 보따리를 쓴다.
 */
namespace HelloCSharp
{
    class Program
    {

        /*
            운영체제는 오로지 Main함수만을 호출할 수 밖에 없다.
            Main(string[] args)은 함수의 프로토 타입이라고 함.
            string[] args는 인자인데, 메인이라는 값이 무언가를 하기 위해서는 어떤값을 받아야함.
            마치 김밥을 만들기 위해서는 김과 밥 단무지 등이 있어야 하는것과 같음.

            이 배열은 args라는 이름을 가진 배열의 형태로 들어옴.
            args안에는 여러개의 기능들이 들어가있다.
         */
        static void Main(string[] args)
        {
            /*
                윈도우 운영체제가 Main으로 와서 콘솔을 찍는데
                충분히 볼 수 있을만큼 시간이 없어서 안보였을 뿐임. 그래서 무언가를 추가해보자
                Console.Key
             */
            Console.WriteLine("Hello C#");

            /*
                그럼 어떤 키 입력을 받기 이전까지는 
                Write한 값들이 계속 남아있는것을 알 수 있다.
             */

            Console.WriteLine(args.Length);
            Console.WriteLine(args[0] + "은 첫번째 인덱스 값이고");
            Console.WriteLine(args[1] + "은 두번째 인덱스 값이다");



            Console.ReadKey();



        }//main
    }//class
}//nameSpace
