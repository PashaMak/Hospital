   M S B A M L   `   `   `  ����C  ?Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Hospital.ViewModelHospital.ViewModel  5   	   "    Hospital.Windows.ListPatient   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6	ViewModel clr-namespace:Hospital.ViewModel     5   	     � Title$  ListPatient��5   	   $	��300��6   $	��365��6*    � 	Resources 5         TemplateItem � ColumnDefinitions � RowDefinitions �� Mode��%�  &	        �� 5
   
   .R�5      �  5      �� 5      $��* �6'   �� 5      $��50 �6'   �� 5      $��* �6'   �� 5      $��1 �6'    5      �� 5      .+�5      �� $��Center=�5      $
��Left=�5      $
��Wrap=�5      $��0��5      $��0��6   ��5      �� *fio+$ TwoWay=�5      �� 5      $��Center=�5      $
��Left=�5      $
��Wrap=�5      $��2��5      $��0��6   ��5      �� *phoneNumber+$ TwoWay=�5      �� 5      $��Center=�5       $
��Left=�5!      $��3��5"      $��0��6   $y�	Collapsed=�6)   ��5      �� *id+$ TwoWay=�5"   )   5#      5$      5%       � DataContext 5(      )   #Hospital.ViewModel.PatientViewModel  5)   
   .��5-      � .+�5.   
   �� -   5         ��Name$ ListBoxView��5.      #��[  6'   $
��Left=�6T   $	��220��6o   $��	10,10,0,0q�6|   $	��Top=�6�   $	��337��6�   �� 5/   
   -   5         ��Name$ ButtonClose��5/      $��Закрыть��6&   $
��Left=�68   $��24��6S   $��
13,235,0,0q�6_   $	��Top=�6s   $��79��6�   6�   �� 50   
   -   5        $ ButtonDelete��50      $��Удалить��6'   $
��Left=�69   $��
99,235,0,0q�6T   $	��Top=�6h   $��75��6�   $��24��6�   6�   �� 51   
   -   5        $ 
ButtonEdit��51      $��Изменить��6%   $
��Left=�68   $��24��6S   $��179,235,0,0q�6_   $	��Top=�6t   $��83��6�   6�   �� 52   
   -   5        $ 	ButtonAdd��52      $��Добавить��6$   $
��Left=�67   $��24��6R   $��267,235,0,0q�6^   $	��Top=�6s   $��80��6�   6�   53      54      