   M S B A M L   `   `   `  ���� F  BOverToolGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:OverToolGUI.ViewModelOverToolGUI.ViewModel      OverToolGUI.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2vm#clr-namespace:OverToolGUI.ViewModel     -     �Name$  DashboardWindow�� � Title$ OverToolGui��$	��600��$	��950�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�
������  � AllowsTransparency .  � DataContext /  )OverToolGUI.ViewModel.NavigationViewModel  .��� .+��� -   ���#303030$��0,0,0,0q�$	��580��$��10,10,10,10q� �� CornerRadius$ 25�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect  	   ShadowDepth$	 0Q�
   
BlurRadius$
 20Q�   RenderingBias$ Performance=��  � ColumnDefinitions �� $��0 ��� $	��180 ��� $��0 ��� $	��660 ��� $��25 � � RowDefinitions �� $��0 ��� $	��370 �.+�� $��1��$��
0,0,0,-220q�$��2��.+��� -   $ 	25,0,0,25��$��	10,10,0,0q����	#FFEC8100._��� $��0,112,0,108q����� *SourceCollection+���� .R��� .+�	� -      MenuButtonStyle#��[   	� 	GroupName$ 	MenuGroup��$��BigNoodleTooOblique)�$��25(����� *
MenuName+
 � Tag �� *	MenuImage+���� *
MenuName+����  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� Path$ DataContext.MenuCommand��� $
��Wrap=�$��OVERTOOL��$��	29,39,0,0q�$
��Left=�$	��Top=�$1��+Fonts/bignoodletoo.ttf #BigNoodleTooOblique)�$��40(�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFD8D8D8��� $ White�� � Offset$ 1Q�   $
 2Q�$	 3Q��� -    ��Name$ VersionText��$
��Wrap=�$��0.1.6��$��
78,552,0,0q�$
��Left=�$	��Top=�$1��+Fonts/bignoodletoo.ttf #BigNoodleTooOblique)�$��25(�
�������   $
 2Q�$	 3Q�   Opacity$ 1Q��� $
��Wrap=�$	��GUI��$��
142,57,0,0q�$
��Left=�$	��Top=�$1��+Fonts/bignoodletoo.ttf #BigNoodleTooOblique)�$��20(�$��21��$��29�����	#FF61C9FF �� TextAlignment$
 Left=�   $
 2Q�$	 2Q�$ 1Q�� $��1��$��3��
������ $��0,10,0,-210q�.+��� -    ��Name$ Pages��$��0,10,0,0q����� *SelectedViewModel+�� $��25��$��25��$��Right=�$	��Top=�$��	0,30,35,0q�  CloseBtn_Style#��[ ���� *CloseAppCommand+����  �� ElementName$ DashboardWindow��