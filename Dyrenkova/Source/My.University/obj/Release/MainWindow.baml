   M S B A M L   `   `   `  ���� H  DMy.University, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:My.UniversityMy.University      My.University.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:My.University     -     � Title$
  Menu��$	��768��$
��1366�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � 	Resources    OnMouseLeftButtonDown1 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value R� KeyTime  System.Windows.Visibility	   	Collapsed
 R� Value   Hidden   Visible��%x  &	        �� .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$
 grad��.\�  $ 0:0:1��$ 993.792Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$
 grad��.\�  $ 0:0:1��$ -192.726Q�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$
 grad��.\�  $ 0:0:1��$ 0Q�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$
 grad��.\�  $ 0:0:1��$ 0.707Q�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$
 grad��.\�  $ 0:0:1��$ 0.684Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ 	textBlock��.\�  $ 0:0:1��$	 6.4Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ 	textBlock��.\�  $ 0:0:1��$ -230.4Q�U� $ (TextElement.FontSize)�$ 	textBlock��.\�  $ 0:0:1��$ 96Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ textBlock_Copy��.\�  $ 0:0:1��$	 400Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ textBlock_Copy��.\�  $ 0:0:1��$
 -6.4Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ 
stackPanel��.\�  $ 0:0:1��$ -628.8Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ stackPanel1��.\�  $ 0:0:1��$ -628.8Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ 
stackPanel��.\�  $ 0:0:1��$	 4.8Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ stackPanel1��.\�  $ 0:0:1��$	 4.8Q�T� $ (UIElement.Visibility)�$ textBlock_Copy��..�i� $ 0:0:0.1��#
 Z	 i� $ 0:0:1��#
 Z	 T� $ (UIElement.Visibility)�$
 grad��..�i� $ 0:0:1��#
 Z T� $ (UIElement.Visibility)�$! pics_png_color_graduate_png��..�i� $ 0:0:1��#
 Z  � Triggers :�  :� RoutedEvent$# UIElement.MouseLeftButtonDown�� :� 
SourceName$
 grad��.[��� #��[  .��� .+��� -    ��Name$ 	textBlock��$
��Left=�$	��153��$��	0,222,0,0q�$
��Wrap=�$��MY. University��$	��Top=�$
��1360��$	��120(�$��Gill Sans MT)� �� TextAlignment$ Center=�$
��Bold"� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� �� T� �� -   $ textBlock_Copy��$
��Left=�$��97��$��	0,380,0,0q�$
��Wrap=�$#��The helper for the US student��$	��Top=�$
��1360��$��72(�$��Gill Sans MT)�$ Center=�$ 0.5,0.5&�z�V� .~��� �� �� T� �� -    ��Name$
 grad��$ 0.5,0.5&� � Cursor$
 Hand��$ ��196.419,176.621,1011.819,0q� � ToolTip$ Press to continue!��$��161.758��$	��Top=�z�V� .~��� �� ��  �� Angle$ -23.819Q�T� ����  �� ImageSource$ pics/png_color/hat.png�� j� Stretch$ Uniform=��� -    ��Name$ 
stackPanel�� �� Orientation$ 
Horizontal=�$��0,776,0,-339.6q�$ 0.5,0.5&�$��Center=�z�V� .~��� �� �� T� .+��� -   $��100,40q�$	��207��$ MY.Useful Info��$
 Hand������ $ Uniform=�$  pics/png_color/ereader.png���� -   $ Famous Alumni��$��100,40q�$	��207��$
 Hand������ $ Uniform=�$# pics/png_color/graduation.png���� -   $ 	MY.Campus��$��100,40q�$	��207��$
 Hand������ $ Uniform=�$ pics/png_color/school.png���� -	   $ stackPanel1��$ 
Horizontal=�$��0,1078,0,-649.6q�$ 0.5,0.5&�$��Center=�z�V� .~��� �� �� T� .+��� -
   $ MY.Schedule��$��100,40q�$	��207��$
 Hand������ $ Uniform=�$! pics/png_color/calendar.png���� -   $ MY.Settings��$��100,40q�$	��207��$
 Hand������ $ Uniform=�$  pics/png_color/desktop.png���� -    ��Name$! pics_png_color_graduate_png��$ To The Beginning��$
 Hand��$��Right=�$	��181��$��0,0,10,0q�$!��pics/png_color/graduate.png��$��Uniform=�$	��Top=�$��197.4��$y�Hidden=