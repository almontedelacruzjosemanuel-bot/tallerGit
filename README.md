# Proyecto MCD - José Manuel De La Cruz Almonte
- Calentamiento OK - 06/09


# MCD - Máximo Común Divisor

Proyecto desarrollado en **C# con .NET** para calcular el Máximo Común Divisor (MCD) de dos números.

## Descripción

La aplicación recibe dos números enteros y calcula su Máximo Común Divisor utilizando el **algoritmo de Euclides**.

El proyecto también incluye pruebas unitarias realizadas con **xUnit**.

## Tecnologías utilizadas

* C#
* .NET
* ASP.NET Core Web API
* xUnit
* Git / GitHub

## Estructura del proyecto

```text
MCD/
├── Controllers/
│   └── mcdController.cs
├── MCDCalculator.cs
├── Program.cs
├── MCD.csproj
│
└── MCD.test/
    ├── UnitTest1.cs
    └── MCD.test.csproj
```

## Funcionamiento

El cálculo del MCD se realiza mediante el algoritmo de Euclides:

```csharp
public static int CalculateMCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }

    return a;
}
```

Por ejemplo:

```text
MCD(20, 15) = 5
MCD(12, 8) = 4
```
## Ejecutar las pruebas

Para ejecutar las pruebas unitarias:

```bash
dotnet test
```

Las pruebas utilizan **xUnit** para comprobar que el cálculo del MCD devuelve los resultados esperados.

## Endpoint

La API permite calcular el MCD mediante una petición GET:

```text
GET /mcd?a=20&b=15
```

Resultado:

```text
5
```

##  Autor

**José Manuel De La Cruz Almonte**
