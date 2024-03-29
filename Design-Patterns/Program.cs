﻿using Design_Patterns.Behavioral.Observer;
using Design_Patterns.Behavioral.TemplateMethod;
using Design_Patterns.Behavioral.Visitor;
using Design_Patterns.Structural.Adapter;
using Design_Patterns.Structural.Decorator;
using System;

namespace Design_Patterns
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello Design-Patterns!");

			var observerDemo = new ObserverDemo();
			observerDemo.Run();

			var templatedMethodDemo = new TemplateMethodDemo();
			templatedMethodDemo.Run();

			var decoratorDemo = new DecoratorDemo();
			decoratorDemo.Run();

			#region Visitor Structural Demo and Real World Demo

			var visitorStructuralDemo = new VisitorStructuralDemo();
			visitorStructuralDemo.Run();

			var visitorRealWorldDemo = new VisitorRealWordDemo();
			visitorRealWorldDemo.Run();

			#endregion Visitor Structural Demo and Real Word Demo

			#region Adapter
			var adapterStructuralDemo = new AdapterStructuralDemo();
			adapterStructuralDemo.Run();

			var adapterRealWorldDemo = new AdapterRealWordDemo();
			adapterRealWorldDemo.Run();
			#endregion Adapter

			Console.ReadLine();
		}
	}
}
