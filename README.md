# vectorTeste
Projeto para processo seletivo vector

Projeto realizado  com visual studio 2019/ dotnet core 5.0.
Banco de dados não relacional MongoDb (banco está publico na nuvem basta rodar o projeto)

Para utilizar a interface e requisições seguir os passos :
1- Caso não tenha usuario e senha , utilizar metodo post CadastrarUser
2-Com cadastro feito precisa autenticar no post login 
3-Será retornado o token
4-O token precisa ser passado como exempl
Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2NTIxOTU1MzAsImlzcyI6ImVtaXNzb3IiLCJhdWQiOiJyZWNlcHRvciJ9.GyrN2dcUKJUila5YC8SfeLyb06u_RqlFy62SaPImcHQ
5-Após passar o token os demais endpoints serão liberados 

Será possível buscar todos os emails ou por id. Caso a infomação exista no mongo será buscado por ele , caso não exista será buscado na API https://6064ac2bf09197001778660d.mockapi.io/api/test-api.

O mongo está configurado para apagar os dados em 24hrs ou seja,  a primeira pesquisa verifica se existe no mongo , caso exista retorna o valor, caso não exista, retorna da api moc e insere o valor no mongo para proxima pesquisa. 
