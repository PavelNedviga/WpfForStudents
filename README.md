# WPF + MVVM

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

![1745073475837](image/README/1745073475837.png)

## Интерфейсы

INotifyPropertyChanged - Уведомление окна об изменении свойства в ViewModel

ICommand - Управление обработкой команд из интерфейса
