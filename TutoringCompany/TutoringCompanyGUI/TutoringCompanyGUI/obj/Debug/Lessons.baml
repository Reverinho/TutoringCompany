   M S B A M L   `   `   `  ����M  ITutoringCompanyGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5   	   7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5   	        TutoringCompanyGUI.Lessons   5      (src clr-namespace:TutoringCompanyGUI  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:TutoringCompanyGUI     5   	     � Title$  Lessons��5	   	   $	��500��6   $	��600��6&    � 
ResizeMode$ CanMinimize=�62    � WindowStyle$
 None=�5
   	    � AllowsTransparency .  � 	Resources 5       �� 
TargetType �� Property   
Background �� Value  MainButtons �� BasedOn  TextBox  
Foreground  LessonTemplate	 �� StringFormat
 �� Orientation �� MergedDictionaries �� Source�� 5   
    50      �� 51      $ Styles.xaml?�6%   �� 52      $ TitleGrid.xaml?�6%   %�  '�       7   '�� D     7  '�� f     7  '�� K    7   7  &	 h    �� 5      " �6   .�5      ��  � ��8   6/   5      �� 5      " ��6   8   6(   �� 5      " ��6   8   .�5      ��  � ��$	 Top=�66   �� 5       � ��$ 40��6+   �� 5       � ��$	 550��6*   �� 5       � ��$ 24(�6-   �� 5       � �� �#201c246/   5      �� 5      " ��6   .�5      ��  � ��8   6/   �� 5       � ��8  6/   �� 5       � ��$ 14(�6-   �� 5       � ��$ Bottom=�66   �� 5       � ��$	 270��6+   �� 5       � ��$	 550��6*   �� 5       � ��$ 0q�64   5       �� 5#      .R�5$      �� $��0,3,0,0q�6   .+�5%      �� $
��Bold"�6\   $��
0, 0, 5, 0q�6n   ��6    �� *
Student.Id+$	 Student ID: {0}��6n   �� 5&      $
 
Horizontal=�6!   .+�5'      �� $��
0, 0, 5, 0q�6B   ��6$   �� *Student.Name+6B   �� 5(      ��6$   �� *Student.Surname+5)      �� 5*      ��6    �� *Lesson.Date_time+$	 	Date: {0}���� 5+      ��6    �� *Time+$	 Time: {HH:MM}��5,      5-      54      .��57      �  � RowDefinitions 58   
   �� 59      $
��Auto �6   �� 5:      $	��30* �6   .+�5<   
   �� -   5         ��Name$ TitleContent��5<        	TitleGrid#��[ 6/   � 5=   
   $��1��6   .+�5>      �� -   5         ��Name$ lessonsListBox��5>      #��[ 6.   $��0, 0, 0, 40q�6^   �� 5?      -   5         ��Name$ 	addLesson��5?      $��
Add Lesson��6+   $	��170��6^   $
��Left=�6j   $��25, 70, 0, 0q�6�   #��[ 6�   �� 5@      -   5        $ deleteLesson��5@      $��Delete Lesson��6+   $	��170��6^   $��Right=�6j   $��	0,70,25,0q�6�   #��[ 6�   �� 5A      -   5        $ 
sortLesson��5A      $��Sort Lesson��6-   $	��170��6_   $��Center=�6k   $��0,70,0,0q�6�   �� 5B      -   5         ��Name$ 	searchBox��5B      $��Search lessons��6+   $��0,15,0,0q�6g   $	��Top=�6y   $��0q�6�   6�   5C      5D      5E      