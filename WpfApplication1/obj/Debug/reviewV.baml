   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5          WpfApplication1.reviewV   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication1     5        N� Title$  reviewV��5	      $	��438��6   $	��361��6#   .��5      � #��� ��6    � ColumnDefinitions 5   
   �� 5      $
��383* �6   �� 5      $	��55* �6   .+�5   
   �� -   5         ��Name$ button��5      $
��Sort��6!   $
��Left=�60   $��
343,34,0,0q�6K   $	��Top=�6_   $��75��6w   $��2��6�   �� 5   
   -   5         ��Name$ listToDO��5      $
��Left=�6%   $	��104��6@   $��	16,72,0,0q�6M   $	��Top=�6`   $	��402��6x   $��2��6�    �� View 5      �� 5      .P�5      �� -   5        Pealkiri�� �� DisplayMemberBinding 5   7   ��  �� Path$ Pealkiri��� 5      -   5        
Loodud�� 5   5   �� $ 
Loomiseaeg��� 5      -   5        
Prioriteet�� 5   9   �� $ 
Prioriteet��� 5      -   5        	Kirjeldus�� 5   8   �� $ 	Kirjeldus�5      5      �� 5   
   -   5        $ listDone��5      $
��Left=�6%   $	��107��6@   $��
16,223,0,0q�6M   $	��Top=�6a   $	��402��6y   $��2��6�    5      �� 5      .P�5      �� -   5        	PealkiriT�� 5   8   �� $ Pealkiri��� 5      -	   5        LoodudT�� 5   6   �� $ 
Loomiseaeg��� 5       -
   5        PrioriteetT�� 5    :   �� $ 
Prioriteet��� 5!      -   5        
KirjeldusT�� 5!   9   �� $ 	Kirjeldus�5"      5$      �� 5%   
   -   5         ��Name$ label��5%      $��Done ToDOs:��6   $
��Left=�65   $��
16,192,0,0q�6P   $	��Top=�6d   $	��167��6|   �� 5&   
   -   5        $ btnDone��5&      $
��Done��6"   $
��Left=�61   $��	16,34,0,0q�6L   $	��Top=�6_   $��75��6w   6�   �� 5'   
   -   5         ��Name$ lblWarningUnselectedItem��5'      $
��Left=�66   $��
106,34,0,0q�6Q   $
��Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��132��6�   $��20��6�   5)      5*      