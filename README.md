DESAFIO DE CÓDIGO - CRIANDO UM SISTEMA DE ESTACIONAMETO COM C#
www.dio.me

🎯 Desafio de Projeto
Foram utilizados os conhecimentos adquiridos no módulo de fundamentos da trilha .NET da DIO para construir um sistema de gerenciamento de estacionamento. 🚗💨

📜 Contexto
O objetivo foi criar um sistema para gerenciar veículos estacionados, com operações como adicionar um veículo, remover um veículo e listar veículos. O sistema deve calcular o valor cobrado pelo estacionamento com base em uma tarifa inicial e uma tarifa por hora. 💵⏳

🛠️ Proposta
Construir uma classe chamada Estacionamento, conforme o diagrama de classe fornecido:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)
A classe deve conter três variáveis:
    - precoInicial: Tipo decimal. O preço cobrado para estacionar o veículo. 💲
    - precoPorHora: Tipo decimal. O preço por hora que o veículo permanecer no estacionamento. ⏱️
    - veiculos: Lista de string que armazena as placas dos veículos estacionados. 🚙
A classe deve implementar três métodos:
    - AdicionarVeiculo: Adiciona um veículo ao estacionamento a partir da placa digitada pelo usuário. 📝
    - RemoverVeiculo: Remove um veículo do estacionamento após verificar sua existência e calcular o valor total baseado nas horas estacionadas. 🚫
    - ListarVeiculos: Lista todos os veículos atualmente estacionados. Se não houver nenhum veículo, exibe a mensagem "Não há veículos estacionados". 📋
Além disso, deve haver um menu interativo com as seguintes opções:
    - Cadastrar veículo 🚗
    - Remover veículo 🚫
    - Listar veículos 📜
    - Encerrar ❌

🛠️ Solução
🔧 Código Base
O código base inicial continha a implementação parcial dos métodos e a estrutura de um menu para o sistema de estacionamento. As principais funcionalidades estavam presentes, mas algumas melhorias eram necessárias para tornar o sistema amigável ao usuário.

🚀 Melhorias Realizadas
- Adição de Veículos:
  1. Loop de Adição: Implementado um loop para permitir ao usuário adicionar vários veículos até que ele escolha parar. A validação garante que a placa não seja nula ou apenas espaços em branco. 🔄
  2. Feedback ao Usuário: Mensagens de confirmação são exibidas após a adição de um veículo. 👍
  Remoção de Veículos:
  3. Loop de Remoção: Implementado um loop para permitir ao usuário remover vários veículos até que ele escolha parar. O código agora trata exceções de entrada para garantir que a quantidade de horas seja um número válido. 🔄
  4. Verificação de Existência: Melhorada a verificação da existência do veículo, considerando a comparação de placas de forma insensível a maiúsculas e minúsculas. ✔️

- Listagem de Veículos:
  1. Limpeza de Tela: Adicionada limpeza da tela antes de listar os veículos para melhorar a legibilidade. 🧹
  Verificação de Lista: Se não houver veículos, uma mensagem adequada é exibida ao usuário. 🚫
  Menu Interativo:
- Limpeza de Tela: Após cada operação, a tela é limpa para garantir que o menu seja exibido claramente e que o usuário veja apenas a informação relevante. 🧹
  
- Continuidade: Adicionada lógica para continuar com a operação de adicionar ou remover veículos até que o usuário decida parar. 🔄