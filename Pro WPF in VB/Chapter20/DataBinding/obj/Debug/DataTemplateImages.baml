   M S B A M L   `   `   `  ����M  IDataBinding, Version=1.0.4720.20781, Culture=neutral, PublicKeyToken=null)clr-namespace:DataBindingDataBinding  5      $    DataBinding.DataTemplateImages   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      +localclr-namespace:DataBinding     5        � Title$  DataTemplateImages��5      $	��420��6    $	��675��6-    � 	Resources 5      $   DataBinding.ImagePathConverter   ImagePathConverter��%   &	          5   
   6@   5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   6,   �� 5      $��5* �6   6,   .+�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $��* �6    6-   .+�5      �� -   5        $��7,7,7,0q�5      $��2q�6&   .��6O   Get Products6]   �� 5      -   5        $��lstProducts��5   5   $��1��6   $��7,3,7,10q�6#   $��Stretch=�6H   ��5      �� 5      .�5      ��  �� Property � �� �� Value$ 0q�6<   6H    �� Triggers 5      P� 5       P� Property �@��
IsSelected P� Value . . �5   "   ��  � ��
 �  ��6K   5       5"      ��5'      �� 5(      .R�5)      � $��0q�6   
�������.+�5*      �� $��5q�6%   $��1q�60   
�����F�	 �� CornerRadius$	 4��52      ��5+      �� 
 �� RelativeSource
 ��  �� Mode$ FindAncestor=� �� AncestorType" �� �� Path$ 
Background�._�53   "   � $��3q�6'    54   &   �� 55   *   6:   �� 56   *   6:   �� 57   *   6:   .+�59   &   �� $
��Bold"�60   ��6B   �� $ ModelNumber�6f   �� 5:   &   $��1��60   ��6=   �� $ 	ModelName�6_   �� 5;   &   $��2��6,   $��2��69   ��6J   �� $ ProductImagePath� �� 	Converter# [  6�   5<   #   5=      5>      5?      5A      5D      �� 5F   
   $��1��6   $
��Left=�6'   $��Stretch=�6B   $��5��5G      6    �� 5I   
   $��1��6    �� Padding$ 7q�6!   $��7q�6-   
����İ�._�5J      �  � DataContext 6   ��  �� ElementName$ lstProducts��$ SelectedItem� 5K      �� 5L      $
��Auto �6'   66   �� 5M      6)    5O      �� 5P      $
��Auto �6$   64   �� 5Q      $
��Auto �6$   64   �� 5R      $
��Auto �6$   64   �� 5S      $
��Auto �6$   64   �� 5T      $��* �6$   61   .+�5W      �� $��7q�6   Model Number:66   �� 5X      $��5q�6   $��1��6%   ��65   �� $ ModelNumber�6Y   �� 5Y      $��7q�6   $��1��6'   Model Name:6A   �� 5Z      $��5q�6   $��1��6%   $��1��62   ��6B   �� $ 	ModelName�6d   �� 5[      $��7q�6   $��2��6'   
Unit Cost:6@   �� 5\      $��5q�6   $��2��6%   $��1��62   ��6B   �� $ UnitCost�6c   �� 5]      $��7,7,7,0q�6   $��3��6-   Description:6H   �� 5^      $��7q�6   $��4��6%   $��0��62   $��2��6B    �� TextWrapping$
 Wrap=�5_      " �� VerticalScrollBarVisibility$ Visible=�6&   ��6L   �� $ Description�6p   5a      5b      5d      5e      