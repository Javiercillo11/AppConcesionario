   M S B A M L   `   `   `  ����  concesionario    concesionario.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��650��6   $	��885��6)    � 	Resources 5         cabecera �� 
TargetType �� Property �� Value��%�   &	        �� 5	   
   " ��6!   .�5
      ��  � ��
 ����6@   �� 5       � ��
 ����6@   �� 5       � ��$ 20(�6)   66   �� 5       � ��$
 Bold"�6+   6:   5      5      .��5      �  � ShowGridLines .   � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      $��0 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   6+   �� 5      $��* �6   6)   �� 5      $	��300 �6   6+   .+�5   
   �� $��1��6   
�������.+�5      �� -   5         ��Name$ Bordes��5      	 �� CornerRadius$	 15��5      $	��140��5      $��1,1,1,1q�5      
���   �$��
15,30,26,0q�5!      5"      �� 5$   
   
��� ���$��0��6(   $��3��65   6L   �� 5%   
   -   5        $��imagen��5%      $��Resources\fondo.png��6   �� 5&   
   $��CONCESIONARIOS-DAM��6   $��40(�6.   $��Bradley Hand ITC)�6=   
�������$��38,20,145,0q�6o   $��2��6�   �� 5'   
   -   5        $��Modelos��5'   &   
�������$��1��65   $��2��6B   $��22,23,40,10q�6R   
������
 �� View
 5(      �� 5)      .P�5*      �� $��Marca��6%    �� Width$	 120��64    �� DisplayMemberBinding 6@   �� *Marca+6i   �� 5+      $��Modelo��6%   $	 120��65    6A   �� *Modelo+6k   �� 5,      $��Version��6%   $	 120��66    6B   �� *	Version+6m   �� 5-      $��Combustible��6%   $	 120��6:    6F   �� *Combustible+6u   �� 5.      $��Precio��6%   $	 130��65    6A   �� *Precio+6k   5/      51      �� 52   
   $��2��6   $��2��6"   $��263,3,245,145q�62   .+�53      �� -   5         ��Name$ imagenes��53      $��Resources\logo-coche.jpg��6'   $	��250��6I   $
��10,0q�6V   54      �� 55   
   $��2��6   $��2��6"   .+�57      �� -   5        $ borde��57      $	 15��58      $	��262��59      
������$��1,1,1,1q�5;      
�������$��
21,20,45,0q�5<   (   ._�5=      �� $��	9,9,446,9q�6   .+�5?      �� 	 �� X1$ 1��6   	 �� X2$	 160��6"   	 �� Y1$ 0��6+   	 �� Y2$ 0��62   $��3��69   
������6D   �� 5@      
 5A      �� 5B      .P�5C      �� $��Extras��6-   $	 150��6=    6I   �� *Extras+6s   5D      5F      5G      5H      5I      �� 5J   
   $��Elíge un modelo��6   $��20(�6+   
���   �$��Bradley Hand ITC)�6M   $��21,10,3,247q�6k   $��2��6�   �� 5K   
   $��Elíge tu marca��6   $��Bradley Hand ITC)�6+   $��22(�6I   
���   �$��30,34,10,128q�6j   $��1��6�   	� 5L   
   -   5         	�Name$ Peugeot��5L      $��Bradley Hand ITC)�6(   $��17(�6F    d� 	IsChecked$
 TrueY�6T   $��Peugeot��6�   $
��Left=�6�   $��	23,67,0,0q�6�   $��1��6�   $	��Top=�6�   $��24��6�   $��76��6�   	� 5M   
   -   5        $ Hyundai��5M      $��Bradley Hand ITC)�6(   $��17(�6F   $��Hyundai��6U   $
��Left=�6�   $��	23,96,0,0q�6�   $��1��6�   $	��Top=�6�   $��17��6�   $��76��6�   	� 5N   
   -   5        $	 Kia��5N      $��Bradley Hand ITC)�6$   $	��Kia��6B   $��17(�6P   $
��Left=�6}   $��
23,127,0,0q�6�   $��1��6�   $	��Top=�6�   $��17��6�   $��48��6�   �� 5O   
   -	   5        $��
Despegable��5O      $
��Left=�6T   $��	36,58,0,0q�6o   $��2��6�   $	��Top=�6�   $	��120��6�   $��22��6�   .@�5P      ��  	 item1#��[ 6   �� 5Q       	 item2#��[ 6   �� 5R       	 item3#��[ 6   5S      �� 5T   
   $��2��6   $��2��6"   $��263,27,145,31q�62   .+�5U      �� -
   5        $ fondo��5U      $��Resources\logo-coche.jpg��6$   $	��250��6F   $
��10,0q�6S   5V      5X      5Y      