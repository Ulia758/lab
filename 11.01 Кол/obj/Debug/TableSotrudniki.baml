   M S B A M L   `   `   `  ����G  C11.01 Кол, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:_11._01_Кол_11._01_Кол  5      $    _11._01_Кол.TableSotrudniki   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:_11._01_Кол     5        N� Title$  TableSotrudniki��5	      .��5
      � ���	#FFE1E4F9 � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $��Сотрудники��6   $��20(�6&   $��Italic$�64   $��Regular"�6G   $��Center=�6\   $	��Top=�6y   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ SotrudnikiDG��5      $��Stretch=�6)      AutoGenerateColumns .     
IsReadOnly . $��0,30,0,0q�6}   ���	#FFECE8F1   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id сотрудника��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *id_sotrudnika+  5      $ Фамилия��6%    66   �� *	Familia+  5      $ Имя��6%    62   �� *Name+  5      $ Отчество��6%    67   �� *	Otchestvo+  5      $ 
Адрес��6%    64   �� *Adress+  5      $ Дата рождения��6%    6<   �� *
Data_rod+ �� StringFormat$ {0:dd.MM.yyyy}��  5      $ 
Номер��6%    64   �� *Number+4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      �� 
 ��Name$

 Edit��6%   -   5        $��Изменить��5   3   $��5q�6F   $��30��6Q   $	��150��6]   ���	#FFE1E4F9���	#FF9FA0EA6�   5      5      5!      �� 5"   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5#      �� -   5        $
 AddBtn��5#      $��Добавить��6%   $��5q�68   $��30��6C   $	��150��6O   ���	#FFF4F6FF���	#DD000000���	#FF9FA0EA6�   �� 5$      -   5        $
 Delete��5$      $��Удалить��6%   $��5q�67   $��30��6B   $	��150��6N   ���	#FFF4F6FF���	#DD000000���	#FF9FA0EA6�   �� 5%      -   5        $
 Nazad��5%      $��
Назад��6$   $��5q�64   $��30��6?   $	��150��6K   ���	#FFF4F6FF���	#DD000000���	#FF9FA0EA6�   5&      5'      5(      