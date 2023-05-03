# Jogo de Xadrez em C#
Este é um jogo de xadrez em C# que pode ser executado no console. Ele inclui as jogadas especiais Roque pequeno, Roque grande, En Passant e Promoção do peão para dama.
## Como executar o código
1. Certifique-se de ter o Visual Studio ou o Visual Studio Code instalado em seu computador.
2. Faça o download ou clone o repositório do ChessGame.
3. Abra o arquivo do projeto em seu ambiente de desenvolvimento.
4. Compile e execute o código.
## Como contribuir
Você é bem-vindo para contribuir para este projeto. Aqui estão alguns passos para começar:

1. Faça um fork do repositório.
2. Crie um branch para sua contribuição: git checkout -b sua-branch.
3. Faça suas alterações e faça commit das mesmas: git commit -m "sua mensagem de commit".
4. Envie seu branch para o repositório remoto: git push origin sua-branch.
5. Abra um pull request.

## Como jogar
Execute o programa no console.
O jogo começa com as peças na posição inicial do xadrez.
Os jogadores alternam a vez movendo uma peça por vez.
O objetivo do jogo é dar xeque-mate no rei do oponente.
O jogo termina quando um dos reis é dado xeque-mate ou quando ocorre empate.
As jogadas especiais podem ser feitas conforme as regras do xadrez.
## Jogadas Especiais
### Roque pequeno
O roque pequeno só pode ser feito se as seguintes condições forem atendidas:

O rei não pode ter sido movido ainda;
A torre do lado direito não pode ter sido movida ainda;
Não pode haver nenhuma peça entre o rei e a torre do lado direito;
O rei não pode estar em xeque;
Nenhum dos quadrados que o rei passa ou que ele termina a jogada pode estar em xeque.
Para fazer o roque pequeno, mova o rei duas casas em direção à torre do lado direito e, em seguida, mova a torre para o lado do rei.

### Roque grande
O roque grande só pode ser feito se as seguintes condições forem atendidas:

O rei não pode ter sido movido ainda;
A torre do lado esquerdo não pode ter sido movida ainda;
Não pode haver nenhuma peça entre o rei e a torre do lado esquerdo;
O rei não pode estar em xeque;
Nenhum dos quadrados que o rei passa ou que ele termina a jogada pode estar em xeque.
Para fazer o roque grande, mova o rei duas casas em direção à torre do lado esquerdo e, em seguida, mova a torre para o lado do rei.

### En Passant
O en passant só pode ser feito se as seguintes condições forem atendidas:

O peão do oponente avançou duas casas na jogada anterior;
O peão do oponente agora está na mesma fileira do seu peão;
O seu peão está ao lado do peão do oponente.
Para fazer o en passant, mova o seu peão para a casa que o peão do oponente saltou, capturando-o.

Promoção do Peão para Dama
Se um peão alcança a última fila do tabuleiro, ele pode ser promovido a qualquer peça, exceto o rei. Geralmente, os jogadores escolhem promover o peão a uma dama.

Para fazer a promoção do peão para dama, mova o peão para a última fila do tabuleiro e substitua-o por uma dama.

## Sobre o código
O código foi desenvolvido em C# e utiliza o padrão de orientação a objetos para representar as peças e o tabuleiro. As jogadas especiais foram implementadas de acordo com as regras do xadrez.
