   M S B A M L   `   `   `  ����M  ITutoringCompanyGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5   	   7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5   	   !    TutoringCompanyGUI.Students   5      (src clr-namespace:TutoringCompanyGUI  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:TutoringCompanyGUI     5   	     � Title$  Students��5	   	   $	��500��6   $	��600��6'    � 
ResizeMode$ CanMinimize=�63    � WindowStyle$
 None=�5
   	    � AllowsTransparency .  � 	Resources 5       �� 
TargetType �� Property   
Background �� Value  MainButtons �� BasedOn  TextBox  
Foreground  StudentTemplate	 �� StringFormat
 �� Orientation �� MergedDictionaries �� Source�� 5   
    57      �� 58      $ Styles.xaml?�6%   �� 59      $ TitleGrid.xaml?�6%   %�  '�       7   '�� D     7  '�� f     7  '�� K    7   7  &	 h    �� 5      " �6   .�5      ��  � ��8   6/   5      �� 5      " ��6   8   6(   �� 5      " ��6   8   .�5      ��  � ��$	 Top=�66   �� 5       � ��$ 40��6+   �� 5       � ��$	 550��6*   �� 5       � ��$ 24(�6-   �� 5       � �� �#201c246/   5      �� 5      " ��6   .�5      ��  � ��8   6/   �� 5       � ��8  6/   �� 5       � ��$ 14(�6-   �� 5       � ��$ Bottom=�66   �� 5       � ��$	 270��6+   �� 5       � ��$	 550��6*   �� 5       � ��$ 0q�64   5       �� 5"      .R�5#      �� $��0,3,0,0q�6   .+�5$      �� $
��Bold"�6L   $��
0, 0, 5, 0q�6^   ��6    �� *Id+$	 ID: {0}��6^   �� 5%      $
 
Horizontal=�6!   .+�5&      �� $��
0, 0, 5, 0q�6:   ��6$   �� *Name+6:   �� 5'      ��6$   �� *	Surname+5(      �� 5)      ��6    �� *PhoneNumber+$	 Phone: {0:C}���� 5*      $
 
Horizontal=�6!   .+�5+      �� $��
0, 0, 5, 0q�6_   ��6$   �� *Client.Name+$	 Client: {0:C}��6_   �� 5,      ��6$   �� *Client.Surname+5-      �� 5.      $
 
Horizontal=�6!   .+�5/      �� $��
0, 0, 5, 0q�6]   ��6$   �� *
Tutor.Name+$	 Tutor: {0:C}��6]   �� 50      ��6$   �� *Tutor.Surname+51      �� 52      ��6    �� *Class+�� 53      ��6    �� *Gender+54      55      5;      .��5>      �  � RowDefinitions 5?   
   �� 5@      $
��Auto �6   �� 5A      $	��30* �6   .+�5C   
   �� -   5         ��Name$ TitleContent��5C        	TitleGrid#��[ 6/   � 5D   
   $��1��6   .+�5E      �� -   5         ��Name$ studentsListBox��5E      #��[ 6/   $��0, 0, 0, 40q�6`   �� 5F      -   5         ��Name$ 
addStudent��5F      $��Add Student��6,   $	��170��6a   $
��Left=�6m   $��25, 70, 0, 0q�6�   #��[ 6�   �� 5G      -   5        $ deleteStudent��5G      $��Delete Student��6,   $	��170��6a   $��Right=�6m   $��0, 70, 25, 0q�6�   #��[ 6�   �� 5H      -   5        $ sortStudent��5H      $��Sort Student��6-   $	��170��6a   $��Center=�6m   $��0,70,0,0q�6�   �� 5I      -   5         ��Name$ 	searchBox��5I      $��Search students��6+   $��0,15,0,0q�6h   $	��Top=�6z   $��0q�6�   6�   5J      5K      5L      