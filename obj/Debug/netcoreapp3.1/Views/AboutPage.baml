   M S B A M L   `   `   `  ����D  @MVVMLearn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMLearn.ViewsMVVMLearn.Views  5          MVVMLearn.Views.AboutPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMLearn.Views     5        N� Title$  Подробнее��5	       N� 
Background
 ����� � 	Resources 5
       �� 
TargetType �� Property �� Value   RoundButton �� CornerRadius��%G  '��       &	  u     �� 5   
   " ��6   .�5      ��  � ��$ 20(�6)   �� 5       � ��$ 20 10 0 100q�6'   5      �� 5   
   .R�5      �� $ 25��6   
���   �$��2q�5      $��50��6)   $��50��68   $	��Top=�5      ._�5      �� $��../Images/backArrow.png��6   5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $��* �6   �� 5      $
��0.3* �6   .+�5   
   �� -   5        #��[  5      5      � 5!   
   $��1��6    5"      �� 5#      �� 5$       � RowDefinitions 5&      �� 5'      $��2* �6    �� 5(      $��* �6    .+�5*      �� -   5        $��imagePageView��5*      �� 5+      $��1��6   .+�5,      �� -   5        	 ��Name$	 titlePageView��5,      �� 5-      -   5        $	 companyPageView��5-      �� 5.      -   5        $	 pricePageView��5.      5/      �� 50      -   5        $	 definitionPageView��50      $��1��64   $��2��6A   $
��Wrap=�51      52      53      54      