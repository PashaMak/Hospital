   M S B A M L   `   `   `  ���� C  ?Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Hospital.ViewModelHospital.ViewModel  7 clr-namespace:Hospital.ConverterHospital.Converter  $    Hospital.Windows.ListReception   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6	ViewModel clr-namespace:Hospital.ViewModel     6	Converter clr-namespace:Hospital.Converter       � Title$  ListReception��$	��300��$	��364�� � 	Resources %   Hospital.Converter.DateToString   DateToString  TemplateItem � ColumnDefinitions � RowDefinitions �� Mode �� 	Converter��%N  &	        &	      7     �� .R��  �� $	��200 ��� $	��100 ��� $	��100 ��� $	��100 ��� $��1 � �� .+��� $��Center=�$
��Left=�$
��Wrap=�$��0��$��0������ *	patient+$ TwoWay=��� $��Center=�$
��Left=�$
��Wrap=�$��1��$��0������ *cost+$ TwoWay=��� $��Center=�$
��Left=�$
��Wrap=�$��2��$��0������ *
dateNext+$ TwoWay=�8   �� $��Center=�$
��Left=�$
��Wrap=�$��3��$��0������ *completedWork+$ TwoWay=��� $��Center=�$
��Left=�$��4��$��0��$y�	Collapsed=����� *id+$ TwoWay=� � DataContext +   %Hospital.ViewModel.ReceptionViewModel  .��� .+��� -    ��Name$ ListBoxView��#��[ $
��Left=�$	��220��$��	10,10,0,0q�$	��Top=�$	��337���� -    ��Name$ ButtonClose��$��Закрыть��$
��Left=�$��24��$��
13,235,0,0q�$	��Top=�$��79���� -   $ ButtonDelete��$��Удалить��$
��Left=�$��
99,235,0,0q�$	��Top=�$��75��$��24���� -   $ 
ButtonEdit��$��Изменить��$
��Left=�$��24��$��179,235,0,0q�$	��Top=�$��83���� -   $ 	ButtonAdd��$��Добавить��$
��Left=�$��24��$��267,235,0,0q�$	��Top=�$��80��