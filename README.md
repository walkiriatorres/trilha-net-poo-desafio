# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## Minha implementação:
Foram inseridas à  classe Smartphone propriedades private - Modelo, Imei, Memoria.

Enquanto às classes filhas - Iphone e Nokia - foram adicionadas propriedades MemoriaDisponivel e AplicativosInstalados, a primeira possui o valor inicial de memória da classe base, enquanto o segundo é instanciado como uma lista vazia. Estas propriedades serão utilizadas pelo método InstalarAplicativo, responsável por manipulá-las. Já o acesso a estes dados serão permitido via método Get.

Sobrescrevi o método InstalarAplicativo que recebe o tamanho, além do nome do app a ser intalado. Este método fará uma verificação de disponibilidade de memória para realizar o download. Havendo espaço disponível suficiente, é executada ação: o nome do app é inserido na lista de aplicativos instalados e seu tamanho deduzido da memória disponível. Caso não haja disponibilidade, é informado ao cliente a quantidade de memória que o mesmo precisa liberar para realizar o download. Há ainda o tratamento de exceção genérica, informando ao cliente que houve um erro ao instalar o aplicativo.
