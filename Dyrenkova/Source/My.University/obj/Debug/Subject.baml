   M S B A M L   `   `   `  ����H  DMy.University, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:My.UniversityMy.University  5   	       My.University.Subject   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:My.University     5   	   -   5          �Name$  subject��5   	    � Title$ Classes��5   	   $	��700��6   $	��700��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H    � SizeToContent$ Height=�6�   .��5	      � .+�5
   
   �� -   5         ��Name$ lbl_name��5
       �� TextAlignment$ Center=�6&   $"��Name of the course (credits)��6=   $
��Wrap=�6a   $��Center=�6u   $	��Top=�6�   $��30(�6�   $��Gill Sans MT)�6�   $��84��6�   $��29,36,27.6,0q�6�   $	��637��6�   �� 5   
   -   5         ��Name$ txtb_descripton��5       �� 
IsReadOnly . $��Center=�6=   $��20(�6Z   $��Gill Sans MT)�6h   $	��187��6�   	 �� TextWrapping$
	 Wrap=�6�   $��Description��6�   $	��Top=�6�   $	��637��6�   $��29,125,27.6,0q�6�   
 �� 	UndoLimit$

 1000��6�    �� SelectionBrush 6  Z� ��6  Z� &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid_cur��5         CanUserSortColumns .  $��Center=�6E   $	��219��6b   $��29,378,27.6,0q�6o   $	��Top=�6�   $	��637��6�   $��Gill Sans MT)�6�   $��20(�6�      
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6�   5      �� 5   
   -   5         ��Name$ 
label_Copy��5      $��	Timetable��6$   $��Center=�68   $	��Top=�6U   $��Gill Sans MT)�6m   $��251,317,250.6,0q�6�   $��40(�6�   $	��192��6�   �� 5   
   -   5         ��Name$ button1��5      $��Add to the schedule��6"   $��Center=�6@   $��68��6]   $��	0,602,0,0q�6i   $��Bottom=�6|   $	��315��6�   $��Gill Sans MT)�6�   $��36(�6�   ��6�   Z� ��6�   Z� 6�   5      5      