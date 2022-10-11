Algoritmo "semnome"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 10/10/2022
Var
// Seção de Declarações das variáveis 
   numeroCandidato1: inteiro
   numeroCandidato2: inteiro
   numeroCandidato3: inteiro
   nomeCandidato1: caractere
   nomeCandidato2: caractere
   nomeCandidato3: caractere
   contCandidato1: inteiro
   contCandidato2: inteiro
   contCandidato3: inteiro
   contBranco: inteiro
   contNulo: inteiro
   i: inteiro
   voto: inteiro
   resposta: caracter
   resposta2: caracter

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 

   contCandidato1 <- 0
   contCandidato2 <- 0
   contCandidato3 <- 0
   contNulo <- 0
   contBranco <- 0

   //Solicita o numero e o nome do candidato 1
   escreva("Informe o nome do cadidato 1: ")
   leia(nomeCandidato1)
   
   escreva("Informe o numero do cadidato 1: ")
   leia(numeroCandidato1)
   //Solicita o numero e o nome do candidato 2
   escreva("Informe o nome do cadidato 2: ")
   leia(nomeCandidato2)
   
   escreva("Informe o numero do cadidato 2: ")
   leia(numeroCandidato2)
   //Solicita o numero e o nome do candidato 3
   escreva("Informe o nome do cadidato 3: ")
   leia(nomeCandidato3)

   escreva("Informe o numero do cadidato 3: ")
   leia(numeroCandidato3)
   
   limpatela
   
   escreval("============ZERÉZIMA============")
   escreval(numeroCandidato1, " - ", nomeCandidato1, ":")
   escreval(numeroCandidato2, " - ", nomeCandidato2, ":")
   escreval(numeroCandidato3, " - ", nomeCandidato3, ":")
   escreval("0-Branco", contBranco)
   escreval("Votos Nulos", contNulo)
   escreval("")
   escreval("iniciando a eleição.")
   
   //timer(500)
   
   //para i de 0 ate 10 passo 1 faca
   //escreva(".")
   
   //fimpara
   
   timer(0)
   
   limpatela
   
   repita
    repita
     escreva("Informe o número do candidato: ")
     leia(voto)
     escreva(".")
     
     escolha voto
     caso numeroCandidato1
          escreval(numeroCandidato1," - ",nomeCandidato1)
          contCandidato1 <- contCandidato1 + 1
     caso numeroCandidato2
          escreval(numeroCandidato2," - ",nomeCandidato2)
          contCandidato2 <- contCandidato2 + 1
     caso numeroCandidato3
          escreval(numeroCandidato3," - ",nomeCandidato3)
          contCandidato3 <- contCandidato3 + 1
     caso 0
          escreval("0 - voto em branco")
          contBranco <- contBranco + 1
     outrocaso
          escreval("Voto em nulo")
          contNulo <- contNulo + 1
     fimescolha
     
     escreva("")
     escreva("Deseja confirmar o seu voto? (s) ou (n)")
     leia(resposta)
    ate(resposta <> "n")
     escreva("Ainda há mais eleitores para votar? (s) ou (n)")
     leia(resposta2)
    ate(resposta2 <> "s")
    

   escreval("============ZERÉZIMA============")
   escreval(nomeCandidato1, ":", contCandidato1)
   escreval(nomeCandidato2, ":", contCandidato2)
   escreval(nomeCandidato3, ":", contCandidato3)
   escreval("0-Branco", contBranco)
   escreval("Votos Nulos", contNulo)
Fimalgoritmo
