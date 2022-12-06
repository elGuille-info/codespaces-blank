//
// 18- Gap in Primes
//

/*
    El código en JavaScript

function gap(g, m, n) {
    // your code

    // Validar los parámetros
    if (g < 2 || m < 3 || n < m) {
        return null;
    }

    let primeAnt = -1;
    for (let i = m; i <= n; i++) {
        // Si es primo, comprobar si hay la diferencia indicada con el primo anterior
        if (isPrime(i)) {
            // Solo comprobarlo si se encontró un primo anterior
            if (primeAnt > -1 && i - primeAnt == g) {
                return [primeAnt, i];
            }
            // El último primo hallado antes de encontrar la solución
            primeAnt = i;
        }
    }
    // Si llega aquí es que no se ha encontrado nada
    return null;

    // Función para comprobar si un número es primo
    function isPrime(num) {
        for (let i = 2; i <= Math.sqrt(num); i++) {
            if (num % i == 0) {
                return false;
            }
        }
        return true;
    }
}


*/
using System;

namespace Gap_in_Primes;

partial class GapInPrimes
{
    public static long[] Gap(int g, long m, long n)
    {
        // your code

        // Validar los parámetros
        if (g < 2 || m < 3 || n < m)
        {
            return null;
        }

        long primeAnt = -1;
        for (var i = m; i <= n; i++)
        {
            // Si es primo, comprobar si hay la diferencia indicada con el primo anterior
            if (IsPrime(i))
            {
                // Solo comprobarlo si se encontró un primo anterior
                if (primeAnt > -1 && i - primeAnt == g)
                {
                    return new long[] { primeAnt, i };
                }
                // El último primo hallado antes de encontrar la solución
                primeAnt = i;
            }
        }
        // Si llega aquí es que no se ha encontrado nada
        return null;
    }
    static bool IsPrime(long num)
    {
        for (var i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
partial class GapInPrimes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gap in Primes");

        comprobar3(3, 2, 6, null);
        comprobar3(3, 3, 4, null);
        comprobar3(2, 2, 6, null);
        comprobar3(3, 5, 6, null);
        comprobar3(4, 6, 11, new long[] { 7, 11 });
        comprobar3(4, 7, 11, new long[] { 7, 11 });
        comprobar3(1, 3, 500, null);
        comprobar3(1, 3, 50, null);
        comprobar3(2, 3, 50, new long[] { 3, 5 });
        comprobar3(2, 100, 110, new long[] { 101, 103 });
        comprobar3(4, 100, 110, new long[] { 103, 107 });
        comprobar3(6, 100, 110, null);
        comprobar3(2, 100, 110, new long[] { 101, 103 });
        comprobar3(3, 100, 110, null);
        comprobar3(8, 300, 400, new long[] { 359, 367 });
        comprobar3(10, 300, 400, new long[] { 337, 347 });
    }
    static void comprobar3(int valor1, long valor2, long valor3, long[] resOK)
    {
        Console.WriteLine(valor1 + ", " + valor2 + ", " + valor3 + " = " + resOK);
        var res = GapInPrimes.Gap(valor1, valor2, valor3);
        if (res != resOK)
        {
            Console.WriteLine("\tNo es correcto. El resultado calculado es '" + res + "' debería ser '" + resOK + "'");
        }
        else
        {
            Console.WriteLine("\tCorrecto!");
        }
    }
}

/*
function comprobar3(valor1, valor2, valor3, resOK) {
  console.log(valor1 + ", " + valor2 + ", " + valor3 + " = " + resOK);

  let res = laFuncion(valor1, valor2, valor3);
  if (res?.toString() != resOK?.toString()) {
    console.log("\tNo es correcto. El resultado calculado es '" + res + "' debería ser '" + resOK + "'");
  }
  else {
    console.log("\tCorrecto!");
  }
}

*/

/*
using System;
using NUnit.Framework;

[TestFixture]
public static class GapInPrimesTests {

[Test]
    public static void test1() {
        Assert.AreEqual(new long[] {101, 103}, GapInPrimes.Gap(2,100,110));
        Assert.AreEqual(new long[] {103, 107}, GapInPrimes.Gap(4,100,110));
        Assert.AreEqual(new long[] {101, 103}, GapInPrimes.Gap(2,100,103));
        Assert.AreEqual(null, GapInPrimes.Gap(6,100,110));
        Assert.AreEqual(new long[] {359, 367}, GapInPrimes.Gap(8,300,400));
        Assert.AreEqual(new long[] {337, 347}, GapInPrimes.Gap(10,300,400));
    }
}
*/