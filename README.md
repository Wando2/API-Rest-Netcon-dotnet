

# API-Rest-Netcon-dotnet

A API fornece um serviço simples de conversão de distâncias entre anos-luz e quilômetros. Ela permite que os usuários convertam distâncias de anos-luz para quilômetros e vice-versa através de um método GET.

## Recursos

- **Swagger**: Interface interativa para explorar e testar a API.
  - Acesse em `https://localhost:[porta]/swagger`.

- **Testes Unitários (NUnit)**

## Parâmetros da URL

- `value` (float): Valor a ser convertido
- `unit` (string): Unidade de medida da distância

## Exemplo de Uso

- **URL de Requisição**:
   ```
   https://localhost:7119/Conversor?value=10&unit=anos-luz
   ```

- **Resultado**:

   ```json
   {
     "date": "2023-10-26T10:29:36",
     "statusCode": 200,
     "errorMessage": null,
     "value": 94610000000000
   }
   ```

## Como Compilar e Executar

1. Abra o diretório "API Rest Netcon dotnet".

2. Execute:
   ```bash
   dotnet run
   ```

3. Acesse a URL do Swagger:
   ```
   https://localhost:[porta]/swagger
   ```
