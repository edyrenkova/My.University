   M S B A M L   `   `   `  ����H  DMy.University, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:My.UniversityMy.University  5   	       My.University.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:My.University     5   	   -   5          � Title$
  Menu��5   	   $	��760��6   $
��1360��6#    � WindowStartupLocation$ CenterScreen=�6I    � 
ResizeMode$ NoResize=�6n    � 	Resources 5	         OnMouseLeftButtonDown1 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value R� KeyTime  System.Windows.Visibility	   	Collapsed
 R� Value   Hidden   Visible��%�  &	        �� 5
   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $
 grad��6�   .\�5        $ 0:0:1��6'   $ 993.792Q�67   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $
 grad��6�   .\�5        $ 0:0:1��6'   $ -192.726Q�67   5      U� 5      $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6,   $
 grad��6�   .\�5        $ 0:0:1��6'   $ 0Q�67   5      U� 5      $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6,   $
 grad��6�   .\�5        $ 0:0:1��6'   $ 0.707Q�67   5      U� 5      $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6,   $
 grad��6�   .\�5        $ 0:0:1��6'   $ 0.684Q�67   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ 	textBlock��6�   .\�5        $ 0:0:1��6'   $	 6.4Q�67   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ 	textBlock��6�   .\�5        $ 0:0:1��6'   $ -230.4Q�67   5      U� 5       $ (TextElement.FontSize)�6,   $ 	textBlock��6_   .\�5!        $ 0:0:1��6'   $ 96Q�67   5"      U� 5#      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ textBlock_Copy��6�   .\�5$        $ 0:0:1��6'   $	 400Q�67   5%      U� 5&      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ textBlock_Copy��6�   .\�5'        $ 0:0:1��6'   $
 -6.4Q�67   5(      U� 5)      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ 
stackPanel��6�   .\�5*        $ 0:0:1��6'   $ -628.8Q�67   5+      U� 5,      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ stackPanel1��6�   .\�5-        $ 0:0:1��6'   $ -628.8Q�67   5.      U� 5/      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ 
stackPanel��6�   .\�50        $ 0:0:1��6'   $	 4.8Q�67   51      U� 52      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ stackPanel1��6�   .\�53        $ 0:0:1��6'   $	 4.8Q�67   54      T� 55      $ (UIElement.Visibility)�6,   $ textBlock_Copy��6_   ..�56      i� $ 0:0:0.1��6)   #
 Z	 6;   i� 57      $ 0:0:1��6)   #
 Z	 69   58      T� 59      $ (UIElement.Visibility)�6,   $
 grad��6_   ..�5:      i� $ 0:0:1��6)   #
 Z 69   5;      T� 5<      $ (UIElement.Visibility)�6,   $! pics_png_color_graduate_png��6_   ..�5=      i� $ 0:0:1��6)   #
 Z 69   5>      U� 5?      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ image��6�   .\�5@        $ 0��6'   $ 3.843Q�63     5A      $ 0:0:1��6'   $ -641.809Q�67   5B      U� 5C      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ image��6�   .\�5D        $ 0��6'   $ 49.961Q�63     5E      $ 0:0:1��6'   $ 53.805Q�67   5F      5G      5H       � Triggers 5I      :� 5J   
    :� RoutedEvent$# UIElement.MouseLeftButtonDown��6    :� 
SourceName$
 grad��6C   .[�5K      �� #��[  6   5L      .��5N      � .+�5O   
   �� -   5         ��Name$ 	textBlock��5O      $
��Left=�6'   $	��153��6B   $��	0,222,0,0q�6O   $
��Wrap=�6b   $��MY. University��6v   $	��Top=�6�   $
��1360��6�   $	��120(�6�   $��Gill Sans MT)�6�    �� TextAlignment$ Center=�6�   $
��Bold"�6�    J� RenderTransformOrigin$ 0.5,0.5&�6  z�5P      V� 5Q      .~�5R      �� �� 5S      �� 5T      T� 5U      5V      5X      �� 5Y   
   -   5        $ textBlock_Copy��5Y      $
��Left=�6,   $��97��6G   $��	0,380,0,0q�6S   $
��Wrap=�6f   $#��The helper for the US student��6z   $	��Top=�6�   $
��1360��6�   $��72(�6�   $��Gill Sans MT)�6�   $ Center=�6�   $ 0.5,0.5&�6  z�5Z      V� 5[      .~�5\      �� �� 5]      �� 5^      T� 5_      5`      5b      �� 5c   
   -   5         ��Name$
 grad��5c      $ 0.5,0.5&�6"    � Cursor$
 Hand��6B   $ ��196.419,176.621,1011.819,0q�6P    � ToolTip$ Press to continue!��6t   $��161.758��6�   $	��Top=�6�   z�5d      V� 5e      .~�5f      �� �� 5g      �� 5h       �� Angle$ -23.819Q�6&   T� 5i      5j      ��5l      �� 5m       �� ImageSource$ pics/png_color/hat.png��6    j� Stretch$ Uniform=�6B   5p      �� 5q   
   -   5         ��Name$ 
stackPanel��5q       �� Orientation$ 
Horizontal=�6)   $��70,861,62.6,-420.6q�6B   $ 0.5,0.5&�6^   z�5r      V� 5s      .~�5t      �� �� 5u      �� 5v      T� 5w      5x      .+�5z      �� -   5        $��100,40q�5z      $	��207��6(   $ MY.Useful Info��64   $
 Hand��6M   ��5{      �� 5|      $ Uniform=�6!   $  pics/png_color/ereader.png��63   5~      �� 5      -   5        $ Famous Alumni��5      $��100,40q�60   $	��207��6@   $
 Hand��6l   ��5�      �� 5�      $ Uniform=�6!   $# pics/png_color/graduation.png��63   5�      �� 5�      -   5        $ 	MY.Campus��5�      $��100,40q�6,   $	��207��6<   $
 Hand��6H   ��5�      �� 5�      $ Uniform=�6!   $ pics/png_color/school.png��63   5�      5�      �� 5�   
   -	   5        $ stackPanel1��5�      $ 
Horizontal=�6*   $��270,1090,10,-650q�6C   $ 0.5,0.5&�6]   $��Center=�6}   $
��1074��6�   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      .+�5�      �� -
   5        $ MY.Schedule��5�      $��100,40q�6.   $	��207��6>   $
 Hand��6J   ��5�      �� 5�      $ Uniform=�6!   $! pics/png_color/calendar.png��63   5�      �� 5�      -   5        $ MY.Settings��5�      $��100,40q�6.   $	��207��6>   $
 Hand��6J   ��5�      �� 5�      $ Uniform=�6!   $  pics/png_color/desktop.png��63   5�      �� 5�      $	��111��6   $��100,150,0,0q�6"   $	��Top=�67   $	��148��6O   .+�5�      �� -   5        $	��107��5�       �� Left$ 28��6%   $	��105��66   $$��pics/png_color/mortarboard.png��6B   $
 Hand��6j   6x   5�      5�      �� 5�   
   -   5         ��Name$! pics_png_color_graduate_png��5�      $ To The Beginning��65   $
 Hand��6P   $��Right=�6^   $	��181��6z   $��0,0,10,0q�6�   $!��pics/png_color/graduate.png��6�   $��Uniform=�6�   $	��Top=�6�   $��197.4��6�   $y�Hidden=�6(  �� 5�   
   -   5        $ image��5�      $	��119��6   $
��Left=�6,   $	��442��6G   $��502.822,0,0,-130.323q�6S   $��Bottom=�6q   $ 0.5,0.5&�6�   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      5�      5�      5�      