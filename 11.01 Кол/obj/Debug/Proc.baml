   M S B A M L   `   `   `  ����G  C11.01 Кол, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:_11._01_Кол_11._01_Кол  5          _11._01_Кол.Proc   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:_11._01_Кол     5        N� Title$
  Proc��5	      .��5
      �� ���	#FFE1E4F9.@�5      �� ��5   
   �� 5       �� Orientation$ 
Horizontal=�6   $	��806��66   .+�5      �� $��3q�6    OMМаксимальный оклад указанного сотрудника6V   5      ��5   
   �� 5      .+�5      �� $.��(Выберите id сотрудника��6   $��15(�6:   $��Regular"�6H   $
��Left=�6]   $��Center=�6x   $��1q�6�   �� 5      .+�5      �� -   5         ��Name$
 sotr��5       �� 
IsReadOnly . .@�5      �� .��6+   Носкова64   �� 5      .��6+   Павловский67   �� 5      .��6+   Орлова63   �� 5      .��6+   Третьяков66   �� 5      .��6+   Соловьёв65   �� 5      .��6+   Мещерин64   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ MaxOkl��5         AutoGenerateColumns .  $��10q�6K      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��65   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6F   �� *Sotrudniki.Familia+  5    "   $ Имя��65   	 6B   �� *Sotrudniki.Name+  5!   "   $ Отчество��65   	 6G   �� *Sotrudniki.Otchestvo+  5"   "   $) #Максимальный оклад��65   	 6Q   �� *	MaxOplata+5$      �� 5%      $ 
Horizontal=�6!   $��1��6:   .+�5&      �� -   5        
 ��Name$

 Find��5&   !   $��
Найти��6/   $��5q�6?   $��30��6J   $	��150��6V   ���	#FFF4F6FF���	#DD000000���	#FF9FA0EA6�   �� 5'      -   5        $

 Back��5'   !   $��
Назад��6/   $��5q�6?   $��30��6J   $	��150��6V   ���	#FFF4F6FF���	#DD000000���	#FF9FA0EA6�   5(      5)      5*      5,      5-      5.      