   M S B A M L   `   `   `  ����I  EDESIGNFOR5LABS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DESIGNFOR5LABSDESIGNFOR5LABS  5          DESIGNFOR5LABS.Diijksta   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:DESIGNFOR5LABS     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  Diijksta��5
      $	��800��6   $	��900��6(   $	��800��67   $	��900��6D   $	��800��6P   $	��900��6`    � 	Resources 5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%K  &	        &	 �     &	 �     &	 �     &	     &	 7    &	 Z    &	 }    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E    . $��1��6�   5      5      5      �� 5   
   $ 
WhiteSmoke��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6%   .�5       ��  �@�FocusVisualStyle8   61   �� 5!       � ��8  6+   �� 5"       � ��8  6,   �� 5#       � ��# � ��6+   �� 5$       � ��$ 3q�60   �� 5%       � ��$ Center=�6;   �� 5&       � ��$ Center=�69   �� 5'       � ��$ 1q�6(   �� 5)       � �� 5*      �� 5+      " ��6&   .R�5,      �� $	 border��6!   $
 10��61   #��z��6C   #��z��6m   #��z��6�    . ._�5-      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5.       5/      P� 50       �@��IsDefaulted . . �51   "   �� $ border��6@   # � ��6T    � ��52      P� 53       �@J�IsMouseOver . . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � �� . . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   5:      P� 5;       � {� .  . �5<   "   �� $ border��6?   8   � ��6S   �� 5=   "   $ border��6@   8   � ��6T   �� 5>   "   $ contentPresenter��6K   8 	  � ��6i   5?      5A      5C      5D      5E      .��5G      � ���#B6D7DE � RowDefinitions 5H   
   �� 5I      $��20 �6   �� 5J      $��1* �6   �� 5K      $��2* �6   �� 5M      $��2* �6   �� 5N      $
��2.5* �6   �� 5O      $��2* �6   �� 5P      $	��12* �6   �� 5Q      $��2* �6   �� 5R      $��5* �6   �� 5S      $��2* �6   �� 5T      $	��12* �6   �� 5U      $��2* �6   �� 5V      $��1* �6   �� 5W      $��4* �6   �� 5X      $��1* �6   �� 5Y      $��4* �6   �� 5Z      $��1* �6    � ColumnDefinitions 5\   
   �� 5]      $��1* �6   �� 5^      $	��10* �6   �� 5_      $
