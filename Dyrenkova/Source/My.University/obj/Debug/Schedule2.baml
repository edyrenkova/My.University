   M S B A M L   `   `   `  ����H  DMy.University, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:My.UniversityMy.University  5   	       My.University.Schedule2   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:My.University     5   	   -   5          � Title$  Schedule��5   	   $	��768��6   $
��1366��6'    � WindowStartupLocation$ CenterScreen=�6d    � 
ResizeMode$ NoResize=�6�   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��Choose your major��6   $
��Left=�6;   $��55��6V   $��
10,118,0,0q�6b   $	��Top=�6v   $	��253��6�   $��30(�6�   $��Gill Sans MT)�6�   �� 5   
   -   5        $ 
label_Copy��5      $��Choose your minor��6$   $
��Left=�6@   $��52��6[   $��	7,178,0,0q�6g   $	��Top=�6z   $	��251��6�   $��30(�6�   $��Gill Sans MT)�6�   �� 5   
   -   5         ��Name$ 	cmb_major��5      $
��Left=�6&   $��50��6A   $��263,118,0,0q�6M   $	��Top=�6b   $	��202��6z   $��Gill Sans MT)�6�   $��22(�6�    �� SelectedIndex$ 0��6�   �� 5   
   -   5        $ 	cmb_minor��5      $
��Left=�6&   $��50��6A   $��263,178,0,0q�6M   $	��Top=�6b   $	��202��6z   $��Gill Sans MT)�6�   $��22(�6�   $ 0��6�   R� 5   
   -   5         R�Name$ trv_req��5      $��Hidden=�6$   $��20(�6V   $��Gill Sans MT)�6d   $
��Left=�6~   $	��430��6�   $��	7,298,0,0q�6�   $	��Top=�6�   $	��458��6�    � 	Resources 5       �� 
TargetType	 �� Property
 �� Value��%�   'Q�       �� 5      " Q�6   .�5      �� 	 � ��
 5      �� 5      .R�5   "   �� $
��Wrap=�5   $   $	��380��68   ��5   $   �� 5      5      5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5         EnableRowVirtualization .     CanUserAddRows .     CanUserSortColumns .  $
��Left=�6w   $	��250��6�   $��568,118,0,0q�6�   $	��Top=�6�   $	��599��6�   $��20(�6�   $��Gill Sans MT)�6�   $ 0��6   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6?  !   EnableColumnVirtualization .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6�  5      �� 5   
   -   5         ��Name$ 	textBlock��5      $��Center=�6'    �� TextAlignment$ Center=�6D   $��72(�6[   $��Gill Sans MT)�6i   $	��103��6�   $
��Wrap=�6�   $	��Top=�6�   $
��1360��6�   $
��Bold"�6�   �� 6�   $�MY.Schedule��6�   5       �� 5!   
   -	   5         ��Name$ button��5!      $
��Left=�6!   $	��115��6<   $��1198,491,0,0q�6I   $	��Top=�6_   $	��127��6w   $��Gill Sans MT)�6�   $��36(�6�   {�.  ��6�   Z� ��6�   Z� .��5"      �� .��5#      �� $
��Wrap=�6   $��Center=�60   $ Center=�6M   $��Center=�6d   $��Make document��6   $��24(�6�   5$      5%      �� 5&   
   -
   5        $ button1��5&      $��Show requirements��6"   $
��Left=�6>   $��58��6Y   $��
10,235,0,0q�6e   $	��Top=�6y   $	��455��6�   $��Gill Sans MT)�6�   $��36(�6�   ��6�   Z� ��6�   Z� 6�   Z� 5'   
   -   5         Z�Name$ documentViewer��5'      $
��Left=�61   $	��313��6L   $��572,415,0,0q�6Y   $	��Top=�6n   $	��595��6�   �� 5(   
   -   5        $ button2��5(      $	��114��6"   $��1198,190,35,0q�6/   $	��Top=�6F   $��Gill Sans MT)�6�   $��36(�6�   {�.  ��6^   Z� ��6t   Z� .��5)      �� $��Center=�6   .��5*      �� $ Center=�6   $��Center=�63   $
��Wrap=�6N   $��24(�6b   $
��Left=�6p   �� 6�   $�Delete ��6�   �� 6�   $�selected course��6�   6�   5+      5,      �� 5-   
   -   5         ��Name$
 grad��5-       � ToolTip$ Back to the MainWindow��6"    � Cursor$
 Hand��6C   $��1235,0,0,635.4q�6Q   ��5.      �� 5/       �� ImageSource$ graduate.png��6    j� Stretch$ Uniform=�68   52      �� 53   
   -   5        $ 	grad_Copy��53      $ MY.Help��6'   $
 Hand��69   $��1110,0,125,635.4q�6G   ��54      �� 55      $ pics/brain.png��6   $ Uniform=�6:   58      59      5:      