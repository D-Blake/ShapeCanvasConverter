   M S B A M L   `   `   `  ����Q  MValueConvertersProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ValueConvertersProjectValueConvertersProject  5   	   S.clr-namespace:ValueConvertersProject.Converter ValueConvertersProject.Converter  5   	   '    !ValueConvertersProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ValueConvertersProject     5   	   >con.clr-namespace:ValueConvertersProject.Converter     5   	   (STUFFValueConvertersProject     5   	     � Title$  
MainWindow��5
   	   $	��350��6   $	��525��6)   
���   � � 	Resources 5      3   -ValueConvertersProject.Converter.DecimalToHex   DecToHex;   5ValueConvertersProject.Converter.ByteToColorConverter  ByteToColor��%:   &	        &	        5   
   6     5   
   6#   5      .��5      (� $
��auto��6   $
��auto��6   .��5   
   � $	��350��6   $	��525��6    � ColumnDefinitions 5      �� 5      $	��65* �6#   �� 5      $	��35* �6#   .+�5      �� $��0��6   ��5      �� 5       �� ImageSource$ face.png��6!   5      �� 5      -   5         ��Name$ canvas��5      $��0��6%   5      �� 5       $��1��6    �� Padding$ 0q�6%   $��3q�61   ��5!      �� 5"       �� EndPoint$ 0.5,0.9&�6*    �� 
StartPoint$ 0.5,0&�6=   .��5#      �  � Color$	 Red��6'   � 5$      $ Green��6'   	 � Offset$		 0.5Q�65   � 5%      $
 Blue��6'   $		 0.9Q�64   5&      ��5(      �� 5)      $ 0.5,0.9&�6*   $ 0.5,0&�6=   .��5*      � $	 Red��6'   � 5+      $ Green��6'   $		 0.5Q�65   � 5,      $
 Blue��6'   $		 0.9Q�64   5-      ._�5/      .   (ValueConvertersProject.PICKSTUFWITHCOLOR  -   5        
  Name$
 PICKERTHING��5/   *   51      �� 56      $��1��6   $��41.2,220,42.8,72q�6%   $��2q�6?   ��57      �� 58      $ 0.5,0.9&�6*   $ 0.5,0&�6=   .��59      � $	 Red��6'   � 5:      $ Green��6'   $		 0.9Q�65   � 5;      $
 Blue��6'   $		 0.5Q�64   5<      ��5>      �� 5?      $ 0.5,0.9&�6*   $ 0.5,0&�6=   .��5@      � $	 Red��6'   � 5A      $ Green��6'   $		 0.9Q�65   � 5B      $
 Blue��6'   $		 0.5Q�64   5C      ._�5E      �� -   5        $��1��5E      $��Update Color��5F      $��Elephant)�6,   $��12(�6B   
���   �
���  ��5G   9   5H      �� 5J      $��1��6   $��41.2,287,42.8,13q�6%   $��2q�6@   ��5K      �� 5L      $ 0.5,0.9&�6*   $ 0.5,0&�6=   .��5M      � $	 Red��6'   � 5N      $ Green��6'   $		 0.9Q�65   � 5O      $
 Blue��6'   $		 0.5Q�64   5P      ��5R      �� 5S      $ 0.5,0.9&�6*   $ 0.5,0&�6=   .��5T      � $	 Red��6'   � 5U      $ Green��6'   $		 0.9Q�65   � 5V      $
 Blue��6'   $		 0.5Q�64   5W      ._�5Y      �� -   5        $��1��5Y   3   $��50��5Z      $	��100��6!   $��Clear��5[      $��Elephant)�6%   $��20(�6;   
���   �
���  ��5\   (   5]      5`      5a      5b      