﻿Namespace Language
    Public Class DE
        Public Const Button_Cancel As String = "&Abbrechen"
        Public Const Button_New As String = "&Neu"
        Public Const Button_OK As String = "&OK"
        Public Const Button_Close As String = "&Schließen"
        Public Const Button_Scan As String = "&Scannnen"
        Public Const Button_Stop As String = "&Stop"
        Public Const Button_Import As String = "&Importieren"

        Public Const Props_Name As String = "Name"
        Public Const Descr_Name As String = "Dies ist der Name der im Verbindungs Baum angezeigt wird."
        Public Const Props_Description As String = "Beschreibung"
        Public Const Descr_Description As String = "Hier kann eine Beschreibung für den Host hinterlegt werden."
        Public Const Props_Icon As String = "Icon"
        Public Const Descr_Icon As String = "Das ausgewählte Icon wird bei Verbindung zum Host im Tab angezeigt."
        Public Const Props_Panel As String = "Panel"
        Public Const Descr_Panel As String = "Setzt das Panel in dem die Verbindung geöffnet wird."
        Public Const Props_HostnameIP As String = "Hostname/IP"
        Public Const Descr_HostnameIP As String = "Der Hostname od. die IP zu der eine Verbinung aufgebaut werden soll."
        Public Const Props_Username As String = "Benutzername"
        Public Const Descr_Username As String = "Geben sie hier ihren Benutzernamen ein."
        Public Const Props_Password As String = "Passwort"
        Public Const Descr_Password As String = "Geben sie hier ihr Passwort ein."
        Public Const Props_Domain As String = "Domäne"
        Public Const Descr_Domain As String = "Geben sie hier ihre Domäne ein."
        Public Const Props_Protocol As String = "Protokoll"
        Public Const Descr_Protocol As String = "Wählen sie das Protokoll das verwendet werden soll um eine Verbindung aufzubauen."
        Public Const Props_Port As String = "Port"
        Public Const Descr_Port As String = "Geben sie den Port ein auf dem das Protokoll auf Verbindungen wartet."
        Public Const Props_PuttySession As String = "Putty Session"
        Public Const Descr_PuttySession As String = "Wählen sie eine PuTTY session die bei Verbindung verwendet werden soll."
        Public Const Props_EncryrptionStrength As String = "Verschlüsselungsstärke"
        Public Const Descr_EncryptionStrength As String = "Wählen sie die Verschlüsselungsstärke des Remote Hosts."
        Public Const Props_AuthenticationLevel As String = "Serverauthentifizierung"
        Public Const Descr_AuthenticationLevel As String = "Wählen sie welche Authentifizierungs-Variante verwendet wird."
        Public Const Props_UseConsoleSession As String = "Verwende Console Session"
        Public Const Descr_UseConsoleSession As String = "Zur Console Session des Remote Hosts verbinden."
        Public Const Props_Resolution As String = "Auflösung"
        Public Const Descr_Resolution As String = "Wählen sie die Auflösung in welcher der Host geöffnet werden soll."
        Public Const Props_Colors As String = "Farben"
        Public Const Descr_Colors As String = "Wählen sie die Farb Qualität."
        Public Const Props_CacheBitmaps As String = "Bitmaps zwischenspeichern"
        Public Const Descr_CacheBitmaps As String = "Wählen sie ob Bitmap caching zum Einsatz kommen soll."
        Public Const Props_DisplayWallpaper As String = "Hintergrundbild anzeigen"
        Public Const Descr_DisplayWallpaper As String = "Wählen sie ob Hintergrundbilder am Remote Host angezeigt werden sollen."
        Public Const Props_DisplayThemes As String = "Themen anzeigen"
        Public Const Descr_DisplayThemes As String = "Wählen sie ob Themen am Remote Host angezeigt werden sollen."
        Public Const Props_RedKeyCombinations As String = "Tastenkombinationen"
        Public Const Descr_RedKeyCombinations As String = "Wählen sie ob Tastenkombinationen wie z.B. Alt+Tab auf den Remote Host umgeleitet werden sollen."
        Public Const Props_RedDiskDrives As String = "Festplatten"
        Public Const Descr_RedDiskDrives As String = "Wählen sie ob ihre lokalen Festplatten am Remote Host angezeigt werden sollen."
        Public Const Props_RedPrinters As String = "Drucker"
        Public Const Descr_RedPrinters As String = "Wählen sie ob ihre lokalen Drucker am Remote Host angezeigt werden sollen."
        Public Const Props_RedPorts As String = "Ports"
        Public Const Descr_RedPorts As String = "Wählen sie ob ihre lokalen Ports wie z.B. COM, Parallel auf dem Remote Host angezeigt werden sollen."
        Public Const Props_RedSmartCards As String = "Smart Cards"
        Public Const Descr_RedSmartCards As String = "Wählen sie ob ihre lokalen Smart Cards auf dem Remote Host zur Verfügung stehen sollen."
        Public Const Props_RedSounds As String = "Töne"
        Public Const Descr_RedSound As String = "Wählen sie wie Töne auf dem Remote Host wiedergegeben werden sollen."
        Public Const Props_PreExtApp As String = "Pre Ext. App"
        Public Const Descr_PreExtApp As String = "Wählen sie eine Ext. App die gestartet werden soll bevor die Verbindung zum Remote Host aufgebaut wurde."
        Public Const Props_PostExtApp As String = "Post Ext. App"
        Public Const Descr_PostExtApp As String = "Wählen sie eine Ext. App die gestartet werden soll nachdem die Verbindung zum Remote Host getrennt wurde."
        Public Const Props_Compression As String = "Kompremierung"
        Public Const Descr_Compression As String = "Wählen sie die Kompressionsrate die verwendet werden soll."
        Public Const Props_Encoding As String = "Codierung"
        Public Const Descr_Encoding As String = "Wählen sie die Codierung die verwendet werden soll."
        Public Const Props_AuthMode As String = "Auth. Modus"
        Public Const Descr_AuthMode As String = "Wählen sie wie sie sich am VNC server authentifizieren wollen."
        Public Const Props_ProxyType As String = "Proxy Typ"
        Public Const Descr_ProxyType As String = "Wenn sie einen Proxy verwenden um auf den Remote Host zugreifen zu können, wählen sie hier den Typ."
        Public Const Props_ProxyIP As String = "Proxy IP"
        Public Const Descr_ProxyIP As String = "Geben sie die IP des Proxy Servers ein."
        Public Const Props_ProxyPort As String = "Proxy Port"
        Public Const Descr_ProxyPort As String = "Geben sie den Port des Proxy Servers ein."
        Public Const Props_ProxyUsername As String = "Proxy Benutzername"
        Public Const Descr_ProxyUsername As String = "Geben sie ihren Benutzernamen ein."
        Public Const Props_ProxyPassword As String = "Proxy Passwort"
        Public Const Descr_ProxyPassword As String = "Geben sie ihr Password ein."
        Public Const Props_SmartSizeMode As String = "SmartSize Modus"
        Public Const Descr_SmartSizeMode As String = "Wählen sie den SmartSize Modus der verwendet werden soll."
        Public Const Props_ViewOnly As String = "View-Only"
        Public Const Descr_ViewOnly As String = "Wählen sie ob sie eine View-Only Verbindung aufbauen wollen."
        Public Const Props_RenderingEngine As String = "Rendering Engine"
        Public Const Descr_RenderingEngine As String = "Wählen sie eine der Rendering Engines die verwendet wird um html darzustellen."
        Public Const Props_MacAddress As String = "MAC Adresse"
        Public Const Descr_MacAddress As String = "Geben sie die MAC Adresse des Remote Hosts ein (kann für Ext. Apps verwendet werden)."
        Public Const Props_UserField As String = "Benutzer Feld"
        Public Const Descr_UserField As String = "Dieses Feld ist frei beschreibbar."

        Public Const Props_General As String = "Generell"
        Public Const Props_Display As String = "Anzeige"
        Public Const Props_Connection As String = "Verbindung"
        Public Const Props_Appearance As String = "Aussehen"
        Public Const Props_Redirect As String = "Umleitung"
        Public Const Props_Misc As String = "Verschiedenes"
        Public Const Props_InheritEverything As String = "Alles vererben"
        Public Const Props_ExtApp As String = "Ext. App"
        Public Const Descr_ExtApp As String = "Wählen sie die Ext. App die gestartet werden soll."


        Public Const Menu_About As String = "Über"
        Public Const Menu_AddConnectionPanel As String = "Verbindungs Panel hinzufügen"
        Public Const Menu_BugReport As String = "Bug Report"
        Public Const Menu_Config As String = "Konfiguration"
        Public Const Menu_ConnectionPanels As String = "Verbindungs Panels"
        Public Const Menu_Connections As String = "Verbindungen"
        Public Const Menu_ConnectionsConfig As String = "Verbindungen && Konfiguration"
        Public Const Menu_Donate As String = "Spenden"
        Public Const Menu_ErrorsAndInfos As String = "Fehler und Infos"
        Public Const Menu_ErrorsInfos As String = "Fehler && Infos"
        Public Const Menu_Exit As String = "Beenden"
        Public Const Menu_ExternalApplications As String = "Externe Programme"
        Public Const Menu_ExternalApplicationsToolbar As String = "Externe Programme Symbolleiste"
        Public Const Menu_File As String = "&Datei"
        Public Const Menu_FullScreenKioskMode As String = "Vollbild (Kiosk Modus)"
        Public Const Menu_Help As String = "Hilfe"
        Public Const Menu_Info As String = "&Info"
        Public Const Menu_JumpTo As String = "Springe zu"
        Public Const Menu_NewConnections As String = "Neu Verbindungen"
        Public Const Menu_OpenConnections As String = "Verbindungen öffnen"
        Public Const Menu_Options As String = "Optionen"
        Public Const Menu_PortScan As String = "Port Scan"
        Public Const Menu_QuickyToolbar As String = "Quicky Symbolleiste"
        Public Const Menu_SaveConnections As String = "Verbindungen speichern"
        Public Const Menu_SaveConnectionsAs As String = "Verbindungen speichern unter"
        Public Const Menu_ScreenshotManager As String = "Screenshot Manager"
        Public Const Menu_Sessions As String = "Sessions"
        Public Const Menu_SessionsScreenshots As String = "Sessions && Screenshots"
        Public Const Menu_SSHFileTransfer As String = "SSH Datei Transfer"
        Public Const Menu_Tools As String = "E&xtras"
        Public Const Menu_Update As String = "Update"
        Public Const Menu_View As String = "&Ansicht"
        Public Const Menu_Website As String = "Webseite"

        Public Const Toolbar_Play As String = "Los!"
        Public Const Toolbar_Quicky As String = "&Quicky:"
        Public Const Toolbar_ShowText As String = "Text anzeigen"

        Public Const Password As String = "Passwort:"
        Public Const Security As String = "Sicherheit"
        Public Const SelectAPanel As String = "Wähle ein Panel aus der Liste oder klicke auf Neu um ein neues zu erstellen. Klicke OK um fortzufahren."
        Public Const SelectPanel As String = "Wähle Panel"
        Public Const Status As String = "Status"
        Public Const Verify As String = "Überprüfen:"
        Public Const Aspect As String = "Aspekt"
        Public Const Free As String = "Frei"
        Public Const NoSmartSize As String = "Kein SmartSize"
        Public Const Normal As String = "Normal"
        Public Const None As String = "Kein"
        Public Const NoCompression As String = "Keine Kompression"
        Public Const Connecting As String = "Verbinde..."
        Public Const Disconnected As String = "Getrennt"
        Public Const RDP256Colors As String = "256 Farben"
        Public Const RDPSoundBringToThisComputer As String = "Auf diesem Computer wiedergeben"
        Public Const RDPSoundLeaveAtRemoteComputer As String = "Auf dem Remotecomputer wiedergeben"
        Public Const RDPSoundDoNotPlay As String = "Nicht wiedergeben"
        Public Const RDPFitToPanel As String = "An das Panel anpassen"
        Public Const RDPSmartSize As String = "Smart Size"
        Public Const Active As String = "Aktiv"
        Public Const Inactive As String = "Inaktiv"
        Public Const Fullscreen As String = "Vollbild"
        Public Const Information As String = "Information"
        Public Const Warning As String = "Warnung"
        Public Const Error_ As String = "Fehler"
        Public Const PasswordProtect As String = "Passwortschützen"
        Public Const AutomaticReconnect As String = "Automatisches wiederverbinden"
        Public Const ServerStatus As String = "Server Status:"
        Public Const ReconnectWhenReady As String = "Verbinden wenn bereit"
        Public Const Connections As String = "Verbindungen"
        Public Const Files As String = "Dateien"
        Public Const All As String = "Alle"
        Public Const Yes As String = "Ja"
        Public Const No As String = "Nein"
        Public Const New_ As String = "Neu"
        Public Const Connection As String = "Verbindung"
        Public Const Folder As String = "Ordner"
        Public Const Root As String = "Wurzel"
        Public Const SureToDeleteItem As String = "Sind sie sicher dass sie dieses Objekt löschen möchten?"
        Public Const License As String = "Lizenz"
        Public Const About As String = "Über"
        Public Const ChangeLog As String = "Änderungen:"
        Public Const ReleasedUnderGPL As String = "Unter der GNU General Public License (GPL) veröffentlicht"
        Public Const SomeIconsBy As String = "Einige Icons von"
        Public Const Change As String = "Ändern"
        Public Const Inheritance As String = "Vererbung"
        Public Const Default_ As String = "Standard"
        Public Const Properties As String = "Eigenschaften"
        Public Const SmartSize As String = "SmartSize"
        Public Const Screenshot As String = "Screenshot"
        Public Const StartChat As String = "Chat starten"
        Public Const TransferFile As String = "Datei übertragen"
        Public Const RefreshScreen As String = "Anzeige aktualisieren"
        Public Const SendSpecialKeys As String = "Tastenkombination senden"
        Public Const RenameTab As String = "Tab umbenennen"
        Public Const DuplicateTab As String = "Tab klonen"
        Public Const Reconnect As String = "Wiederverbinden"
        Public Const Disconnect As String = "Trennen"
        Public Const Message As String = "Nachricht"
        Public Const Copy As String = "Kopieren"
        Public Const Paste As String = "Einfügen"
        Public Const Delete As String = "Löschen"
        Public Const Filename As String = "Dateiname"
        Public Const Arguments As String = "Parameter"
        Public Const WaitForExit As String = "Auf Beendigung warten"
        Public Const Add As String = "Hinzufügen"
        Public Const Remove As String = "Entfernen"
        Public Const Start As String = "Starten"
        Public Const Application As String = "Applikation"
        Public Const Editor As String = "Editor"
        Public Const Browse As String = "Öffnen..."
        Public Const DisplayName As String = Props_Display & " " & Props_Name
        Public Const ReallyDeleteSelectedApplications As String = "Sind sie sicher dass sie die ausgewählte(n) Applikation(en) löschen möchten?"

        Public Const Key_Control As String = "Strg"
        Public Const Key_Alt As String = "Alt"
        Public Const Key_Del As String = "Entf"
        Public Const Key_Esc As String = "Esc"

        Public Const Advanced As String = "Erweitert"
        Public Const TestProxy As String = "Test Proxy"
        Public Const Seconds As String = "Sekunden"
        Public Const MaxPuttyWaitTime As String = "Maximale Zeit die auf PuTTY und integrierte Ext. Apps gewartet wird"
        Public Const AutomaticallyTryToReconnect As String = "Automatisch versuchen zu verbinden wenn Verbindung getrennt wird (nur RDP && ICA)"
        Public Const Address As String = "Addresse"
        Public Const UseAuthentication As String = "Benutze Authentifizierung"
        Public Const UseProxyForAutomaticUpdates As String = "Proxy für automatische Updates verwenden"
        Public Const ToConfigurePuttySessions As String = "Hier klicken um PuTTY Sessions zu konfigurieren:"
        Public Const LaunchPutty As String = "Starte PuTTY"
        Public Const UseCustomPuttyPath As String = "Eigener PuTTY Pfad:"
        Public Const AutomaticallyGetSessionInfo As String = "Automatisch Session Informationen einholen"
        Public Const WriteLogFile As String = "Log File schreiben (mRemoteNG.log)"
        Public Const StartupExit As String = "Start/Ende"
        Public Const AllowOnlySingleInstance As String = "Nur eine Instanz zulassen (mRemote Neustart benötigt)"
        Public Const ReconnectAtStartup As String = "Offene Verbindungen speichern und beim nächsten Start wiederverbinden"
        Public Const CheckForUpdatesOnStartup As String = "Beim Start auf Updates prüfen"
        Public Const ConfirmExit As String = "Schließen bestätigen wenn Verbindungen bestehen"
        Public Const SaveConsOnExit As String = "Verbindungen beim Schließen speichern"
        Public Const MinimizeToSysTray As String = "In die System Tray minimieren"
        Public Const ShowFullConsFilePath As String = "Vollen Verbindungsdateipfad im Titel anzeigen"
        Public Const AlwaysShowSysTrayIcon As String = "System Tray Icon immer anzeigen"
        Public Const ShowDescriptionTooltips As String = "Beschreibungs Tooltips in der Verbindungsliste anzeigen"
        Public Const TabsAndPanels As String = "Tabs && Panele"
        Public Const ShowProtocolOnTabs As String = "Protokoll im Tab Titel anzeigen"
        Public Const ShowLogonInfoOnTabs As String = "Anmeldeinformationen im Tab Titel anzeigen"
        Public Const OpenNewTabRight As String = "Neue Tabs rechts vom momentan selektierten Tab öffnen"
        Public Const AlwaysShowPanelSelection As String = "Panel Auswahl Dialog immer anzeigen"
        Public Const DoubleClickTabClosesIt As String = "Doppelklick schließt Tabs"
        Public Const SetHostnameLikeDisplayName As String = "Beim Anlegen einer neuen Verbindung Hostname wie Anzeige Name setzen"
        Public Const Experimental As String = "Experimentell"
        Public Const UseSQLServer As String = "SQL Server für das Laden && Speichern der Verbindungen verwenden"
        Public Const SQLInfo As String = "Für mehr Infos bitte Hilfeeintrag lesen (Info - Help - Getting started - SQL Configuration)"
        Public Const SQLServer As String = "SQL Server"
        Public Const AutoSaveMins As String = "Minuten (0 = Ausgeschalten)"
        Public Const AutoSaveEvery As String = "Automatisch speichern jede:"
        Public Const TheFollowing As String = "die folgenden"
        Public Const MyCurrentWindowsCreds As String = "meine aktuellen (windows login info)"
        Public Const NoInformation As String = "keine"
        Public Const EmptyUsernamePasswordDomainFields As String = "Bei leeren Benutzername, Passwort oder Domänen Feldern benutze:"
        Public Const SingleClickOnOpenConnectionSwitchesToIt As String = "Ein einzelner Klick auf eine geöffnete Verbindung springt zu dieser"
        Public Const SingleClickOnConnectionOpensIt As String = "Ein einzelner Klick auf eine Verbindung öffnet diese"
        Public Const SwitchToErrorsAndInfos As String = "Öffne das Fehler && Infos Panel bei"
        Public Const Errors As String = "Fehler"
        Public Const Warnings As String = "Warnungen"
        Public Const Informations As String = "Informationen"
        Public Const UseOnlyErrorsAndInfosPanel As String = "Nur Fehler && Infos Panel benutzen (Keine Popups)"
        Public Const Applications As String = "Applikationen"
        Public Const ProxyTestSucceeded As String = "Proxy test erfolgreich!"
        Public Const ProxyTestFailed As String = "Proxy test fehlgeschlagen!"

        Public Const StartIP As String = "Start IP"
        Public Const EndIP As String = "End IP"
        Public Const ProtocolToImport As String = "Zu importierendes Protokoll"
        Public Const OpenPorts As String = "Offene Ports"
        Public Const ClosedPorts As String = "Geschlossene Ports"
        Public Const StartPort As String = "Start Port"
        Public Const EndPort As String = "End Port"
        Public Const QuickConnect As String = "Quick Connect"
        Public Const UncheckProperties As String = "Deaktivieren sie alle Eigenschaften die nicht gespeichert werden sollen."
        Public Const Export As String = "Export"
        Public Const SaveAll As String = "Alle speichern"
        Public Const RemoveAll As String = "Alle entfernen"
        Public Const Save As String = "Speichern"
        Public Const SaveImageFilter As String = "Graphics Interchange Format File (.gif)|*.gif|Joint Photographic Experts Group File (.jpeg)|*.jpeg|Joint Photographic Experts Group File (.jpg)|*.jpg|Portable Network Graphics File (.png)|*.png" ' TODO: Translate
        Public Const Screenshots As String = "Screenshots"
        Public Const Activity As String = "Aktivität"
        Public Const Type As String = "Type"
        Public Const Refresh As String = "Aktualisieren"
        Public Const LogOff As String = "Ausloggen"
        Public Const LocalFile As String = "Lokale Datei"
        Public Const RemoteFile As String = "Remote Datei"
        Public Const User As String = "Benutzer"
        Public Const Host As String = "Host"
        Public Const Transfer As String = "Transfer"
        Public Const AddConnection As String = "Verbindung hinzufügen"
        Public Const AddFolder As String = "Ordner hinzufügen"
        Public Const Connect As String = "Verbinden"
        Public Const ConnectWithOptions As String = "Verbinden (mit Optionen)"
        Public Const ConnectToConsoleSession As String = "Mit der Console Session verbinden"
        Public Const ConnectInFullscreen As String = "Im Vollbild verbinden"
        Public Const ChoosePanelBeforeConnecting As String = "Panel vor Verbindung auswählen"
        Public Const Tools As String = "Extras"
        Public Const ImportExport As String = "Importieren/Exportieren"
        Public Const ExportmRemoteXML As String = "mRemote XML exportieren"
        Public Const ImportmRemoteXML As String = "mRemote XML importieren"
        Public Const ImportAD As String = "Aus Active Directory importieren"
        Public Const ImportRDPFiles As String = "Aus .RDP Datei(en) importieren"
        Public Const ImportPortScan As String = "Von Port Scan importieren"
        Public Const Sort As String = "Sortieren"
        Public Const SortAsc As String = "Aufsteigend (A-Z)"
        Public Const SortDesc As String = "Abfallend (Z-A)"
        Public Const Duplicate As String = "Duplizieren"
        Public Const Rename As String = "Umbenennen"
        Public Const MoveUp As String = "Nach oben"
        Public Const MoveDown As String = "Nach unten"
        Public Const ExpandAllFolders As String = "Alle Ordner erweitern"
        Public Const CollapseAllFolders As String = "Alle Ordner schließen"
        Public Const NewConnection As String = "Neue Verbindung"
        Public Const NewFolder As String = "Neuer Ordner"
        Public Const CheckForUpdate As String = "Auf Update prüfen"
        Public Const DownloadAndInstall As String = "Downloaden && Installieren"
        Public Const AvailableVersion As String = "Verfügbare Version"
        Public Const CurrentVersion As String = "Aktuelle Version"
        Public Const Version As String = "Version"
        Public Const UpdateAvailable As String = "Update verfügbar!"
        Public Const NoUpdateAvailable As String = "Kein Update verfügbar!"
        Public Const UpdateDownloadComplete As String = "Download fertiggestellt!" & vbNewLine & "mRemote wird nun geschlossen und die Installation gestartet."
        Public Const SendTo As String = "Senden an..."
        Public Const Screen As String = "Bildschirm"

        Public Const UnclosedConnectionPanels As String = "Es sind noch geöffnete Verbindungs Panele vorhanden, wollen sie wirklich beenden?"
        Public Const SaveConnectionsFileBeforeOpeningAnother As String = "Wollen sie die aktuelle Verbindungs-Datei speichern bevor eine andere geladen wird?"
        Public Const NewPanel As String = "Neues Panel"
        Public Const PanelName As String = "Panel Name"
        Public Const NewTitle As String = "Neuer Titel"

        Public Const AlwaysConnectEvenIfAuthFails As String = "Immer verbinden, auch wenn Authentifizierung fehlschlägt"
        Public Const DontConnectWhenAuthFails As String = "Keine Verbindung herstellen wenn Authentifizierung fehlschlägt"
        Public Const WarnIfAuthFails As String = "Warnung anzeigen wenn Authentifizierung fehlschlägt"
        Public Const UltraVNCSCListeningPort As String = "UltraVNC SingleClick Port"
        Public Const ListeningForIncomingVNCConnections As String = "Warte auf eingehende VNC Verbindungen auf Port"

        Public Const CheckProperInstallationOfComponentsAtStartup As String = "Überprüfe die Installation aller Komponenten beim Start"
        Public Const XULrunnerPath As String = "XULrunner Pfad"
        Public Const Inherit As String = "Vererbe"

        Public Const ComponentsCheck As String = "Komponenten Check"

        Public Const EncryptCompleteConnectionFile As String = "Connections Datei vollständig verschlüsseln"

        Public Const EmptyPasswordContinue As String = "Wollen sie ohne Passwort fortfahren?"

        'CompCheck
        Public Const CcAlwaysShowScreen As String = "Bei jedem Start anzeigen"
        Public Const CcCheckAgain As String = "Aktualisieren"
        Public Const CcNotInstalledProperly As String = "nicht korrekt installiert"
        Public Const CcCheckSucceeded As String = "Check erfolgreich!"
        Public Const CcCheckFailed As String = "Check fehlgeschlagen!"
        Public Const CcRDPOK As String = "Alle RDP Komponenten wurden gefunden und scheinen korrekt registriert zu sein."
        Public Const CcRDPFailed As String = "Um RDP korrekt betreiben können muss mindestens Remote Desktop Connection (Terminal Services Client) 6.0 installiert sein. Hier können sie die Software herunterladen: http://support.microsoft.com/kb/925876" & vbNewLine & _
                                            "Wenn sie RDP 6.0 bereits installiert haben und der Check noch immer fehlschlägt, versuchen sie die Datei mstscax.dll manuell zu registrieren. Öffnen sie hierzu den Ausführen Dialog (Start - Ausführen) und geben sie Folgendes ein: regsvr32 ""c:\windows\system32\mstscax.dll"" (Wobei c:\ ihr System-Laufwerk ist)." & vbNewLine & _
                                            "Wenn sie noch immer Probleme mit RDP haben, konsultieren sie bitte das mRemote Forum: http://sourceforge.net/forum/forum.php?forum_id=677204"
        Public Const CcVNCOK As String = "Alle VNC Komponenten wurden gefunden und scheinen korrekt registriert zu sein."
        Public Const CcVNCFailed As String = "VNC benötigt die Datei scvncctrl.dll (wird mitgeliefert). Diese muss registriert sein. Wenn sie eines der nicht-Setup Pakete verwenden muss dies manuell durchgeführt werden." & vbNewLine & _
                                            "Öffnen sie hierzu den Ausführen Dialog (Start - Ausführen) und geben sie Folgendes ein: regsvr32 ""c:\Programme\mRemote\scvncctrl.dll"" (Wobei c:\Programme\mRemote\ ihr mRemote Installations-Pfad ist)." & vbNewLine & _
                                            "Wenn sie noch immer Probleme mit VNC haben, konsultieren sie bitte das mRemote Forum: http://sourceforge.net/forum/forum.php?forum_id=677204"
        Public Const CcPuttyOK As String = "PuTTY wurde gefunden und scheint betriebsbereit zu sein."
        Public Const CcPuttyFailed As String = "Die Protokolle, SSH, Telnet, Rlogin und RAW benötigen PuTTY. PuTTY wird in allen mRemote Paketen mitgeliefert und befindet sich im Installations-Pfad." & vbNewLine & _
                                            "Bitte versichern sie sich dass sich die Datei Putty.exe in ihrem mRemote Installations-Pfad befindet (Standard: c:\Programme\mRemote\) oder dass sie einen korrekten Pfad in den Optionen (Extras - Optionen - Erweitert - Eigener PuTTY Pfad) angegeben haben."
        Public Const CcICAOK As String = "Alle ICA Komponenten wurden gefunden und scheinen korrekt registriert zu sein."
        Public Const CcICAFailed As String = "ICA benötigt eine funktionierende Citrix Presentation Server Client Installation und dass die Datei wfica.ocx korrekt registriert ist. Hier können sie den Client herunterladen: http://www.citrix.com/download/" & vbNewLine & _
                                            "Wenn sie Citrix Presentation Server Client installiert haben und noch immer Probleme haben diesen Check erfolgreich abzuschließen, versuchen sie die Datei wfica.ocx manuell zu registrieren." & vbNewLine & _
                                            "Öffnen sie hierzu den Ausführen Dialog (Start - Ausführen) und geben sie Folgendes ein: regsvr32 ""c:\Programme\Citrix\ICA Client\wfica.ocx"" (Wobei c:\Programme\Citrix\ICA Client\ ihr Citrix Presentation Server Client Installations-Pfad ist)." & vbNewLine & _
                                            "Wenn sie noch immer Probleme mit ICA haben, konsultieren sie bitte das mRemote Forum: http://sourceforge.net/forum/forum.php?forum_id=677204"
        Public Const CcGeckoOK As String = "XULrunner wurde gefunden und scheint korrekt installiert zu sein."
        Public Const CcGeckoFailed As String = "Um die Gecko Rendering Engine benutzen zu können benötigen sie XULrunner 1.8.1.x und einen korrekt eingetragenen Pfad in den Optionen." & vbNewLine & _
                                            "Hier können sie XULrunner 1.8.1.3 herunterladen: ftp://ftp.mozilla.org/pub/xulrunner/releases/1.8.1.3/contrib/win32/" & vbNewLine & _
                                            "Wenn der Download abgeschlossen ist entpacken sie das Paket (Der Speicherort ist dabei ihnen überlassen). Als nächstes öffnen sie (in mRemote) Extras - Optionen - Erweitert und geben sie den korrekten Pfad im XULrunner Feld an." & vbNewLine & _
                                            "Wenn sie noch immer Probleme mit der Gecko Engine in mRemote haben, konsultieren sie bitte das mRemote Forum: http://sourceforge.net/forum/forum.php?forum_id=677204"
        Public Const CcEOLOK As String = "EOLWTSCOM wurde gefunden und scheint korrekt registriert zu sein."
        Public Const CcEOLFailed As String = "Das (RDP) Sessions feature benötigt die Datei eolwtscom.dll. Diese muss korrekt registriert sein." & vbNewLine & _
                                            "Alle mRemote Pakete beinhalten diese Datei, jedoch muss sie, wenn sie eines der nicht-Setup Pakete verwenden manuell registriert werden." & vbNewLine & _
                                            "Öffnen sie hierzu den Ausführen Dialog (Start - Ausführen) und geben sie Folgendes ein: regsvr32 ""c:\Programme\mRemote\eolwtscom.dll"" (Wobei c:\Programme\mRemote\ ihr mRemote Installations-Pfad ist)." & vbNewLine & _
                                            "Wenn sie noch immer Probleme mit dem (RDP) Sessions Feature in mRemote haben, konsultieren sie bitte das mRemote Forum: http://sourceforge.net/forum/forum.php?forum_id=677204"

        Public Const PropertiesWillOnlyBeSavedMRemoteXML As String = "(Diese Einstellungen werden nur gespeichert wenn sie mRemote XML als Dateiformat auswählen!)"
    End Class
End Namespace