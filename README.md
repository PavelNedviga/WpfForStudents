# WPF + MVVM

## Посмотреть

[Хорошие и короткие видеоуроки](https://www.youtube.com/playlist?list=PLeAZCOMG14bGlFQSTmXz7aSbC90md5oJe)

## Почему WPF?

декларативный UI, аппаратное ускорение, XAML + C# раздельно

Синтаксис: HTML подобный. 

Адаптивная верстка = все свободное место

```XAML
<Window x:Class="WpfForStudents.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfForStudents"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>

    </Grid>
</Window>
```



Есть разные типы объектов:

* Контейнеры (сетки, stack panel...)
  * Grid
    * Хороший подход Grid in Grid
    * Row=137* (адаптивность)
  * UniformGrid (равномерная))
* Инструменты представления
* Инструменты управления

---








## Стили

[MahApps ](https://mahapps.com/docs/guides/quick-start)


## Взаимодействие между элементами интерфейса

Привязка к свойствам и триггеры






## Схема работы паттерна

![image](https://github.com/user-attachments/assets/422e74b0-5d74-46c8-862b-7c0a64a8ee82)


## Интерфейсы

INotifyPropertyChanged - Уведомление окна об изменении свойства в ViewModel

ICommand - Управление обработкой команд из интерфейса
