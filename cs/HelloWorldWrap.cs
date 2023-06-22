using System.Runtime.InteropServices;

public class HelloWorldWrap 
{
    [DllImport("../cpp/hello-world.so", EntryPoint=@"_ZN10HelloWorld9GetAnswerEv")]
    public static extern int GetAnswer();
}