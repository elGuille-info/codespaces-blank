namespace Equal_Sides_Of_An_Array;

using System;
using System.Linq;

class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        //Code goes here!
        var left = 0;
        //right = arr.reduce(function(pv, cv) { return pv + cv; }, 0);
        var right = arr.Sum();

        for (var i = 0; i < arr.Length; i++)
        {
            if (i > 0)
            {
                left += arr[i - 1];
            }

            right -= arr[i];

            if (left == right)
            {
                return i;
            }
        }
        return -1;
    }
    /*
function findEvenIndex(arr) {
  //Code goes here!

  // Crear subarrays con los elementos de cada grupo y sumar los elementos.
  const cuantos = arr.length;
  const todos = [cuantos];

  if (cuantos == 1) return 0;

  let todos0 = 0;

  for (let index = 0; index < cuantos; index++) {
    let total = 0;
    let total2 = 0;
    for (let j = 0; j < index; j++) {
      total += arr[j];
    }
    for (let j = index; j < cuantos; j++) {
      total2 += arr[j];
    }

    let nums = [2];
    nums[0] = total;
    nums[1] = total2;
    todos[index] = nums;

    todos0 += (total + total2)
  }
  // Si todos los valores suman cero, devolver cero.
  if (todos0 == 0) return 0;

  // Para probar y mostrar los valores.
  console.log(arr);
  for (const iterator of todos) {
    //console.log(iterator);
    console.log(iterator[0] + " / " + iterator[1]);
  }

  // Si todos son iguales, devolver 0

  let iguales = 0;
  let menor = -1;
  // Buscar la posición que tenga todos[0] = todos[1] y todos[1] = todos[0]
  for (let i = 0; i < cuantos; i++) {
    for (let j = i + 1; j < cuantos; j++) {
      if (todos[i][0] == todos[j][1] && todos[i][1] == todos[j][0]) {
        if (i == j - 1) {
          iguales++;
          menor = i;
          break;
        }
      }
      // Esto funciona en este caso: [10,-80,10,10,15,35,20]
      // Es decir, cuando la suma anterior al último número es cero.
      else if (todos[i][0] == todos[j][0] && todos[i][1] == todos[j][1]) {
        if (menor == -1 && j == cuantos - 1) {
          menor = j;
          break;
        }
      }

    }
  }

  if (iguales == cuantos) {
    return 0;
  }

  return menor;
}



    */

    // Para probar
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //var res = FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 });
        pruebaArr(new int[] { 1, 2, 3, 4, 3, 2, 1 }, 3);
        pruebaArr(new int[] { 1, 100, 50, -51, 1, 1 }, 1);
        pruebaArr(new int[] { 1, 2, 3, 4, 5, 6 }, -1);
        pruebaArr(new int[] { 20, 10, 30, 10, 10, 15, 35 }, 3);
        // este debe fallar
        pruebaArr(new int[] { 20, 10, 30, 10, 10, 15, 35 }, 2);

    }

    static void pruebaArr(int[] arr, int resOK)
    {
        Console.WriteLine(arr.ToString() + " = " + resOK);
        var res = FindEvenIndex(arr);
        if (res != resOK)
        {
            Console.WriteLine("\tNo es correcto. El resultado calculado es '" + res + "' debería ser '" + resOK + "'");
        }
        else
        {
            Console.WriteLine("\tCorrecto!");
        }
    }

    /*
using NUnit.Framework;
using System;
[TestFixture]
public class ValidateWordTest
{
  [Test]
  public void GenericTests()
  {
    Assert.AreEqual(3,Kata.FindEvenIndex(new int[] {1,2,3,4,3,2,1}));
    Assert.AreEqual(1,Kata.FindEvenIndex(new int[] {1,100,50,-51,1,1}));
    Assert.AreEqual(-1,Kata.FindEvenIndex(new int[] {1,2,3,4,5,6}));
    Assert.AreEqual(3,Kata.FindEvenIndex(new int[] {20,10,30,10,10,15,35}));
  }
}
    */
}

/*

*/