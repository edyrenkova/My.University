   M S B A M L   `   `   `  ���� H  DMy.University, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:My.UniversityMy.University      My.University.Libraries   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:My.University     c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  -     �Name$  Campus�� � Title$ Campus�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�$
��1366��$	��768�� � 	Resources    Library �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value	 R� KeyTime  System.Windows.Visibility
   Hidden R� Value   Visible 
 Campus  Hospital  Shop��%  &	        &	 �    &	 �    &	     �� .��U� $ (UIElement.Opacity)�$ library��.\�  $ 0��$	 0.6Q�  $ 0:0:0.1��$ 0.985Q�T� $ (UIElement.Visibility)�$ path2��..�i� $	 0��# Z
 i� $	 0:0:0.1��# Z T� $ (UIElement.Visibility)�$ 
rectangle2��..�i� $	 0��# Z
 i� $	 0:0:0.1��# Z T� $ (UIElement.Visibility)�$ 
rectangle3��..�i� $	 0��# Z
 i� $	 0:0:0.1��# Z U� $ (UIElement.Opacity)�$ tree1_Copy1��.\�  $ 0��$	 0.7Q�  $ 0:0:0.1��$ 1Q��� .��U� $ (UIElement.Opacity)�$
 grid��.\�  $ 0��$	 0.6Q�  $ 0:0:0.1��$ 1Q�T� $ (UIElement.Visibility)�$ 	rectangle��..�i� $	 0��# Z
 i� $	 0:0:0.1��# Z T� $ (UIElement.Visibility)�$ 
rectangle4��..�i� $	 0��# Z
 i� $	 0:0:0.1��# Z T� $ (UIElement.Visibility)�$ path3��..�i� $	 0��# Z
 i� $	 0:0:0.1��# Z �� .��U� $ (UIElement.Opacity)�$ grid2��.\�  $ 0��$	 0.6Q�  $ 0:0:0.1��$ 1Q�T� $ (UIElement.Visibility)�$ 
rectangle1��..�i� $	 0��# Z
 i� $	 0:0:0.1��# Z T� $ (UIElement.Visibility)�$ 
rectangle5��..�i� $	 0��# Z
 i� $	 0:0:0.1��# Z T� $ (UIElement.Visibility)�$
 path��..�i� $	 0��# Z
 i� $	 0:0:0.1��# Z �� .��U� $ (UIElement.Opacity)�$ grid3��.\�  $ 0��$	 0.6Q�  $ 0:0:0.1��$ 1Q�T� $ (UIElement.Visibility)�$ grid4��..�i� $	 0��# Z
 i� $	 0:0:0.1��# Z  � Triggers :�  :� RoutedEvent$ UIElement.MouseEnter�� :� 
SourceName$ library��.[��� -    ��Name$ Library_BeginStoryboard��#��[  :� $ UIElement.MouseLeave��$ library��.[���  �� BeginStoryboardName$ Library_BeginStoryboard��:� $ UIElement.MouseEnter��$
 grid��.[��� -   $ Campus_BeginStoryboard��#��[ :� $ UIElement.MouseEnter��$ grid3��.[��� -   $ Shop_BeginStoryboard��#��[ :� $ UIElement.MouseLeave��$ grid3��.[��� $ Shop_BeginStoryboard��:� $ UIElement.MouseEnter��$ grid2��.[��� -   $ Hospital_BeginStoryboard��#��[ :� $ UIElement.MouseLeave��$ grid2��.[��� $ Hospital_BeginStoryboard��:� $ UIElement.MouseLeave��$
 grid��.[��� $ Campus_BeginStoryboard��.��� -    �Name$ grid1������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ White�� � Offset$ 0.797Q�� $ 	#FFB6E896��$ 1Q�.+�F� -    F�Name$ path2��5�����j��Rp@��f���ǵ!gp@�S����
�9}�(�
���	 �� StrokeDashArray$	 2 1R�$��371,209.2,0,145.073q� �� Stretch$
 Fill=����	#FF20D0C2$��8��$
��Left=�$
��97.6��$y�Hidden=�� -   $ grid4��$��Right=�$��0,305.4,146.26,257.151q�$��256.54��$y�Hidden=� � RowDefinitions �� .+�F� -	   $ path1��0���� 	=  	= �|��˙�!@ {e� B��+S� ����	$	 2 1R�$��0,-27.2,-16.06,-120.151q����	#FF20D0C2$��8��$��Right=�$	��104���� $��61.8,-129.8,57.14,0q����	#FF20D0C2$��129.612��$	��Top=��� $��79.6,-124.8,73.14,0q�$��103.812��$	��Top=�����  �� ImageSource$ pics/food.png��F� -
   $
 path��+�����z�@�ޣ9����<����_��������	$	 2 1R�$
��Left=�$��66.858,305.4,0,116.612q�$
 Fill=�$��81.742�����	#FF20D0C2$��8��$y�Hidden=�F� -   $ path3��+���Ќ�o��k-�Z�<�|�%Ѱ:6&
�%Ѧ:6��	$	 2 1R�$��0,270.6,593.8,114.6q�$
 Fill=����	#FF20D0C2$��8��$��Right=�$��72��$y�Hidden=��� -    ��Name$ 	textBlock��$
��Left=�$
��Wrap=�$
��1360��$��90(�$��Gill Sans MT)� �� TextAlignment$ Center=�$��	My.Campus��$
��Bold"�$	��117��$	��Top=��� -    ��Name$
 grad�� � ToolTip$ Back to the MainWindow��  � Cursor$
  Hand��$��1213.6,0,0,611.8q����� $ graduate.png��! j� Stretch$! Uniform=�� -   $ grid2��$
��Left=�$��232.8��$��27.4,0,0,10q�$��Bottom=�$��413.2��" J� Opacity$	" 0.6Q�$
  Hand��.+��� -   # ��Name$# hospital��$��pics/hospital.png��$��0,28,157.6,0q��� -   $# tree2��$��pics/tree2.png��$��Right=�$��45��$��	0,0,140,0q�$
��92.8��$��Bottom=��� -   $
# bank��$��pics/bank.png��$��186,0,157.6,0q�$��36��$��Bottom=��� -   $# library��$��pics/library.png��$��
370,0,0,10q�$
��Left=�$��280.8��$	��257��$��Bottom=�$	" 0.6Q�$
  Hand��� -   $
 grid��$	��250��$��625,0,187,-7.6q�$��Bottom=�$	" 0.6Q�$
  Hand��.+��� -   $# school��$��pics/school.png��$��0,20.533,65.6,18.267q��� -   $# fountain��$��pics/fountain.png��$��158.2,0,226.6,28.8q�$
��71.2��$��Bottom=�� -   $ grid3��$��Right=�$	��204��$��	0,0,41,10q�$��Bottom=�$��267.8��$	" 0.6Q�$
  Hand��.+��� -   $
# shop��$��pics/shop.png��$��53,41.2,0,0q��� -   $# tree1��$��pics/tree1.png��$��24.4,105.6,0,0q�$
��Left=�$
��49.2���� -   $ 
rectangle3��$
��Left=�$��129.6��$��303,117,0,0q�$	��Top=�$��137.6�����	#FF20D0C2$y�Hidden=��� -   $ 	rectangle��$��657.733,165.133,564.667,0q����	#FF20D0C2$��118.4��$	��Top=�$y�Hidden=��� -   $ 
rectangle1��$��
53,196,0,0q����	#FF20D0C2$
��Left=�$��137.6��$��129.6��$	��Top=�$y�Hidden=��� -   $ 
rectangle2��$��103.8��$��317.4,131.6,0,0q�$	��Top=�$
��Left=�$��103.8��$y�Hidden=����� $ pics/reading.png���� -   $ 
rectangle5��$��66.6,209.2,0,0q�$
��Left=�$��103.8��$��103.8��$	��Top=�$y�Hidden=����� $ pics/medical.png���� -   $ 
rectangle4��$��678.133,165.133,578.067,0q�$��103.8��$	��Top=�$y�Hidden=����� $ pics/people.png���� -   $# tree1_Copy1��$��pics/tree1.png��$��317.4,0,0,10q�$
��Left=�$
��52.6��$	��104��$��Bottom=�$	" 0.7Q�$
  Hand��