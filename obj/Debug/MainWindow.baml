   M S B A M L   `   `   `  ����L  HwpfInventarioUNIR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:wpfInventarioUNIRwpfInventarioUNIR  5   	   "    wpfInventarioUNIR.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:wpfInventarioUNIR     5   	   -   5          �Name$  
Inventario��5   	    � Title$ 
Inventario��5   	   $��531.536��6   $��406.151��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ groupBox��5
      $��Datos del medicamento��6%   $
��Left=�6D   $	��145��6_   $��	34,27,0,0q�6l   $	��Top=�6   $	��336��6�   .��5      � $
��Left=�6   $	��128��6.   $	��Top=�6;   $	��314��6S   $��0,0,0,-5q�6_   .+�5      �� -   5         ��Name$ lblNombreMedicamento��5      $��Nombre��66   $
��Left=�6G   $��	10,10,0,0q�6b   $	��Top=�6u   �� 5      -   5         ��Name$ tbNombreMedicamento��5      $
��Left=�67   $��23��6R   $��	88,13,0,0q�6^    �� TextWrapping$
 Wrap=�6q   $	��Top=�6�   $	��216��6�   �� 5      -   5        $ lblTipoMedicamento��5      $
��Tipo��64   $
��Left=�6C   $��	22,41,0,0q�6^   $	��Top=�6q   �� 5      -   5         ��Name$ cbTipoMedicamento��5      $
��Left=�66   $��	88,45,0,0q�6Q   $	��Top=�6d   $	��216��6|   .@�5      �� �� 5      $��Analgésico��6"   �� 5      $��Analéptico��6"   �� 5      $��Anestésico��6"   �� 5      $��
Antiácido��6"   �� 5      $��Antidepresivo��6"   �� 5      $��Antibióticos��6"   5      �� 5      -   5        $ lblCantidad��5      $��Cantidad��6-   $
��Left=�6@   $��	22,81,0,0q�6[   $	��Top=�6n   �� 5      -   5        $ tbCantidadMedicamento��5      $
��Left=�69   $��23��6T   $��	88,84,0,0q�6`   $
 Wrap=�6s   $	��Top=�6�   $	��216��6�   5      5      �� 5   
   -	   5        $ gbDistribuidor��5      $��Distribuido Farmacéutico��6+   $
��Left=�6M   $��78��6h   $��
37,189,0,0q�6t   $	��Top=�6�   $	��333��6�   .��5      � $
��Left=�6   $��85��6.   $��	10,2,-2,0q�6:   $	��Top=�6M   $	��313��6e    � ColumnDefinitions 5       �� 5!      $
��280* �6'   �� 5"      $	��13* �6'   .+�5$      	� -
   5         	�Name$ rbCofama��5$      $��Cofama��60   $
��Left=�6A   $��	10,20,0,0q�6\   $	��Top=�6o   	 	� 	GroupName$	 grupoDistribuidor��6�   	� 5%      -   5        $ rbEmpsephar��5%      $��	Empsephar��63   $
��Left=�6G   $��
106,20,0,0q�6b   $	��Top=�6v   $	 grupoDistribuidor��6�   	� 5&      -   5        $ 	rbCemefar��5&      $��Cemefar��61   $
��Left=�6C   $��
220,20,0,0q�6^   $	��Top=�6r   $	 grupoDistribuidor��6�   5'      5(      �� 5)   
   -   5        $ 	groupBox2��5)      $��
Recibir en��6&   $
��Left=�6:   $	��114��6U   $��
37,285,0,0q�6b   $	��Top=�6v   $	��333��6�   .��5*      � $
��Left=�6   $��66��6.   $��
10,10,-2,0q�6:   $	��Top=�6N   $	��313��6f   .+�5+      �� -   5        
 ��Name$
 cbSucursalPrincipal��5+      $��Sucursal Principal��68   $
��Left=�6U   $��	17,10,0,0q�6p   $	��Top=�6�    � ToolTip$ Calle de la Rosa n. 28��6�   �� 5,      -   5        $
 cbSucursalSecundaria��5,      $��Sucursal Secundaria��69   $
��Left=�6W   $��	17,39,0,0q�6r   $	��Top=�6�   $ Calle Alcazabilla n. 3��6�   5-      5.      �� 50   
   -   5         ��Name$ Enviar��50      $��Enviar��6!   $
��Left=�62   $��38��6M   $��278,427,0,0q�6Y   $	��Top=�6n   $��92��6�   6�   �� 51   
   -   5        $ 	btnBorrar��51      $��Borrar��6$   $
��Left=�65   $��38��6P   $��178,427,0,0q�6\   $	��Top=�6q   $��82��6�   6�   53      54      