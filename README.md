# QuadraticEquationsRootsAPI

## General 

Привет! Посмотри пожалуйста дз, разберем на занятии)

Я попробовал отделить логику от контроллеров и еще по тестам пару видео посмотрел, поэтому и их сверху запилил

### Equation.cs

Обрати внимание как я через одну функцию вывожу ответы, это норм? Просто я не хотел писать 3 функции для каждого случая.(Хотя мб надо было, тогда не было бы проблем с ексепшеном)


##### Exception
Думаю, не правильно здесь вызывать експешн, потому что, при таком запросе через апи, падает все приложение, и это не хорошо

```csharp
    case <0:
      throw new Exception("No roots!");
```

<img width="843" alt="Screenshot 2023-02-14 at 11 57 12" src="https://user-images.githubusercontent.com/83907630/219340711-7e40b391-d56e-4c2d-96a3-98b9070f8a01.png">

### EquationController.cs

3 запроса: 2 GET с параметрами и 1 POST через тело(понял как отправлять параметры в Postman только через json). Они все создают объект уравнения и возвращают корни.

### Тесты

Столкнулся с проблемой, у Assert.AreEqual нет перегрузки double[] double[] delta. Поэтому пришлось извращаться. Могу ли я extentionи расширить ее?

#### И еще void NoRootsTest1 - работает не правильно

```csharp
    public void NoRootsTest1()
    {
        var equation = new Equation(1,12,36);
        
        // Эта штука  не работает, он всегда показывает Succes;
        try
        {
            equation.SolveRoots();
            Assert.Fail();
        }
        catch (Exception e)
        {
            Assert.Pass();
        }
        // Я пытался сделать так, но что то пошло не так :(
        // Assert.Throws<System.Exception>(
        //     equation.SolveRoots() => throw new Exception());
    }
```
