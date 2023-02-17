using System;

namespace A
{
	class myclass1
	{
		public void function1()
		{
			Console.WriteLine(" A namespace - myclass1 -- function1()");
		}
	}
}

namespace B
{
	class myclass2
	{
		public void function2()
		{
			Console.WriteLine(" B namespace - myclass2 -- function2()");
		}
	}
}

namespace C
{
	class myclass3
	{
		public void function3()
		{
			Console.WriteLine(" C namespace - myclass3 -- function3()");
		}
	}
}

class india
{
	static void Main(string[] args)
	{
		A.myclass1 obj1 = new A.myclass1();
		obj1.function1();
		B.myclass2 obj2 = new B.myclass2();
		obj2.function2();
		C.myclass3 obj3 = new C.myclass3();
		obj3.function3();
	}
}
	

