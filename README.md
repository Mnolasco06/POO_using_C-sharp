# Simulação de Smartphones em C#

Este projeto é uma implementação simples de um sistema de smartphones utilizando Programação Orientada a Objetos (POO) em C#. Ele inclui dois tipos de smartphones (Nokia e Iphone), que herdam de uma classe base `Smartphone`. Através deste exemplo, são explorados conceitos como herança, abstração, polimorfismo e encapsulamento.

## Funcionalidades

- **Ligar:** Simula uma ligação a partir de um smartphone.
- **Receber Ligação:** Simula o recebimento de uma ligação.
- **Instalar Aplicativo:** Permite ao usuário instalar aplicativos nos smartphones, simulando o processo de instalação.

### Estrutura de Classes

- **Smartphone (classe abstrata):** Classe base que define os métodos comuns a todos os smartphones, como ligar, receber ligação e instalar aplicativos. A classe `Smartphone` contém os seguintes métodos:
  - `Ligar()`: Exibe uma mensagem simulando uma chamada.
  - `ReceberLigacao()`: Exibe uma mensagem simulando o recebimento de uma ligação.
  - `InstalarAplicativo()`: Método abstrato implementado nas classes filhas, que simula a instalação de um aplicativo.

- **Nokia e Iphone:** São classes derivadas de `Smartphone` que implementam o método `InstalarAplicativo()` de acordo com o modelo específico do telefone.
