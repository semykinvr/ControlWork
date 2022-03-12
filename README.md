ControlWork


# Итоговая проверочная работа

## 1. Создан репозиторий на GitHub:
https://github.com/semykinvr/ControlWork.git

## 2. Нарисована блок-схема алгоритма (основной содержательной части, отдельный метод): 
! [Имя изображения] (https://disk.yandex.ru/i/icvkfRwhB-1eGg)

## 3. Репозиторий снабжён оформленным текстовым описанием решения (данный файл README.md)

## 4. Написана программа, решающая поставленную задачу. 
Код: 

```C#
// функция преобразования из одного массива в другой массив
string[] NewArray(string[] array)
{
    string[] newArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = array[i];
        }
    }
    return newArray;
}  
```  

Результат работы программы:
! [Скриншот] (https://disk.yandex.ru/i/Vmb7IXDDiRFXCA)


## 5. Использован контроль версий в работе над этим проектом (залито несколькими коммитами, в том числе этапы 2, 3 и 4 расположены в разных коммитах)


