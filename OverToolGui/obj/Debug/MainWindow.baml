   M S B A M L   `   `   `  ����F  BOverToolGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:OverToolGUI.ViewModelOverToolGUI.ViewModel  5   	       OverToolGUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2vm#clr-namespace:OverToolGUI.ViewModel     5   	   -   5          �Name$  DashboardWindow��5   	    � Title$ OverToolGui��5   	   $	��600��5	   	   $	��950��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      /  )OverToolGUI.ViewModel.NavigationViewModel  5      .��5      � .+�5)      �� -   5        ���#303030$��0,0,0,0q�5*      $	��580��5+      $��10,10,10,10q�5,       �� CornerRadius$ 25��5-       J� Effect 5.      3  -System.Windows.Media.Effects.DropShadowEffect  5/      	   ShadowDepth$	 0Q�6   
   
BlurRadius$
 20Q�6'      RenderingBias$ Performance=�67   51      � 55       � ColumnDefinitions 57      �� 59      $��0 �6   �� 5:      $	��180 �6   �� 5;      $��0 �6   �� 5<      $	��660 �6   �� 5=      $��25 �6    � RowDefinitions 5A      �� 5C      $��0 �6   �� 5D      $	��370 �6   .+�5L      � $��1��5M      $��
0,0,0,-220q�6#   $��2��67   .+�5N      �� -   5        $ 	25,0,0,25��5N      $��	10,10,0,0q�6&   ���	#FFEC8100._�5O      �� $��0,112,0,108q�6=   ��6   �� *SourceCollection+��5P      �� 5Q   	   .R�5R   
   �� .+�5S      	� -   5           MenuButtonStyle#��[  5W   .    	� 	GroupName$ 	MenuGroup��5X   .   $��BigNoodleTooOblique)�6D   $��25(�6e   ��5S      �� *
MenuName+
 � Tag 5T   .   �� *	MenuImage+��5U   .   �� *
MenuName+��5V   .   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� Path$ DataContext.MenuCommand�5X   s   5Y      5Z   
   5\      5]      �� 5^      $
��Wrap=�6   $��OVERTOOL��6$   $��	29,39,0,0q�64   $
��Left=�6G   $	��Top=�6b   $1��+Fonts/bignoodletoo.ttf #BigNoodleTooOblique)�6z   $��40(�6�   ��5_      �� 5`       �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6-   .��5a   	   �  � Color$ 	#FFD8D8D8��6   � 5b   	   $ White��6    � Offset$ 1Q�6$   5c   	    5e        5f      $
 2Q�6   $	 3Q�6(   5h      �� 5i      -   5         ��Name$ VersionText��5i      $
��Wrap=�6%   $��0.1.5��69   $��
78,552,0,0q�6F   $
��Left=�6Z   $	��Top=�6u   $1��+Fonts/bignoodletoo.ttf #BigNoodleTooOblique)�6�   $��25(�6�   
������� 5j        5k      $
 2Q�6   $	 3Q�6(      Opacity$ 1Q�68   5m      �� 5o      $
��Wrap=�6   $	��GUI��6$   $��
142,57,0,0q�6/   $
��Left=�6C   $	��Top=�6^   $1��+Fonts/bignoodletoo.ttf #BigNoodleTooOblique)�6v   $��20(�6�   $��21��6�   $��29��6�   ���	#FF61C9FF �� TextAlignment$
 Left=�6�    5p        5q      $
 2Q�6   $	 2Q�6(   $ 1Q�68   5s      5u      � 5x      $��1��6
   $��3��5y      
������ $��0,10,0,-210q�5z   ,   .+�5|      �� -   5         ��Name$ Pages��5|      $��0,10,0,0q�5}   G   ��6!   �� *SelectedViewModel+6G   5      5�      �� 5�      $��25��6   $��25��5�      $��Right=�5�      $	��Top=�5�      $��	0,30,35,0q�5�        CloseBtn_Style#��[ 5�      ��5�      �� *CloseAppCommand+��5�      ��  �� ElementName$ DashboardWindow��5�      5�      5�      