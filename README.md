# API_Conta
Api para gerenciar Conta com EFC


1 - Clonar branch
2 - Abrir Solution
3 - Abrir Console do Gerenciador de Pacotes
4 - Executar o script para tornar o Entity Framework Global: dotnet tool install --global dotnet-ef
5 - Executar o script para testar se o passo anterior está ok: dotnet ef
6 - Executar o script caso sua conexão seja local: A - update-database  B - dotnet ef database update

Obs: Ajustar sua string de conexão no arquivo appsettings.json, ConnectionStrings --> DefaultConnection (Customizar)
