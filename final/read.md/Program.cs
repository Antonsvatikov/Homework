﻿// Описание решения
// Программа решает задачу фильтрации массива целых чисел по критерию четности.

// На вход подается массив целых чисел посредством ввода с клавиатуры. 
// Кроме ручного ввода, предусмотрен тестовый режим с генерацией случайных чисел.

// При запуске из консоли программа выводит приглашение с описанием работы.

// Предусмотрено несколько команд:

// Команда 1: начать ввод элементов массива
// Команда 2: завершить ввод элементов массива и вывести результат
// Команда 3: очистить массив
// Команда 4: задать параметры генерации массива случайных чисел и вывести результат
// Команда 5: выйти из приложения
// Алгоритм функции фильтрации реализован при помощи промежуточного массива (ведерка), который накапливает четные числа и сливает результат в общий массив. При такой реализации, получается масштабируемый метод по потреблению памяти.
//  Подобное поведение реализовано в стандартных коллекциях.
file:///C:/Users/%D0%90%D0%BD%D1%82%D0%BE%D0%BD/Desktop/algorithm-schema.svg
![Схема алгоритма основной функции](algorithm-schema.drawio.svg "Схема алгоритма").