namespace Unique_In_Order;

using System;

using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        //your code here...
        var unicos = new List<T>();
        object digitoAnt = null;
        var iterable2 = iterable.ToList();

        for (var i = 0; i < iterable2.Count; i++)
        {
            // El carácter que estamos analizando
            var digito = iterable2[i];
            // Si no es igual al hallado anteriormente, añadirlo a la colección
            if (digito.Equals(digitoAnt) == false)
            {
                unicos.Add(digito);
                digitoAnt = digito;
                continue;
            }
        }

        return unicos;

        //return "";
    }

    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        deepEqual("AAAABBBCCDAABBB", "ABCDAB");
        deepEqual("ABBCcAD", "ABCcAD");
        deepEqual(new int[] { 1, 2, 2, 3, 3 }, new int[] { 1, 2, 3 });
        deepEqual("1", "1");
        deepEqual("", "");

    }

    static void deepEqual<T>(IEnumerable<T> iterable, IEnumerable<T> resOK)
    {
        Console.WriteLine(iterable + " = " + resOK);

        var res = UniqueInOrder(iterable);
        if (res.ToString() != resOK.ToString())
        {
            Console.WriteLine("\tNo es correcto. El resultado calculado es " + res + " debería ser " + resOK);
        }
        else
        {
            Console.WriteLine("\tEs correcto.");
        }

    }
}

/*
namespace Solution
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void EmptyTest()
    {
      Assert.AreEqual("", Kata.UniqueInOrder(""));
    }
    [Test]
    public void Test1()
    {
      Assert.AreEqual("ABCDAB", Kata.UniqueInOrder("AAAABBBCCDAABBB"));
    }
  }
}
*/

/*
function uniqueInOrder(iterable){
    //your code here - remember iterable can be a string or an array

    //return A.find(item => A.filter(el => el == item).length % 2)
    //return iterable.find(item => iterable.filter(it2 => it2 == item));

    //return [].filter.call(iterable, (function (a, i) { return iterable[i - 1] !== a }));

    // Array con los números y/o letras hallados
    let unicos = [];
    let digitoAnt = "";

    for (let i = 0; i < iterable.length; i++) {
      // El carácter que estamos analizando
      let digito = iterable[i];
      // Si no es igual al hallado anteriormente, añadirlo a la colección
      if (digito != digitoAnt) {
        unicos.push(digito);
        digitoAnt = digito;
        continue;
      }
    }

    return unicos;
}


function deepEqual(iterable, resOK ) {
    console.log(iterable + " = " + resOK);

    let res = uniqueInOrder(iterable);
    if (res.toString() != resOK.toString()) {
        console.log("\tNo es correcto. El resultado calculado es " + res + " debería ser " + resOK);
    }
}

// Para probar
deepEqual('AAAABBBCCDAABBB', ['A','B','C','D','A','B']);
deepEqual('ABBCcAD', ['A', 'B', 'C', 'c', 'A', 'D']);
deepEqual([1,2,2,3,3], [1,2,3]);
deepEqual([1], [1]);
*/