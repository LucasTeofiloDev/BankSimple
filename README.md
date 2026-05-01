# BankSimple

## Descrição

BankSimple é uma aplicação de console desenvolvida em C# que simula operações básicas de uma conta bancária. O sistema permite criar uma conta com ou sem depósito inicial e realizar operações como depósito, saque e alteração de dados cadastrais.

O projeto foi construído com foco em conceitos fundamentais de programação orientada a objetos, como encapsulamento, construtores sobrecarregados e validação de dados.

---

## Funcionalidades

* Criação de conta bancária

  * Com depósito inicial
  * Sem depósito inicial
* Depósito de valores
* Saque com taxa fixa de R$ 5.00
* Alteração do nome do titular
* Exibição dos dados da conta
* Menu interativo via console

---

## Estrutura do Projeto

### Program.cs

Responsável por:

* Interação com o usuário
* Controle de fluxo do sistema
* Menu de operações

### Conta.cs

Responsável por:

* Representar a entidade Conta
* Regras de negócio
* Operações financeiras

---

## Conceitos Aplicados

* Programação Orientada a Objetos (POO)
* Encapsulamento com propriedades
* Construtores sobrecarregados
* Validação de entrada de dados
* Estruturas de controle (`if`, `switch`, `do-while`)
* Manipulação de cultura para parsing (`CultureInfo.InvariantCulture`)

---

## Regras de Negócio

* Depósitos só são aceitos se o valor for maior que zero
* Saques:

  * Devem ser maiores que zero
  * Possuem taxa fixa de R$ 5.00
* Nome do titular:

  * Deve ter mais de 1 caractere

---

## Exemplo de Uso

1. O usuário informa:

   * Número da conta
   * Nome do titular
   * Se haverá depósito inicial

2. O sistema inicia e exibe o menu:

```
1 - Deposito
2 - Saque
3 - Alterar Dado Cadastral
4 - Sair
```

3. O usuário interage até escolher sair

---

## Melhorias Futuras

* Validação robusta de entrada (evitar `Parse` direto)
* Implementação de tratamento de exceções
* Separação de camadas (Domain, Application)
* Persistência de dados (arquivo ou banco de dados)
* Interface gráfica (GUI ou Web)
* Autenticação de usuário

---

## Observações Técnicas

* O sistema utiliza `CultureInfo.InvariantCulture` para evitar problemas com formatação numérica
* A classe `Conta` mantém o saldo como atributo privado, garantindo encapsulamento
* O método `ToString()` foi sobrescrito para facilitar a exibição dos dados

---

## Objetivo Educacional

Este projeto tem como objetivo consolidar:

* Lógica de programação
* Estruturação de código
* Modelagem de entidades
* Boas práticas iniciais em C#

---

## Como Executar

1. Abrir o projeto no Visual Studio
2. Compilar a solução
3. Executar o programa
4. Interagir via terminal

---

## Autor

Desenvolvido para fins de aprendizado em desenvolvimento backend com C#.
