   M S B A M L   `   `   `  ����F  BWpfSentence, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfSentenceWpfSentence  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       WpfSentence.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfSentence     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  Parsing the sentence��5	   	   $	��450��6&   $	��800��63    � 	Resources 5
         stackPanelColorBackground �� Color 
 indent  fontGeneral  fontSizeGeneral"  System.Windows.TextAlignment  textBlockTextAlignment��%�   &	        &	 #     &	 <     &	 [     &	 u     �� 5   
   $ 	#FFEDEDED��6<   u�5   
   5q�6&   *�5   
   Calibri)�62   X�5   
   16Q�61    5   
   Left=�6=   5      .��5      �  � ShowGridLines .  � ColumnDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��50* �6    � RowDefinitions 5   
   �� 5      $	��160 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6%   #��[  62   .+�5      �� $
��Left=�6   #��[ 5      #��[ 5       #��[ 5!      $
��Wrap=�5"      $\��VВведите предложение для вывода слов построчно:��5#      $��40��6N   �� 5%      -   5         ��Name$ textBoxSplit��5%      #��[ 5&      #��[ 5'      #��[ 5(       �� TextWrapping$
 Wrap=�5)      " �� VerticalScrollBarVisibility$
 Auto=�5*      $	��Top=�5+      $��64.59��5,      5-      �� 5.      -   5        	 ��Name$	 splitButton��5.      $(��"Разобрать на слова��5/      #��[ 50      #��[ 51      #��[ 52      ���	#FFE2D0D0$��Bottom=�54      55      56      �� 58   
   $��0��6   $��1��6%   ���	#FFEDEDED.+�59      �� -   5        
 ��Name$
 listBoxSplit��59      #��[ 5:      #��[ 5;      #��[ 5<      $	��230��5=      5?      5@      �� 5B   
   $��1��6   $��0��6%   #��[  62   .+�5C      �� $
��Left=�6   #��[ 5D      #��[ 5E      #��[ 5F      $
��Wrap=�5G      $���{Введите предложение для перестановки слов от последнего к первому:��5H      $	��Top=�5I      $��39��60   �� 5J      -   5        $ textBoxReverse��5J      #��[ 5K      #��[ 5L      #��[ 5M      $
 Wrap=�5N      $
 Auto=�5O      $	��Top=�5P      $��64.59��5Q      5R      �� 5S      -   5        $	 reverseButton��5S      $'��!Переставить слова��5T      #��[ 5U      #��[ 5V      #��[ 5W      ���	#FFE2D0D0$	��Top=�5Y      5Z      5[      �� 5]   
   $��1��6   $��1��6%   ���	#FFEDEDED.+�5^      �� -   5         ��Name$ labelReverse��5^      #��[ 5_      #��[ 5`      #��[ 5a      $	��230��5b      5c      5e      5f      