   M S B A M L   `   `   `  ����C  ?TabMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FizjoTerm	FizjoTerm  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5   	   #clr-namespace:TabMenu2TabMenu2  5	   	       FizjoTerm.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:FizjoTerm     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %TabMenu2clr-namespace:TabMenu2  5	   	   -   5        $	��800��5   	   $
��1200��6     � 
ResizeMode$  	CanResize=�6#    � WindowStyle$
 None=�6:    � WindowStartupLocation$ CenterScreen=�6d    � WindowState$ Normal=�6�    � 	Resources 5         TabMenu2.DefConnDataSet   defConnDataSet  patientViewSource �� Source �� Source  referralViewSource  physiotherapistViewSource  visitViewSource  reportViewSource��%J  &	        &	      7   &	 @     7   &	 n     7   &	 �     7   &	 �     7     5   
   6"   �� 5   
    69   �� *	Patient+8   �� 5   
    6:   �� *
Referral+8   �� 5   
    6A   �� *Physiotherapist+8   �� 5   
    67   �� *Visit+8   �� 5   
    68   �� *Report+8   5      .��5      � .+�5   
   � -   5        $��60��5      $	��Top=�6   ���	#FF009688 � UseLayoutRounding .  ��. .+�5      �� 
�������$��Center=�6+   $��Center=�6H   $��22(�6c   $��Champagne & Limousines)�6q   $��462,1,506.6,32q�6�   $	��105��6�   �� 5      -   5        $��Right=�5      $��Center=�61   $��0,0,0,28q�6y   ��6L   Z� ��6b   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6*   5      �� 5      -   5        $��Right=�5      $��Center=�61   $��	0,0,76,28q�6y   ��6L   Z� ��6b   Z� .��5        $ WindowMinimize=�6*   5      �� 5      -   5        $��Right=�5      $��Center=�61   $��	0,0,39,28q�6y   ��6L   Z� ��6b   Z� .��5         $ WindowMaximize=�6*   5!      5"      � 5#   
   $��0,33,-0.4,0q�6   .+�5$        Dragablz.TabablzControl  $��0,-10,0,-0.4q�6&   	   InterTabController	 5%      !  Dragablz.InterTabController  5&      .@�5)      �� -   5        
 ��Name$
 	TiPatient��5)      $��PACJENCI��6-   .��5*      �  � DataContext# [ 6   $��0,0,0,67q�6L   .+�5+      �� -   5         ��Name$ TbPatientName��5+   "   $
��Left=�6:   $��	35,32,0,0q�6U    �� TextWrapping$
 Wrap=�6h   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Imię��6|   $	��Top=�6�   $	��400��6�   $��0,0,0,1q�6�   $��14(�6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   �� 5,      -   5        $ TbPatientSurname��5,   "   $
��Left=�6=   $��	35,89,0,0q�6X   $
 Wrap=�6k   $ Nazwisko��6   $	��Top=�6�   $	��400��6�   $��14(�6�   #��[ 6�   �� 5-      -	   5        $ TbPatientPesel��5-   "   $
��Left=�6:   $��
475,32,0,0q�6V   $
 Wrap=�6j   $ PESEL��6~   $	��Top=�6�   $	��400��6�   $��14(�6�   #��[ 6�   �� 5.      -
   5        $ TbPatientAdress��5.   "   $
��Left=�6;   $��
35,141,0,0q�6V   $
 Wrap=�6j   $ Adres��6~   $	��Top=�6�   $	��840��6�   $��14(�6�   #��[ 6�   �� 5/      -   5        $ TbPatientPhone��5/   "   $
��Left=�6:   $��
475,89,0,0q�6V   $
 Wrap=�6j   $ Telefon��6~   $	��Top=�6�   $	��400��6�   $��14(�6�   #��[ 6�   �� 50      -   5         ��Name$ BtAddPatient��50   !   $��Dodaj��67   $��Right=�6G   $��	0,42,45,0q�6c   $	��Top=�6v   $	��200��6�   $��30��6�   6�   �� 51      -   5        $ BtSearchPatient��51   !   $��Wyszukaj��6:   $��Right=�6M   $��
0,112,45,0q�6i   $	��Top=�6}   $	��200��6�   $��30��6�   6�   �� 52      -   5        $ BtDeletePatient��52   !   $��Usuń��6:   $��Right=�6I   $��	0,77,45,0q�6e   $	��Top=�6x   $	��200��6�   $��30��6�   6�   �� 53      -   5        $ BtViewAllPatient��53   !   $��Pokaż wszystkich��6;   $��Right=�6V   $��
0,147,45,0q�6r   $	��Top=�6�   $	��200��6�   $��30��6�   6�   &   System.Windows.Controls.DataGrid  57      -   5          Name$ patientDataGrid��57   #      AutoGenerateColumns .     EnableRowVirtualization . $��10,221,10,9.8q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�      GridLinesVisibility$ 
Horizontal=�6�      CanUserAddRows .     CanUserDeleteRows .  $	��100��6'  ��6w   ��    Columns 58      0  *System.Windows.Controls.DataGridTextColumn  5:   "   -   5        
nameColumn��,	  &System.Windows.Controls.DataGridColumn 	  Header$ Imię��5:   �    	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	 200
 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ 	LostFocus=�6�     5;   "   -   5        surnameColumn��$ Nazwisko��5;   �   $	 200
 6�    6L   �� *	Surname+$ TwoWay=�$ 	LostFocus=�6�     5<   "   -   5        peselColumn��$ PESEL��5<   d   $	 200
 6s    	  
IsReadOnly .  6J   �� *Pesel+6     5=   "   -   5        adressColumn��$ Adres��5=   �    	  MinWidth$	 100Q�6�   $ *
 6�    6K   �� *Adress+$ TwoWay=�$ 	LostFocus=�6�     5>   "   -   5        phoneColumn��$ Telefon��5>   �   $	 200
 6�    6J   �� *Phone+$ TwoWay=�$ 	LostFocus=�6�   5@      5B      5C      �� 5D      $��SKIEROWANIA��6   .��5E      � # [ 6   .+�5G      �� -   5        $ TbDiagnosis��5G   "   $
��Left=�67   $	��Top=�6R   $	��400��6j   $
 Wrap=�6v   $ Rozpoznanie��6�   $��
475,32,0,0q�6�   $��14(�6�   #��[ 6�   �� 5H      -   5        $ TbIcd10��5H   "   $
��Left=�63   $	��188��6N   $
 Wrap=�6Z   $ 	Kod ICD10��6n   $��	35,88,0,0q�6�   $	��Top=�6�   $��14(�6�   #��[ 6�   �� 5I      -   5        $ 
TbNbOfDays��5I   "   $
��Left=�66   $	��191��6Q   $��
244,88,0,0q�6]   $
 Wrap=�6q   $ Liczba wizyt��6�   $	��Top=�6�   $��14(�6�   #��[ 6�   �� 5K      -   5         ��Name$ 	CbPatient��5K   #   $ Pacjent��66   $��30��6_   $
��Left=�6k   $��	35,41,0,0q�6�   $	��Top=�6�   $	��400��6�   $��14(�6�   �� 5L      -   5        $ BtAddReferral��5L   !   $��Dodaj��68   $	��200��6H   $��Right=�6T   $��	0,42,45,0q�6p   $	��Top=�6�   $��30��6�   �� 5M      -   5        $ BtDeleteReferral��5M   !   $��Usuń��6;   $��Right=�6J   $��	0,77,45,0q�6f   $	��Top=�6y   $	��200��6�   $��30��6�   �� 5N      -   5        $ BtSearchReferral��5N   !   $��Wyszukaj��6;   $��Right=�6N   $��
0,112,45,0q�6j   $	��Top=�6~   $	��200��6�   $��30��6�   �� 5O      -   5        $ BtShowAllReferrals��5O   !   $��Pokaż wszystkie��6=   $��Right=�6W   $��
0,147,45,0q�6s   $	��Top=�6�   $	��200��6�   $��30��6�   (  "System.Windows.Controls.DatePicker  5P      -   5           Name$  DpDateReferral��5P   %   $
��Left=�6=   $��30��6X   $��475,150,0,0q�6d   $ Data wystawienia��6z   $	��Top=�6�   $	��400��6�   $��14(�6�   �� 5Q      -   5        $ TbDoctor��5Q   "   $
��Left=�64   $	��Top=�6O   $	��400��6g   $
 Wrap=�6s   $ Lekarz kierujący��6�   $��
35,141,0,0q�6�   $��14(�6�   #��[ 6�   �� 5R      -    5        $ TbTreatments��5R   "   $
��Left=�68   $	��400��6S   $ WrapWithOverflow=�6_   ! �� AcceptsReturn! . $ Zlecone zabiegi��6�   $��
475,86,0,0q�6�   $	��Top=�6�   $��14(�6�   #��[ 6�   $��42��6:  " �� MinLines$" 3��6F    5T      -!   5        $ referralDataGrid��5T   #    .   . $��10,221,10,9.8q�6�   $ VisibleWhenSelected=�6�    .  ��6x   ��  5U        5W   "   -"   5        idPatientColumn��$ Pacjent��5W   j   $	 210
 6{    .  6N   �� *	Patient+6�     5X   "   -#   5        diagnosisColumn��$ Diagnoza��5X   �   $	 150Q�6�   $ *
 6�    6N   �� *	Diagnosis+$ TwoWay=�$ 	LostFocus=�6�     5Y   "   -$   5        icd10Column��$ ICD10��5Y   �   $ 80
 6�    6J   �� *Icd10+$ TwoWay=�$ 	LostFocus=�6�     5Z   "   -%   5        treatmentColumn��$	 150Q�5Z   �   $ Zlecone zabiegi��6�   $ *
 6�    6N   �� *
Treatments+$ TwoWay=�$ 	LostFocus=�6�     5[   "   -&   5        doctorColumn��$ Lekarz kierujący��5[   �   $	 150
 6�    6K   �� *Doctor+$ TwoWay=�$ 	LostFocus=�6�     5\   "   -'   5        nbOfDaysColumn��$ Liczba wizyt��5\   �   $	 100
 6�    6M   �� *
NbOfDays+$ TwoWay=�$ 	LostFocus=�6�   4  .System.Windows.Controls.DataGridTemplateColumn  5]   "   -(   5        dateReferralColumn��$ Data skierowania��5]   U   $	 130
 6o   #   CellTemplate# 5^   &   �� 5_   *   .R�5`   .     $   SelectedDate$ 69   �� *DateReferral+$ TwoWay=�$ 	LostFocus=�% �� NotifyOnValidationError% . & �� ValidatesOnExceptions& . 5a   +   5c   #     5d   "   -)   5        dateSavedColumn��$ Data zapisu��5d   R   $	 120
 6g   # 5e   &   �� 5f   *   .R�5g   .     $ 69   �� *	DateSaved+$ TwoWay=�$ 	LostFocus=�% . & . 5h   +   5j   #   4  .System.Windows.Controls.DataGridCheckBoxColumn  5k   "   -*   5        referralCompletedColumn��$ Skier. zrealizowane��5k   �   $	 150
 6�    6Z   �� *ReferralCompleted+$ TwoWay=�$ 	LostFocus=�6�   5m      5o      5p      �� 5q      $��WIZYTY��6   .��5r      � # [ 6   .+�5s      �� -+   5        $ CbVisitTime��5s   #   $ Godzina wizyty��69   $
