   M S B A M L   `   `   `  ����D  @MVVMLearn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMLearn.ViewsMVVMLearn.Views  5   	        MVVMLearn.Views.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   )localclr-namespace:MVVMLearn.Views  5   	     � Title$  Телефончики��5	   	   $	��450��6   $	��800��6*    � 	Resources 5
       �� 
TargetType �� Property �� Value��%  '��       '�� H     '�� �     �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 40��6&   �� 5       � ��$ 5q�6'   5      5      .��5      � .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��0.2* �6#   �� 5      $��* �6#   �� 5      $
��0.2* �6#    � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��0.2* �6    .+�5#      &   System.Windows.Controls.DataGrid  -   5        $��mainDataGridView��5$   )   $��1��5#         AutoGenerateColumns$ False��6'   $��0 10 0 0q�5$      $��16(�5%         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6%   	   CanUserAddRows$	 False��5&      
   
IsReadOnly$

 True��6.    5'      )  #System.Windows.Controls.DataGridRow��%E   '        �� 5(      "  6   .�5)      -   5        5*      5+       � ContextMenu 5,      �� 5-      .@�5.      m� -   5        $��Подробнее��5.   #   66   m� 5/      -   5        $ ��Редактировать��5/   #   6:   m� 50      -   5        $��Удалить��50   #   64   51         Columns 53      4  .System.Windows.Controls.DataGridTemplateColumn  54      ,  &System.Windows.Controls.DataGridColumn   Width$
 0.5* 6-      CellTemplate 55      �� 56      .R�57   "   ��  �� Orientation$ 
Horizontal=�6-   .+�58   &   �� -   5        $��25��58   -   $��25��69   
������ $��0q�5:   )   .��5<   *   �� $��20��60   $��../Images/edit-button.png��5=   ,   5>   '   �� 5?   &   -   5        $��25��5?   -   $��25��69   
������ $��0q�5A   )   .��5C   *   �� $��../Images/remove.png��60   5D   '   5E   #   5F      5H      0  *System.Windows.Controls.DataGridTextColumn  5I         Header$ Название��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5J   %   ��  �� Path$ Title�  5K      $ Компания��6)    5L   %   �� $ CompanyEntity.Title�  5M      $ Цена��6)    67   �� $ Price�5O      �� 5Q      $��1��6   $��1��6&   $ 
Horizontal=�66   .+�5R      �� -   5         ��Name$ addButtonView��5R      
������ $��0q�5T      .��5U      �� $��../Images/plus.png��6   5V      5W      5X       � 5Y   
   -	   5        $��	mainFrame��5Y        � NavigationUIVisibility$ Hidden=�6!   5Z      5[      