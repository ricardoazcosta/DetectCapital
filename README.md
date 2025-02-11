# Detecção de Uso de Maiúsculas

Este projeto em C# implementa uma função para detectar se uma palavra segue as regras de uso de maiúsculas definidas pelo LeetCode [[https://leetcode.com/problems/detect-capital-use/](https://leetcode.com/problems/detect-capital-use/)].

## Descrição do Problema

Dado uma palavra, precisamos determinar se o uso de maiúsculas está correto. Uma palavra é considerada válida se:

1. Todas as letras são maiúsculas (ex: "USA").
2. Todas as letras são minúsculas (ex: "flag").
3. Apenas a primeira letra é maiúscula (ex: "Flag").

## Solução

A solução implementada em C# itera sobre a palavra e conta o número de letras maiúsculas. Em seguida, verifica se a contagem de maiúsculas se encaixa em um dos três casos válidos.

## Como Executar

1. **Pré-requisitos:**
   - [.NET SDK](https://dotnet.microsoft.com/en-us/download) instalado.
   - Visual Studio Code (VS Code) instalado.

2. **Passos:**
   - Clone este repositório: `git clone https://github.com/seu-usuario/seu-repositorio.git` (substitua pelo seu link)
   - Abra o projeto no VS Code.
   - Abra o terminal no VS Code (Visualizar -> Terminal).
   - Execute o comando: `dotnet run`

## Estrutura do Código

- `Solution.cs`: Contém a classe `Solution` com o método `DetectCapitalUse` que implementa a lógica principal.
- `Program.cs`: Contém a classe `Program` com o método `Main` que executa os testes.

## Testes

O código inclui testes no método `Main` para verificar a funcionalidade da solução com diferentes entradas.

## Melhorias

- Adicionar mais testes unitários para cobrir casos extremos e garantir a robustez da solução.
- Otimizar a solução para evitar alocações de memória desnecessárias, se possível.

## Autor

Ricardo Costa

## Licença

Este projeto está sob a licença MIT. (Opcional)
