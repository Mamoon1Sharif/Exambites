   M S B A M L   `   `   `  ����S  OAnimationplayerExamBites, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:AnimationplayerExamBites.PagesAnimationplayerExamBites.Pages  5      2    ,AnimationplayerExamBites.Pages.UIVideoPlayer   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:AnimationplayerExamBites.Pages     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��20 �6   �� 5      $��50 �6   ��5   
   �� 5       �� ImageSource$2 ,pack://application:,,,/images/background.png��6   .+�5   
   � .+�5      (� $��80��6   .��5      "  FontAwesome.WPF.ImageAwesome  -   5        $��DecodingSpinner��5   &      Icon$ Spinner=�6=   $y�Hidden=�6N      SpinDuration$ 10Q�6b   5       5#      � 5%   
   $��0��6    � ColumnDefinitions 5&      �� 5'      $��45 �6#   �� 5(      $��* �6#   .+�5-      �� -   5         � ToolTip$
 Home��5-      $��0q�6$   $
��Left=�68   $	��Top=�6S   
������ $��0��6�   $��0��6�   .��5/      A� $��0��6   $��45��6+   $��45��67   ��50      �� 51      $5 /pack://application:,,,/images/examBitesLogo.png��6&   53      54      (� 58      $��1��6   ��6(   ��  �� RelativeSource �� *TemplatedParent+ �� Path$ ActualWidth�.��59      r� -   5         r�Name$ MyMediaElement��59   H   $��Stretch=�6�   $��Stretch=�6�   	 r� LoadedBehavior$	 Manual=�6�   
 J� RenderTransformOrigin$
 	0.5,0.474&�64  ��6a   ��  �� *TemplatedParent+$ ActualWidth�64  5:      5;      � 5<   
   $��2��6    5=      �� 5>      $��2* �6#   �� 5?      $��* �6#   .+�5C      �� -   5        
������ $��0q�5C   H   $��0��6]   $��20(�6n   $
��Left=�6|   $��2,2,0,2q�6�   $��50��6�   .��5D      A� $��0��6   $��45��6+   $��45��67   ��5E      �� 5F      $, &pack://application:,,,/images/play.png��6&   5H      5I      �� 5J      -   5        $��0��5J   0   
������ $��0q�6Y   $��20(�6m   $
��Left=�6{   $��50 2 2 2q�6�   $��50��6�   .��5K      A� $��0��6   $��45��6+   $��45��67   ��5L      �� 5M      $- 'pack://application:,,,/images/pause.png��6&   5O      5P      �� 5Q      -   5        $��0��5Q   /   
������ $��0q�6X   $��20(�6m   $
��Left=�6{   $��	100,2,2,2q�6�   $��50��6�   .��5R      A� $��0��6   $��45��6+   $��45��67   ��5S      �� 5T      $, &pack://application:,,,/images/stop.png��6&   5V      5W      �� 5Y       �� Orientation$ 
Horizontal=�6   $	��400��62   $��1��6>   .+�5Z      �� -   5        
������ $��0q�5Z   L   $��1��6a   $��20(�6r   $��0q�6�   $��50��6�   .��5[      A� $��1��6   $��45��6/   $��45��6;   ��5\      �� 5]      $. (pack://application:,,,/images/volume.png��6*   5_      5`      �� 5a      -   5         ��Name$ slider_volume��5a      $	��370��60   $��0 10 0 0q�6<   $��Stretch=�5b       � Maximum$ 1Q�67    � LargeChange$	 0.1Q�5c       � SmallChange$
 0.01Q�6+    � Value$ 1Q�6>   $
 0.5,0.5&�5e      |�.  z�5g      V� 5h      .~�5i      ��  �� ScaleX$ -1Q�6-   �� 5j      �� 5k      T� 5l      5m      5q      5r      5s      � 5t   
   $��1��6   .+�5v      �� -	   5        $��slider_slack��5v   1    �� Delay$ 2��6   $��20(�6"   $��Stretch=�6E   $��Stretch=�6c   $
 0.5,0.5&�6�   6�   5w      5~      5      