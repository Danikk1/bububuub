   M S B A M L   `   `   `  ����B  >Laba5.2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Laba5._2Laba5._2  5          Laba5._2.avtorizaciay   5      c _MaterialDesignThemes.MahApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Laba5._2     5        N� Title$  avtorizaciay��5
      .��5      � .+�5   
   �  � 	Resources 5       �� 
TargetType   CustomButtonStyle �� Property �� Value��%�   &	        �� 5      " ��6   .�5      ��  � ��
 �� ��63   �� 5       � ��
 �����63   �� 5       � ��$ 5q�6/   5      5      .+�5      � 
������� � ColumnDefinitions 5      �� 5      $��6* �6'   �� 5      $��4* �6'   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ EmployeesTbx��5      $��0��61      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6-   �� *
Account_ID+6L     5      $	 Login��6J   
 6-   �� *
Username+6J     5       $	 Password��6J   
 6-   �� *
Password+6J     5!      $	 ID��6O   
 6-   �� *Roles.Role_ID+6O   5#      � 5$      $��1��6    � RowDefinitions 5%      �� 5&      �� 5'      �� 5(      $��311.538 �6(   �� 5)      �� 5*      .+�5,      � $��2��6   $��
0,247,0,30q�6(    5-      �� 5.      $��4* �6/   �� 5/      $��4* �6/   �� 50      $��4* �6/   .+�52      �� -   5        $��0��52   !   #��[  61   $��Добавить��6\   $��25��6�   $��5,0,5,5q�6�   $��Bottom=�6�   �� 53      -   5        $��1��53   !   #��[  61   $��Изменить��6\   $��5,5,5,0q�6�   $��25��6�   $	��Top=�6�   �� 54      -   5        $��2��54   !   #��[  61   $��Удалить��6\   6n   55      �� 56      $��Center=�6    $��1��6=   *(Данные для заполнения6b   �� 57      -   5         ��Name$ UsernameDbx��57      $��2��63   
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��6Y   $��
0,17,0,266q�6�   G� 58      -   5         G�Name$ PasswordDbx��58   "   $��2��67   
�������$ Пароль��6]   $��
0,46,0,237q�6�   �� 59      -   5         ��Name$ EmployeeDbx��59      $��2��64   
�������$] WПользователь, к которуму привязать авторизацию��6Z   $��
0,65,0,214q�6�    �� DisplayMemberPath$ 	Role_Name��6�   5;      5<      5=      5>      5?      