   M S B A M L   `   `   `  ����E  AAgenda_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Agenda_WPF
Agenda_WPF  5          Agenda_WPF.customersList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Agenda_WPF     5      -   5          N� Title$  customersList��5	       N� 
Background
 �����.��5
      �� $��Center=�6   $��Center=�6.    �� Orientation$ 
Horizontal=�6I   $��10q�6b   .+�5   
   � $
��Left=�6   $	��Top=�6*   $	��273��6B   $
��auto��6O   
����  � � ColumnDefinitions 5      �� 5      $
��317* �6#   �� 5      $��5* �6#    J� InputBindings 5      d� 5       d� Gesture$ LeftDoubleClicka�6    �� Command 69   �� *	Details+.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ listing��5   3      AutoGenerateColumns .  ���	#FF1138BB	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 Nom��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *
LastName+  5      $
 Prénom��6)    69   �� *	FirstName+  5      $
 Adresse Mail��6)    6?   �� *Mail+  5      $
 Téléphone��6)    6<   �� *PhoneNumber+  5      $
 Budget��6)    69   �� *Budget+  5      $
 Sujet��6)    68   �� *	Subject+5      5      � 5!   
   $��Center=�6   $��Center=�6,   $	��273��6G   $	��225��6T   $��10q�6`   ���	#FF00AEFF 5#      �� 5$      $
��Auto �6#   �� 5%      $	��100 �6#    � RowDefinitions 5(      �� 5)      $
��auto �6    �� 5*      $
��auto �6    �� 5+      $
��auto �6    �� 5,      $
��auto �6    �� 5-      $
��auto �6    �� 5.      $
��auto �6    �� 5/      $
��auto �6    .+�51      �� $��0��6   $��0��6$   $��2q�61   $
��Bold"�6<   .��6N   Nom6S   �� 52      -   5        $��LastName��52      $��1��6&   $��0��66   $��2q�6C    �� TextAlignment$ Center=�6N   �� 54      $��0��6   $��1��6$   $��2q�61   $
��Bold"�6<   .��6N   	Prénom6V   �� 55      -   5        $��	FirstName��55      $��1��6'   $��1��67   $��2q�6D   $ Center=�6O   �� 56      $��0��6   $��2��6$   $��2q�61   $
��Bold"�6<   .��6N   E-Mail6V   �� 57      -   5        $
��Mail��57      $��1��6#   $��2��63   $��2q�6@   $ Center=�6K   �� 58      $��0��6   $��3��6$   $��2q�61   $
��Bold"�6<   .��6N   Téléphone6Y   �� 59      -   5        $��PhoneNumber��59      $��1��6)   $��3��69   $��2q�6F   $ Center=�6Q   �� 5:      $��0��6   $��4��6$   $��2q�61   $
��Bold"�6<   .��6N   Budget6V   �� 5;      -   5        $��Budget��5;      $��1��6$   $��4��64   $��2q�6A   $ Center=�6L   �� 5<      $��0��6   $��5��6$   $��2q�61   $
��Bold"�6<   $��50��6N   .��6Z   Sujet6a   �� 5=      -   5        $��Subject��5=      $��1��6%   $��5��65   $��2q�6B   $ Center=�6M   �� 5>      -	   5        $��0��5>      $��6��6%   $��	Supprimer��62   $��7q�6F   6Q   �� 5?      -
   5        $��1��5?      $��6��6%   $��
Enregister��62   $��7q�6G   6R   5A      5C      5D      