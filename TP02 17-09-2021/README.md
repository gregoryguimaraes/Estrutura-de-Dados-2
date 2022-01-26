# EDT2-Atividade-17-09-2021

Durante uma semana (de segunda à sábado), uma entidade fará um ciclo de eventos (um evento a cada dia).

Cada um desses eventos terá um limite de participantes.

Um participante poderá estar em, no máximo, dois eventos ao longo da semana.

Utilize o diagrama de classes abaixo para desenvolver o projeto, considerando o seletor de opções descrito no fim deste documento:

------------------------------------------
| Participante                           |
|----------------------------------------|
| - email: string                        |
| - nome: string                         |
|----------------------------------------|
| + podeInscrever(Eventos e): bool       |
| + Equals(): bool - override para email |
| + toString(): string - override (*)    |
------------------------------------------
(*) Concatenação dos atributos + '\n'

-----------------------------------------------------
| Evento                                            | 
|---------------------------------------------------|
| - id: int                                         |
| - descricao: string                               |
| - qtdeMaxParticipantes: int;                      |
| - participantes: Participante[]                   |
|---------------------------------------------------|
| + inscreverParticipante(Participante p): int (**) |
| + qtdeParticipantes(): int                        |
| + listaParticipantes(): string                    |
| + Equals(): bool - override para id               |
| + toString(): string - override (***)             |
-----------------------------------------------------
(**) Status da operação:
     0 - Inscrição efetuada
     1 - Evento lotado
     2 - Excedido limite de inscrições para o participante 
(***) Concatenação dos atributos + '\n' 

-----------------------------------------------------------
| Eventos                                                 |
|---------------------------------------------------------|
| - osEventos: Evento[]                                   |
|---------------------------------------------------------|
| + adicionarEvento(Evento e)                             |
| + pesquisarParticipante (Participante p): string (****) |
| + qtdeParticipantes(): int                              |
| + listaEventos(): string (*****)                        |
-----------------------------------------------------------
(****)  Se encontrado, deverá retornar uma string contendo 
        seu nome e em quais eventos o participante está 
        inscrito. Não encontrando, retornar uma string vazia
(*****) Concatenar dados básicos de cada evento + 
        qtde participantes de cada evento

Seletor:

0. Sair
1. Adicionar evento (escolher o dia, onde 1=SEG, 2=TER, ..., 6=SAB)
2. Pesquisar evento (deverá retornar os dados do evento + participantes)
3. Listar eventos (informar dados básicos do evento + qtde participantes)
4. Adicionar participante (retornando o status da operação com mensagem)
5. Pesquisar participante (utilizar o e-mail como critério de pesquisa)
6. Informar quantidade total de participantes nos eventos da semana
