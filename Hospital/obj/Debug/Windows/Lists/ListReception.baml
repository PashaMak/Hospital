   M S B A M L   `   `   `  ����C  ?Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Hospital.ViewModelHospital.ViewModel  5   	   7 clr-namespace:Hospital.ConverterHospital.Converter  5   	   $    Hospital.Windows.ListReception   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6	ViewModel clr-namespace:Hospital.ViewModel     5   	   6	Converter clr-namespace:Hospital.Converter     5   	     � Title$  ListReception��5   	   $	��300��6   $	��364��6,    � 	Resources 5	      %   Hospital.Converter.DateToString   DateToString  TemplateItem � ColumnDefinitions � RowDefinitions �� Mode �� 	Converter��%1  &	        &	      7     5
      6%   �� 5      .R�5      �  5      �� 5      $	��200 �6'   �� 5      $	��100 �6'   �� 5      $	��100 �6'   �� 5      $	��100 �6'   �� 5      $��1 �6'    5      �� 5      .+�5      �� $��Center=�5      $
��Left=�5      $
��Wrap=�5      $��0��5      $��0��6   ��5      �� *	patient+$ TwoWay=�5      �� 5      $��Center=�5      $
��Left=�5      $
��Wrap=�5       $��1��5!      $��0��6   ��5      �� *cost+$ TwoWay=�5!      �� 5"      $��Center=�5#      $
��Left=�5$      $
��Wrap=�5%      $��2��5&      $��0��6   ��5"      �� *
dateNext+$ TwoWay=�8   5&      �� 5'      $��Center=�5(      $
��Left=�5)      $
��Wrap=�5*      $��3��5+      $��0��6   ��5'      �� *completedWork+$ TwoWay=�5+      �� 5,      $��Center=�5-      $
��Left=�5.      $��4��5/      $��0��6   $y�	Collapsed=�6)   ��5,      �� *id+$ TwoWay=�5/   )   50      51      52       � DataContext 55      +   %Hospital.ViewModel.ReceptionViewModel  56   
   .��5:      � .+�5;   
   �� -   5         ��Name$ ListBoxView��5;      #��[ 6'   $
��Left=�6T   $	��220��6o   $��	10,10,0,0q�6|   $	��Top=�6�   $	��337��6�   �� 5<   
   -   5         ��Name$ ButtonClose��5<      $��Закрыть��6&   $
��Left=�68   $��24��6S   $��
13,235,0,0q�6_   $	��Top=�6s   $��79��6�   6�   �� 5=   
   -   5        $ ButtonDelete��5=      $��Удалить��6'   $
��Left=�69   $��
99,235,0,0q�6T   $	��Top=�6h   $��75��6�   $��24��6�   6�   �� 5>   
   -   5        $ 
ButtonEdit��5>      $��Изменить��6%   $
��Left=�68   $��24��6S   $��179,235,0,0q�6_   $	��Top=�6t   $��83��6�   6�   �� 5?   
   -   5        $ 	ButtonAdd��5?      $��Добавить��6$   $
��Left=�67   $��24��6R   $��267,235,0,0q�6^   $	��Top=�6s   $��80��6�   6�   5@      5A      