��Left=�6i   $��
10,145,0,0q�6�   $	��Top=�6�   $	��278��6�   $��30��6�   $��14(�6�   �� 5t      -,   5        $ 
CbPatient2��5t   #   $ Pacjent��67   $
��Left=�6a   $��	10,11,0,0q�6|   $	��Top=�6�   $	��278��6�   $��30��6�   $��14(�6  �� 5u      --   5        $ 
CbReferral��5u   #   $ Skierowanie��67   $
��Left=�6e   $��	10,56,0,0q�6�   $	��Top=�6�   $	��278��6�   $��30��6�   $��14(�6�   �� 5v      -.   5        $ CbPhysiotherapist��5v   #   $ Fizjoterapeuta��6>   $
��Left=�6o   $��
10,101,0,0q�6�   $	��Top=�6�   $	��278��6�   $��30��6�   $��14(�6�   �� 5w      -/   5        ' ��Name$' LabTodayVisits��5w       $��Dzisiejsze wizyty:��68   $��15(�6V   $
��Bold"�6d   $��306,10,436,200.8q�6v   &   System.Windows.Controls.Calendar  5z      -0   5        (  Name$( CalendarVisit��5z   #   )   SelectionMode$) MultipleRange=�6:   $��10,180,-10,-179.8q�6x     5{      -1   5        $ visitDataGrid��5{   #    .   . $��320,68,10,10.2q�6�   $ VisibleWhenSelected=�6�   *   CanUserResizeRows* .   .  ��6u   ��  5|        5~   "   -2   5        idPhysiotherapistColumn��$ Fizjoterapeuta��5~   z   $	 160
 6�    .  6V   �� *Physiotherapist+6�     5   "   -3   5        idReferralColumn1��$ Pacjent/Skierowanie��5   m   $	 100Q�6�   $ *
 6�    .  6P   �� *
Referral+6�     5�   "   -4   5        visitDateColumn��$ Data wizyty��5�   R   $	 110
 6g   # 5�   &   �� 5�   *   .R�5�   .     $ 69   �� *	VisitDate+$ TwoWay=�% . & . 5�   +   5�   #     5�   "   -5   5        visitTimeColumn��$ Godzina wizyty��5�   �   $ SizeToHeader
 6�    6N   �� *	VisitTime+$ TwoWay=�$ 	LostFocus=�6�     5�   "   -6   5        dateSavedColumn1��$ Data zapisu��5�   S   $	 110
 6h   # 5�   &   �� 5�   *   .R�5�   .     $ 69   �� *	DateSaved+$ TwoWay=�% . & . 5�   +   5�   #     5�   "   -7   5        visitCompletedColumn��$ Wizyta zrealizowana��5�   �   $ SizeToHeader
 6�    6W   �� *VisitCompleted+$ TwoWay=�$ 	LostFocus=�6�     5�   "   -8   5        visitSettledColumn��$ Wizyta rozliczona��5�   �   $ SizeToHeader
 6�    6U   �� *VisitSettled+$ TwoWay=�$ 	LostFocus=�6�   5�      	� 5�      -9   5        + 	�Name$+ RbAdding��5�   &   $��Tryb dodawania��68   $��Right=�6Q   $��0,7,46,0q�6m   $	��Top=�6   6�   	� 5�      -:   5        $+ RbSearching��5�   &   $��Tryb wyszukiwania��6;   $��Right=�6W   $��	0,30,32,0q�6s   $	��Top=�6�   6�   �� 5�      -;   5        $ 
BtAddVisit��5�   !   $��Dodaj��65   $	��278��6E   $
��Left=�6Q   $��
10,564,0,0q�6l   $	��Top=�6�   6�   �� 5�      -<   5        $ BtDeleteVisit��5�   !   $��Usuń��68   $
��Left=�6G   $��
10,601,0,0q�6b   $	��Top=�6v   $	��278��6�   6�   �� 5�      -=   5        $ BtSearchVisit��5�   !   $��Wyszukaj��68   $
��Left=�6K   $��
10,638,0,0q�6f   $	��Top=�6z   $	��278��6�   6�   5�      5�      �� 5�      ->   5        $
 TiPhysio��5�      $��FIZJOTERAPEUCI��6,   .��5�      � # [ 6   .+�5�      �� -?   5        $ TbPhysioName��5�   "   $
��Left=�68   $��	35,32,0,0q�6S   $
 Wrap=�6f   $ Imię��6z   $	��Top=�6�   $	��400��6�   #��[ 6�   $��14(�6�   �� 5�      -@   5        $ TbPhysioSurname��5�   "   $
��Left=�6;   $��
480,32,0,0q�6V   $
 Wrap=�6j   $ Nazwisko��6~   $	��Top=�6�   $	��400��6�   #��[ 6�   $��14(�6  �� 5�      -A   5        $ TbPhysioAdress��5�   "   $
��Left=�6:   $��
35,141,0,0q�6U   $
 Wrap=�6i   $ Adres��6}   $	��Top=�6�   $	��400��6�   #��[ 6�   $��14(�6  �� 5�      -B   5        $ TbPhysioPhone��5�   "   $
��Left=�69   $��
480,90,0,0q�6T   $
 Wrap=�6h   $ Telefon��6|   $	��Top=�6�   $	��400��6�   #��[ 6�   $��14(�6  �� 5�      -C   5        $ TbPhysioEmail��5�   "   $
��Left=�69   $��480,141,0,0q�6T   $
 Wrap=�6i   $ Email��6}   $	��Top=�6�   $	��400��6�   #��[ 6�   $��14(�6  �� 5�      -D   5        $ TbPhysioNpwz��5�   "   $
��Left=�68   $��	35,90,0,0q�6S   $
 Wrap=�6f   $
 NPWZ��6z   $	��Top=�6�   $	��400��6�   #��[ 6�   $��14(�6�   �� 5�      -E   5        $ BtAddPhysio��5�   !   $��Dodaj��66   $��Right=�6F   $��	0,42,45,0q�6b   $	��Top=�6u   $	��200��6�   $��30��6�   6�   �� 5�      -F   5        $ BtSearchPhysio��5�   !   $��Wyszukaj��69   $��Right=�6L   $��
0,112,45,0q�6h   $	��Top=�6|   $	��200��6�   $��30��6�   6�   �� 5�      -G   5        $ BtDeletePhysio��5�   !   $��Usuń��69   $��Right=�6H   $��	0,77,45,0q�6d   $	��Top=�6w   $	��200��6�   $��30��6�   6�   �� 5�      -H   5        $ BtViewAllPhysio��5�   !   $��Pokaż wszystkich��6:   $��Right=�6U   $��
0,147,45,0q�6q   $	��Top=�6�   $	��200��6�   $��30��6�   6�     5�      -I   5        $ physiotherapistDataGrid��5�   #    .   . $��10,221,10,10.8q�6�   $ VisibleWhenSelected=�6�    .  ��6   �� ��6�   �� , �� Path$, ActualWidth�- �� ElementName$
- grid�� 5�        5�   "   -J   5        nameColumn1��$ Imię��5�   �   $	 200
 6�    6J   �� *Name+$ TwoWay=�$ 	LostFocus=�6�     5�   "   -K   5        surnameColumn1��$ Nazwisko��5�   �   $	 200
 6�    6M   �� *	Surname+$ TwoWay=�$ 	LostFocus=�6�     5�   "   -L   5        adressColumn1��$ Adres��5�   �   $	 100Q�6�   $ *
 6�    6L   �� *Adress+$ TwoWay=�$ 	LostFocus=�6�     5�   "   -M   5        emailColumn��$ Email��5�   �   $	 200
 6�    6J   �� *Email+$ TwoWay=�$ 	LostFocus=�6�     5�   "   -N   5        
npwzColumn��$
 NPWZ��5�   �   $	 150
 6�    6I   �� *Npwz+$ TwoWay=�$ 	LostFocus=�6�     5�   "   -O   5        phoneColumn1��$ Telefon��5�   �   $	 150
 6�    6K   �� *Phone+$ TwoWay=�$ 	LostFocus=�6�   5�      5�      5�      �� 5�      -P   5        $
 TiReport��5�      $��RAPORTY��6,   .��5�      � # [ 6   .+�5�      �� -Q   5        $ CbReportType��5�   #   $ Typ raportu:��69   $
��Left=�6g   $��	10,24,0,0q�6�   $	��Top=�6�   $	��288��6�   �� 5�      -R   5        $ BtGenerateReport��5�   !   $��Generuj raport��6;   $
��Left=�6T   $��
10,433,0,0q�6o   $	��Top=�6�   $	��278��6�   $��30��6�   6�   �� 5�      $��Lista raportów:��6    $
��Left=�6:   $��
10,477,0,0q�6U   $	��Top=�6i   $	��242��6�     5�      -S   5        $( CalendarReport��5�   #   $��10,52,-10,-51.8q�6\     5�      -T   5        $ reportDataGrid��5�   #    .   . $
��Left=�6v   $��10,503,0,10.2q�6�   $ VisibleWhenSelected=�6�    .  $	��278��69  ��6�   ��  5�        5�   "   -U   5        idReportColumn��$ 
Nr Raportu��5�   j    . $ SizeToHeader
 6�    6M   �� *
IdReport+6�     5�   "   -V   5        nameColumn2��$ Nazwa��5�   �   $	 100Q�6�   $ *
 6�    6J   �� *Name+$ TwoWay=�$ 	LostFocus=�6�   5�      � 5�      .+�5�      �� -W   5        . ��Name$. visitsFromReport��5�   '   $
��Left=�6A   $	��799��6\   $��383,62,0,-112.2q�6i   $	��Top=�6�   $	��795��6�   $��Visible=�6�   ��.  / �� View/ 5�   "   �� 5�   &   .P�5�   *   �� 5�   '   5�      5�      �� 5�      -X   5        $' LbPreviewReport��5�       $+��%Wybierz raport aby zobaczyć podgląd��69   $
��Left=�6g   $��
389,31,0,0q�6�   $	��Top=�6�   $	��310��6�   �� 5�      -Y   5        $ BtPrintReport��5�   !   $��Drukuj raport��68   $
��Left=�6P   $��
791,20,0,0q�6k   $	��Top=�6   $	��201��6�   6�   5�      5�      5�      5�      5�      5�      