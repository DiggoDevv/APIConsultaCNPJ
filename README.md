Desativar SSL certificate verification no Postman ou Insomnia para Api funcionar, pois o HTTPS do ReceitaWS está com certificado desatualizado pelo que parece.
Register e login feitos pelo Swagger. Para fazer a autenticação e POST do CNPJ deve ser feito pelo Insomnia ou POSTMAN:
https://localhost:7076/api/empresas/ Numero cnpj pelo header
e colocar o Token Bearer depois de ter feito para autenticar e conseguir fazer o POST.
