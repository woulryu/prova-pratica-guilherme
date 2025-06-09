# prova-pratica-guilherme

Este projeto simula um sistema básico de gestão de pedidos para uma loja virtual, desenvolvido em C# com foco em boas práticas de programação.

##  Funcionalidades

- Cadastro de produtos com nome, preço e categoria.
- Cadastro de clientes com nome, email e CPF.
- Criação de pedidos vinculados a um cliente.
- Adição de múltiplos itens por pedido.
- Cálculo automático do valor total de cada pedido.
- Aplicação de descontos com base na categoria dos produtos e na quantidade comprada.
- Exibição de relatório com todos os detalhes do pedido.

##  Tecnologias e práticas aplicadas

- Linguagem: **C#**
- Design Patterns utilizados:
  - **Strategy**: para aplicar diferentes regras de desconto.
  - **Factory Method**: para encapsular a criação dos pedidos.
- Princípios do **SOLID** aplicados:
  - **S** (Responsabilidade Única): cada classe tem uma responsabilidade clara.
  - **O** (Aberto/Fechado): é possível adicionar novas estratégias de desconto sem modificar as classes existentes.
  - **L**, **I** e **D** também são considerados ao usar interfaces, injeção e abstração de lógica.