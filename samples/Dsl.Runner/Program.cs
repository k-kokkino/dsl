// See https://aka.ms/new-console-template for more information
using System.Text;

using Dsl.Core;

using kkokkino.Dsl.Core.LdapValues;

LdapIntValue foo = 420;

LdapIntValue bar = 69;

Console.WriteLine(foo);

var y = foo + bar;

Console.WriteLine(y);

var z = y + 32;

Console.WriteLine(z);

Console.WriteLine(z.Compile());

Console.WriteLine(z.Optimize().Compile());

var sb = new StringBuilder();
