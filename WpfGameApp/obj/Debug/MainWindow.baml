   M S B A M L   `   `   `  ����E  AWpfGameApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfGameApp
WpfGameApp  5   	       WpfGameApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfGameApp     5   	   -   5          � Title$$  Построй свой ЦОД��5   	   $	��450��6"   $	��800��6/    � WindowStartupLocation$ CenterScreen=�6;    � WindowState$ 	Maximized=�6`   .��5	      ]� ��. .+�5
   
   o� $	��Top=�6   .@�5      m� $��Игра��6   .@�5      m� $��
Новая��6   6,   m� 5      -   5         m�Name$
 load��5      $��Загрузить...��6)   6T   m� 5      -   5        $
 save��5      $��Сохранить...��6)   6T   m� 5      -   5        $��
Выход��5      6D   5      m� 5      $��Соревнование��6   .@�5      m� -   5        $��
Старт��5      6@   m� 5      -   5        $��Стоп��5      6>   5      5      �� 5   
   -   5         ��Name$ canvas��5      $
��Left=�6!   .+�5      �� -   5         ��Name$
 rack��5      $	��750��6&    �� Left$ 10��63   
 �� Top$ 10��6D   $	��280��6T   
���   �
�������6o   �� 5      -	   5         ��Name$ price��5      $	 660��6'   $
��Wrap=�69   $��-��6M   $ 50��6V   �� 5      -
   5        $ capacity��5      $	 660��6*   $
��Wrap=�6<   $��-��6P   $	 100��6Y   ��5      �� 5      	 �� 
TargetType"	 ��6   
 �� Triggers
 5      5      5       &   System.Windows.Controls.DataGrid  5!      -   5          Name$
 calc��5!   ;   $
 1000��6   $	 500��6*      
IsReadOnly .    SelectionMode$ Single=�5#         AutoGenerateColumns .     Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Name+6B     5'         Header$ Масса, кг��6D    .  6)   �� *Weight+6W     5(      $ Стоимость��6C    .  6)   �� *Price+6V     5)      $	 CPU��6A    .  6)   �� *CPU+6N     5*      $	 HDD��6A    .  6)   �� *HDD+6N     5+      $ Сеть��6E    .  6)   �� *	Network+6S     5,      $	 KVM��6A    .  6)   �� *KVM+6N   5.      57      58      5:      