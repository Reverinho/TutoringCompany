   M S B A M L   `   `   `  ����M  ITutoringCompanyGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5   	   7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5   	       TutoringCompanyGUI.Tutors   5      (src clr-namespace:TutoringCompanyGUI  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:TutoringCompanyGUI     5   	     � Title$  Tutors��5	   	   $	��500��6   $	��600��6%    � 
ResizeMode$ CanMinimize=�61    � WindowStyle$
 None=�5
   	    � AllowsTransparency .  � 	Resources 5       �� 
TargetType �� Property   
Background �� Value  MainButtons �� BasedOn  TextBox  
Foreground  TutorTemplate	 �� StringFormat
 �� Orientation �� MergedDictionaries �� Source�� 5   
    51      �� 52      $ Styles.xaml?�6%   �� 53      $ TitleGrid.xaml?�6%   %�  '�       7   '�� D     7  '�� f     7  '�� K    7   7  &	 h    �� 5      " �6   .�5      ��  � ��8   6/   5      �� 5      " ��6   8   6(   �� 5      " ��6   8   .�5      ��  � ��$	 Top=�66   �� 5       � ��$ 40��6+   �� 5       � ��$	 550��6*   �� 5       � ��$ 24(�6-   �� 5       � �� �#201c246/   5      �� 5      " ��6   .�5      ��  � ��8   6/   �� 5       � ��8  6/   �� 5       � ��$ 14(�6-   �� 5       � ��$ Bottom=�66   �� 5       � ��$	 270��6+   �� 5        � ��$	 550��6*   �� 5!       � ��$ 0q�64   5"      �� 5$      .R�5%      �� $��0,3,0,0q�6   .+�5&      �� $
��Bold"�6L   $��
0, 0, 5, 0q�6^   ��6    �� *Id+$	 ID: {0}��6^   �� 5'      $
 
Horizontal=�6!   .+�5(      �� $��
0, 0, 5, 0q�6:   ��6$   �� *Name+6:   �� 5)      ��6$   �� *	Surname+5*      �� 5+      ��6    �� *PhoneNumber+$	 Phone: {0:C}���� 5,      ��6    �� *Email+$	 Email: {0:C}���� 5-      ��6    �� *
LessonRate+$	 Rate: {0:C}���� 5.      ��6    �� *Gender+5/      50      55      .��58      �  � RowDefinitions 59   
   �� 5:      $
��Auto �6   �� 5;      $	��30* �6   .+�5=   
   �� -   5         ��Name$ TitleContent��5=        	TitleGrid#��[ 6/   � 5>   
   $��1��6   .+�5?      �� -   5         ��Name$ tutorsListBox��5?      #��[ 6-   $��0, 0, 0, 40q�6\   �� 5@      -   5         ��Name$ addTutor��5@      $��	Add Tutor��6*   $	��170��6[   $
��Left=�6g   $��25, 70, 0, 0q�6�   #��[ 6�   �� 5A      -   5        $ deleteTutor��5A      $��Delete Tutor��6*   $	��170��6[   $��Right=�6g   $��0, 70, 25, 0q�6�   #��[ 6�   �� 5B      -   5        $ 	sortTutor��5B      $��
Sort Tutor��6,   $	��170��6\   $��Center=�6h   $��0,70,0,0q�6�   �� 5C      -   5         ��Name$ 	searchBox��5C      $��Search Tutors��6+   $��0,15,0,0q�6�   5D      5E      5F      