#Escreva um programa que receba como entrada dois números inteiros quaisquer A e B
#e exiba todas as tabuadas existentes no intervalo fechado crescente [ A..B ].

A = int(input())
B = int(input())

if (A > B):
  print('Nenhuma tabuada no intervalo!')
else:
  for intervalo in range(A, B + 1): # 2 até 3 = 2
    for i in range(1, 11): # 1 a 10
      print(f'{intervalo} x {i} = {intervalo * i}')
    print('----------')
