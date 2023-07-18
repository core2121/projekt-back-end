# back-end

# Inicjalny klient Blazor
# 1. w pliku appsettings.json w sekcji "DefaultConnection": "Server={nazwa-mojego-serwera-sql};..." nalezy wpisac 
#	odpowiednia nazwe lokalnego hosta oraz instancji MSSQL
# 2. w oknie Package Manager Console uruchomic komnende Update-Database, dieki ktorej utworzona zostanie 
#	inicjalna baza wraz z tabelami dla autentykacji uzytkownikow

# Opis aplikacji
# Aplikacja jest przykladowym rozwiazaniem aplikacji internetowej z uzyciem technologii Blazor Server jako 
# single-page application. Aplikacja BlazorWebApp jest czescia architektury Onion w tym projekcie. Zgodnie z rachitektura 
# Onion zostaly utworzone warstwy bedace indywidualnymi projektami (class library):
# OA.Data - zawierajacy definicje podstawowych typow danych stanowiaych domene projektu
# OA.Repository - design pattern Repository odpowiedzialny za operacje CRUD na bazie danych
# OA.Service - zawiera definicje interfejsow i klas dla operacji na poszczegolnych klasach z projektu OA.Data
# WebApi - to samohostujaca sie aplikacja internetowa, korzystajaca z kontrolera UserController, dziedziczacym po APIController
#	pozwalajacym udostepnic akcje wywolywane przez zadania http requests. Dla celow testowych WebApi zawiera skonfigurowanego 
#	swaggera ktory pozwala na testowanie odpowiednich zadan

# Aplikacja BlazorWebApp zawiera tylko podstawowa logike biznesowa (w czesci bloków kodu c#) natomiast wszystkie operacje na 
# obiektach danych odbywaja sie w warstwie OA.Service

# konfiguracja serwisow oraz repozytorium zostala zaimplementowana przy uzyciu mechanizmu Dependency Injection ktory sam 
# z siebie odpowiedzialny jest za utworzenie obiektow/instancji klas i wstrzykniecie ich do aplikacji (wraz z danymi konfiguracyjnymi)

# Aplikacja BlazorWebApp pozwala na:
# - rejestracje, edytowanie oraz logowanie uzytkownikow
# - zdefiniowane sa dwie role uzytkownikow: admin oraz user
# - dodatkowo zdefiniowane sa przywileje uzytkownika, dla celow testowych; moze widziec wszystkie widoki oraz nie moze widziec 
#	historii swoich logowan

# WebApi pozwala na:
# - listowanie wszystkich uzytkownikow
# - resjetracje nowych uzytkownikow

# Uruchomienie aplikacji 
# BlazorWebApp nalezy opublikowac na docelowym serwerze jedna z metod; Azure, Docker Container Registry, Folder, FTP/FTPS, Web server IIS. 
#	Aplikacja po opublikowaniu uruchomi sie w oknie przegladarki i dostepna bedzie loklanie pod adresem http://localhost:port gdzie 
#	port konfiguruje sie przy uzyciu IIS managera
# WebApi nalezy opbulikowac na docelowm serwerze jedna z powyzszych metod. Po upublikownaiu webapi bedzie dostepne pod 
#	adresem http://localhost:port gdzie #	port konfiguruje sie przy uzyciu IIS managera

# Konta testowe
# aplikacja BlazorWebApp posiada pre rejestrowane konta testowe:
# username: admin, pass: root
# username: first, psss: root
# username: second, pass: root
# username: third, pass: root
