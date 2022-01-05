#####PROBLEMA#####
#Sua tarefa é construir um programa que receba como entrada um número
#natural N (0 <= N <= 10) e exibir a tabuada de N de 1 até 10.

####SOLUÇÃO####
cont = 1
n = int(input(''))
while cont<=10:
    print((n),'x',(cont),'=',(n*cont))
    cont = (cont) + 1
    
