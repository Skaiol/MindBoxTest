# MindBoxTest
#### Задание 1

Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры
- Проверку на то, является ли треугольник прямоугольным

#### Задание 2

В базе данных MS SQL Server есть статьи и тэги. Одной статье может соответствовать много тэгов, а тэгу — много статей. 
Напишите SQL запрос для выбора всех пар «Тема статьи – тэг». Если у статьи нет тэгов, то её тема всё равно должна выводиться.

#### Пояснения к решению

- Легкость добавления других фигур: реализуем интерфейс `IFigure` и вуаля
- Вычисление площади фигуры без знания типа фигуры: вызываем метод вычисления площади через интерфейс `IFigure` и вуаля
- Решение по заданию 2 в корне проекта в task2.sql