   M S B A M L   `   `   `  ����F  BMoziProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MozijegyvetelMozijegyvetel  5   	   ?$clr-namespace:MoziProjekt.ViewModelsMoziProjekt.ViewModels  5   	       Mozijegyvetel.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Mozijegyvetel     5   	   :	viewmodel$clr-namespace:MoziProjekt.ViewModels     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f46xwpftk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � DataContext 5      /   )MoziProjekt.ViewModels.JegyVetelViewModel  5   
   .��5      � $��5 5 5 5q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   6.   �� 5      $	��300 �6   6-    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��2��6   $��Center=�61   .��6N   Diák adatok6[   �� 5   
   $��1��6   $��0��6   .��6-   Teljes név:6:   �� 5   
   $��2��6   $��0��6   .��6-   Film dátuma:6;   �� 5   
   $��3��6   $��0��6   .��6-   
Film név:68   �� 5    
   $��4��6   $��0��6   .��6-   Jegy Típusa:6;   �� 5!   
    �� Orientation$ 
Horizontal=�6   $��5��6.   $��2��6;   .+�5"      �� $��0 10 2 2q�6   $��Right=�6(   $��80��6D   $��Új adat��6R   ��5#      �� *DoNewJegyCommand+�� 5%      $��0 10 2 2q�6   $��Right=�6(   $��80��6D   $��Mentés��6R   ��5&      �� *DoSaveCommand+��5'      �� *SelectedJegy+�� 5)      $��0 10 2 2q�6   $��Right=�6'   $��80��6C   $��Törlés��6Q   ��5*      �� *DoRemoveCommand+��5+      �� *SelectedJegy+5-      �� 5.   
   $��1��6   $��1��6   $��2 2 2 2q�6/   $	��0 2q�6@   ��6N   �� *SelectedJegy.TeljesNev+6x   (  "System.Windows.Controls.DatePicker  5/   
   $��2��6   $��1��6"   $��2 2 2 2q�62      SelectedDate 6C   �� *SelectedJegy.Filmdatuma+6v   �� 50   
   $��3��6   $��1��6    $��2 2 2 2q�60    �� SelectedIndex$ 0��53      ��51      �� *	FilmNev+ �� SelectedItem 52      �� *KivalasztottFilm+54      �� 55   
   $��4��6   $��1��6"   .+�56      	�  	� 	GroupName$ 
jegytipusa��6   $��2 4 2 2q�61   	 d� 	IsChecked	 6B   �� *Jegyvetel.DIAK+.��6g   Diák6m   	� 57      $ 
jegytipusa��6   $��2 4 2 2q�61   	 6B   �� *Jegyvetel.FELNOTT+.��6j   
Felnőtt6s   	� 58      $ 
jegytipusa��6   $��2 4 2 2q�61   	 6B   �� *Jegyvetel.NYUGDIJAS+.��6l   
Nyugdíjas6w   59      �� 5:   
   $��8��6   $��2��5;      $��2 2 2 2q�5<      ��5=      �� *Jegyvetelek+ 5>      �� *SelectedJegy+5@      5A      