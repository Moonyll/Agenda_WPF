   M S B A M L   `   `   `  ����E  AAgenda_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Agenda_WPF
Agenda_WPF  5      !    Agenda_WPF.appointmentsList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Agenda_WPF     5      -   5          N� Title$  appointmentsList��5	      .��5
      �� $��Center=�6   $��Center=�6.    �� Orientation$ 
Horizontal=�6I   $��10q�6b   .+�5   
   � $
��Left=�6   $	��Top=�6*   $	��273��6B   $
��auto��6O   
����  � � ColumnDefinitions 5      �� 5      $
��317* �6#   �� 5      $��5* �6#    J� InputBindings 5      d� 5       d� Gesture$ LeftDoubleClicka�6    �� Command 69   �� *	Details+.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ listing_app��5   3      AutoGenerateColumns .  ���	#FF1138BB   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Courtier��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *Broker.LastName+  5      $	 Client��6)   
 69   �� *Customer.LastName+  5      $	 Date du Rdv��6)   
 6>   �� *
DateHour+  5      $	 Sujet du Rdv��6)   
 6?   �� *Customer.Subject+  5      $	 id_app��6)      
Visibility$ Hidden=�6[   
 69   �� *idAppointment+6[     5      $	 id_brok��6)   $ Hidden=�6^   
 6:   �� *Broker.idBroker+6^     5      $	 id_cust��6)   $ Hidden=�6b   
 6:   �� *Customer.idCustomer+6b   5!      5"      � 5$   
   $��Center=�6   $��Center=�6,   $	��273��6G   $	��225��6T   $��10q�6`   ���	#FF00AEFF 5&      �� 5'      $
��Auto �6#   �� 5(      $	��100 �6#    � RowDefinitions 5+      �� 5,      $
��auto �6    �� 5-      $
��auto �6    �� 5.      $
��auto �6    �� 5/      $
��auto �6    �� 50      $
��auto �6    �� 51      $
��auto �6    �� 52      $
��auto �6    .+�54      �� $��0��6   $��0��6$   $��2q�61   $
��Bold"�6<   .��6N   
Courtier6X   �� 55      -   5        $��
App_Broker��55      $��1��6(   $��0��68   $��2q�6E    �� TextAlignment$ Center=�6P   ��6g   ��  �� ElementName$ listing_app�� �� Path$" SelectedItem.Broker.LastName� �� Mode$ TwoWay=��� 57      $��0��6   $��1��6$   $��2q�61   $
��Bold"�6<   .��6N   Client6V   �� 58      -   5        $��App_Customer��58      $��1��6*   $��1��6:   $��2q�6G   $ Center=�6R   ��6i   �� $ listing_app��$$ SelectedItem.Customer.LastName�$ TwoWay=��� 5:      $��0��6   $��2��6$   $��2q�61   $
��Bold"�6<   .��6N   Date du Rdv6[   (  "System.Windows.Controls.DatePicker  5;      -   5        $��App_Date��5;      $��1��6*   $��2��6:   $��2q�6G   �� 5<      $��Center=�6   $��0��61   $��3��6A   $��Center=�6N   .��6i   Heure6p   �� 5=      -   5        $��App_Hour��5=      $��1��6&   $��3��66   $��Center=�6j   $��Center=�6�   $��50��6�   ��6C   �� *Date+ �� StringFormat$ hh��6�   �� 5>      $��Center=�6   $��0��62   $��5��6B   $��Center=�6O   .��6j   	Minutes6s   �� 5?      -   5        $��App_Minutes��5?      $��1��6)   $��5��69   $��Center=�6m   $��Center=�6�   $��50��6�   ��6F   �� *Date+$ mm��6�   �� 5D      -   5        $��App_id��5D      $��1��6%   $��5��65   $��2q�6B   $ Center=�6M   $y�Hidden=�6�   ��6d   �� $ listing_app��$  SelectedItem.idAppointment�$ TwoWay=�6�   �� 5E      -	   5        $��
App_idBrok��5E      $��1��6)   $��6��69   $��2q�6F   $ Center=�6Q   $y�Hidden=�6�   ��6h   �� $ listing_app��$ SelectedItem.idBroker�$ TwoWay=�6�   �� 5F      -
   5        $��
App_idCust��5F      $��1��6)   $��7��69   $��2q�6F   $ Center=�6Q   $y�Hidden=�6�   ��6h   �� $ listing_app��$ SelectedItem.idCustomer�$ TwoWay=�6�   �� 5G      -   5        $��0��5G      $��9��6%   $��	Supprimer��62   $��10,47,4,-33q�6F   6[   �� 5H      -   5        $��1��5H      $��9��6%   $��Mis à jour��62   $��10,47,4,-33q�6G   6\   5I      5L      5M      