using System;

namespace HelloWorldDemoService
{
    class HelloWorldService: IHelloWorldService
    {
        public string SayHelloWorld()
        {
            var dt = DateTime.Now.ToString();
            Console.WriteLine("Was asked for 'hello world' at {0}", dt);
            return string.Format("Hello, World! Current date/time is {0}", dt);
        }
    }
}