��0.5* �6   �� 5`      $
��4.5* �6   �� 5a      $
��1.2* �6   �� 5b      $
��4.5* �6   �� 5c      $
��0.5* �6   �� 5d      $	��10* �6   �� 5e      $��1* �6   �� 5f      $��4* �6   �� 5g      $
��0.5* �6   �� 5h      $��4* �6   �� 5j      $��1* �6   .+�5n   
   �� #��� 
 6   $!��Загрузить граф��69   $��1��6R   $��3��6b   $��2��6v   $��15(�6�   {�6�   �� *IsTaskWorking+��6�   �� *SaveGraphCommand+�� 5o   
   #��� 
 6   $"��Сохранить  граф��69   $��5��6S   $��3��6c   $��2��6w   $��15(�6�   {�6�   �� *IsTaskWorking+��6�   �� *LoadGraphCommand+�� 5q   
   $��3��6   $��1��6!   $��3��61   $��Выбор режима:��6E   $��Bottom=�6Z   $��18(�6u   �� 5s   
   -   5         ��Name$ SetAddNodesModeButton��5s   8   #��� 
 6   $��4��6W   $��1��6d   $��Добавить узлы��6t   $��15(�6�   {�6�   �� *IsTaskWorking+��6�   �� *SetAddNodesModeCommand+�� 5t   
   -   5        $ SetAddEdgesModeButton��5t   9   #��� 
 6   $��4��6X   $��3��6e   $��3��6u   $!��Добавить связи��6�   $��15(�6�   {�6�   �� *IsTaskWorking+��6�   �� *SetAddEdgesModeCommand+�� 5u   
   -   5        $ SetDeletingModeButton��5u   8   #��� 
 6   $��4��6W   $��7��6d   $#��Кнопка удаления��6t   $��15(�6�   {�6�   �� *IsTaskWorking+��6�   �� *SetDeletingModeCommand+�� 5w   
   $��	Граф:��6   $��5��6"   $��1��6/   $��3��6?   $��Bottom=�6S   $��18(�6n   �� 5y   
   -   5         ��Name$ CanvasForGraph��5y   f   $��6��6   $��5��6   $��1��6/   $��7��6?   
������� J� InputBindings 5z      d� 5{       d� Gesture$ 	LeftClicka�6    �� Command 63   �� *LeftButtonClickCommand+5}      �� 5   
   -   5         ��Name$ TextBlockStepExplanation��5      $$��Объяснение шага:��66   $��11��6N   $��1��6\   $��3��6l   $��Bottom=�6�   $��18(�6�   �� 5�   
   $��1��6   $��12��6(   $��2��66   $��7��6G   $
��Auto=�6[   $
��Auto=�6~   .��5�      �� -   5        $ TextBlockWithExplanation��5�      $��15(�6:   ��6H   �� *Explanation+5�      �� 5�   
   $+��%Обход графа в ширину��6   $��15��60   $��
21,0,10,22q�6>   $��19(�6R   $��3��6�   ��6`   �� *BackgroundForBFS+{�6�   �� *IsTaskWorking+��6�   �� *ChangeTaskCommand+6�   �� 5�   
   $-��'Обход графа в глубину��6   $��15��61   $��	10,0,0,21q�6@   $��2��6T   $��4��6d   $��19(�6x   ��6�   �� *BackgroundForDFS+{�6�   �� *IsTaskWorking+��6�   �� *ChangeTaskCommand+�� 5�   
   #��� 
 6   $��Собрать граф��69   $��15��6P   $��7��6^   $��	0,0,21,24q�6o   $��20(�6�   $��2��6�   ��6�   �� *StartProgrammCommand+{�6�   �� *IsTaskWorking+6�   �� 5�   
   $��Ориентир.��6   $��4��6&   $��9��63   ��6D   �� *BackgroundForOrientedGraph+{�6v   �� *IsTaskWorking+��6�   �� *ChangeGraphTypeCommand+�� 5�   
   $��Не Ориентир.��6   $��4��6(   $��11��65   ��6G   �� *BackgroundForNoOrientedGraph+{�6{   �� *IsTaskWorking+��6�   �� *ChangeGraphTypeCommand+�� 5�   
   -   5        $ TextBlockSteps��5�      $��	Шаги:��6,   $��5��69   $��9��6F   $��3��6V   $��Bottom=�6j   $��18(�6�   �� 5�   
   $��9��6   $��6��6'   $��7��64   $��3��6E   $��Center=�6Y   $��Bottom=�6}   
�������.��5�      �� ��6   �� *StepsButtons+��5�      �� 5�      .R�5�      A� $
��Left=�6'   $	��Top=�6B    A� Columns$ 1��6Z   5�      5�      5�      �� 5�   
   $��9��6   $��15��6$   $��11(�62   Начальный�� 5�      	узел:5�      �� 5�   
   $��9��6   $��15��6"   $��3��6t   $��
80,3,14,26q�6�   ��60   �� *StartNodeName+{�6O   �� *IsTaskWorking+6�   �� 5�   
   -   5        $��11��5�   &   $��2��67   $��	1,2,20,27q�6K   $��4��6^   .��5�      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=�6&   
�������$��34��6D   $��51��6P   $��Center=�6[   $��Center=�6x   6�   5�       � 5�   
   -	   5          �Name$ MyFRame2��5�      $��20��6"   $��20��67   5�      5�      