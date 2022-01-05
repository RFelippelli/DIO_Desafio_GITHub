#Seu objetivo é criar um programa que receba como entrada dois números naturais,
#INÍCIO e FIM, e exibe os números primos que existem no intervalo fechado
#[ INÍCIO..FIM ].
#Ao final, o programa também deve exibir a quantidade de primos encontrados
#no intervalo.

n1 = int(input())
n2 = int(input())

primos=[]
i = 0

for x in range(n1,n2+1):
    cont=0

    for y in range(1,x+1):
        if x%y==0:
            cont+=1
    if cont<=2 and cont != 1:
        primos.append(x)

qtd = len(primos)

while i < len(primos):
    print(primos[i])
    i+=1
print(f'primos: {qtd}')
