   M S B A M L   `   `   `  ����C  ?Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Hospital.ViewModelHospital.ViewModel  5   	   $    Hospital.Windows.SelectPatient   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6	ViewModel clr-namespace:Hospital.ViewModel     5   	     � Title$  SelectPatientWindow��5   	   $	��300��6%   $	��300��62    � 	Resources 5         TemplateItem � ColumnDefinitions � RowDefinitions �� Mode��%�  &	        �� 5   
   .R�5	      �  5
      �� 5      $��* �6'   �� 5      $��50 �6'   �� 5      $��* �6'   �� 5      $��1 �6'    5      �� 5      .+�5      �� $��Center=�5      $
��Left=�5      $
��Wrap=�5      $��0��5      $��0��6   ��5      �� *fio+$ TwoWay=�5      �� 5      $��Center=�5      $
��Left=�5      $
��Wrap=�5      $��2��5      $��0��6   ��5      �� *phoneNumber+$ TwoWay=�5      �� 5      $��Center=�5      $
��Left=�5      $��3��5       $��0��6   $y�	Collapsed=�6)   ��5      �� *id+$ TwoWay=�5    )   5!      5"      5#       � DataContext 5%      )   #Hospital.ViewModel.PatientViewModel  5&   
   .��5)      � .+�5*   
   �� -   5         ��Name$ ListBoxView��5*      #��[  6'   $
��Left=�6T   $	��222��6o   $��	10,10,0,0q�6|   $	��Top=�6�   $	��272��6�   �� 5+   
   -   5         ��Name$ ButtonSelect��5+      $��Выбрать��6'   $
��Left=�69   $��22��6T   $��150,237,0,0q�6`   $	��Top=�6u   $	��132��6�   6�   �� 5,   
   -   5        $ ButtonClose��5,      $��Закрыть��6&   $
��Left=�68   $��21��6S   $��
10,238,0,0q�6_   $	��Top=�6s   $	��135��6�   6�   5-      5.      