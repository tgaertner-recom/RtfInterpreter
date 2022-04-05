# RtfInterpreter

Dieses Projekt kapselt einen RTF-Parsing und -Interpreter-Algorithmus.

Ursprünglich stammt das Projekt (sehr wahrscheinlich) von einem [CodeProject-Artikel](https://www.codeproject.com/Articles/27431/Writing-Your-Own-RTF-Converter). 
Die Inhalte werden an dieser Stelle weder weiterentwickelt noch Support angeboten. 
Für ggf. notwendige Pflege und Wartung unserseits existiert dieses Repository.

## Erstellen

Ein zum Debuggen verwendbarer Stand kann manuell mit der Solution bzw. dem Projekt unterhalb von `src` erstellt werden.

## NuGet

Zum Erstellen des NuGet-Pakets existiert ein PowerShell Skript:
* `nuget/CreatePackage.ps1`

Dieses Skript übersetzt das Projekt mit MSBuild (von VS2019 - der Pfad ggf. anzupassen) und packt das Resultat mittels NuGet.
Vor dem Erzeugen sollte die Version in der nuspec-Datei (`nuget/Itenso.RtfParser.nuspec`) erhöht werden, wenn beabsichtigt wird, einen aktuelleren Stand zu verteilen.

Das Ergebnis-Paket kann auf den NuGet-Server übertragen werden. (http://hazelhen.local.recom.lan:8624/packages)
