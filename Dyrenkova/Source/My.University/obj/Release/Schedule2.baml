   M S B A M L   `   `   `  ���� H  DMy.University, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:My.UniversityMy.University      My.University.Schedule2   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:My.University     -     � Title$  Schedule��$	��768��$
��1366�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� .+��� -    ��Name$ label��$��Choose your major��$
��Left=�$��55��$��
10,118,0,0q�$	��Top=�$	��253��$��30(�$��Gill Sans MT)��� -   $ 
label_Copy��$��Choose your minor��$
��Left=�$��52��$��	7,178,0,0q�$	��Top=�$	��251��$��30(�$��Gill Sans MT)��� -    ��Name$ 	cmb_major��$
��Left=�$��50��$��263,118,0,0q�$	��Top=�$	��206��$��Gill Sans MT)�$��22(� �� SelectedIndex$ 0���� -   $ 	cmb_minor��$
��Left=�$��50��$��263,178,0,0q�$	��Top=�$	��206��$��Gill Sans MT)�$��22(�$ 0��R� -    R�Name$ trv_req��$��30(�$��Gill Sans MT)�$
��Left=�$	��430��$��	7,298,0,0q�$	��Top=�$	��459��&   System.Windows.Controls.DataGrid  -     Name$ dataGrid��   CanUserReorderColumns .  	   CanUserSortColumns	 .  $
��Left=�$	��250��$��474,118,0,0q�$	��Top=�$	��714��$��30(�$��Gill Sans MT)�
   CanUserAddRows
 .     CanUserResizeRows .  $ 0���� -    ��Name$ 	textBlock��$��Center=� �� TextAlignment$ Center=�$��72(�$��Gill Sans MT)�$	��103��$
��Wrap=�$��MY.Schedule��$	��Top=�$	��738���� -	    ��Name$ button��$
��Left=�$	��131��$��1193,373,0,0q�$	��Top=�$	��167��$��Gill Sans MT)�$��36(�{�.  ��Z� ��Z� .���� $	��150��$	��121��.���� $
��Wrap=�$��Center=�$��Center=�$��Make document��$��0,-2,0.4,-0.2q�$	��150��$	��123���� -
    ��Name$
 grad�� � ToolTip$ Back to the MainWindow�� � Cursor$
 Hand��$��1235,0,0,635.4q�����  �� ImageSource$ graduate.png�� j� Stretch$ Uniform=��� -   $ button1��$��Show requirements��$
��Left=�$��58��$��
10,235,0,0q�$	��Top=�$	��341��$��Gill Sans MT)�$��36(���Z� ��Z� Z� -    Z�Name$ documentViewer��$
��Left=�$	��355��$��474,373,0,0q�$	��Top=�$	��714���� -   $ button2��$
��Left=�$	��131��$��1193,118,0,0q�$	��Top=�$	��167��$��Gill Sans MT)�$��36(�{�.  ��Z� ��Z� .���� $	��157��.���� $ Center=�$��Center=�$
��Wrap=�$��
0,0,-0.2,0q�$	��128���� $�Delete ���� $�selected course���� -   $ button2_Copy��$
��Left=�$��59��$��1193,298,0,0q�$	��Top=�$	��167��$��Gill Sans MT)�$��36(�{�.  ��Z� ��Z� .���� $	��157��.���� $ Center=�$��Center=�$
��Wrap=�$��
0,0,-0.2,0q�$��46��$��Check��