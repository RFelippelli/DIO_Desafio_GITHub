#######PROBLEMA##########

#"Não tem jeito!", Julius repete para si mesmo que o trânsito da cidade grande
#é o maior vilão de seus dias, fazendo com que gaste muito tempo no percurso entre sua casa
#e o primeiro emprego, entre seu primeiro emprego e o segundo emprego, e entre seu segundo
#emprego até o regresso a casa. Pois é, Julius tem dois empregos!

#Julius é ótimo na realização de contas, mas como está sempre com pressa,
#nunca teve tempo para calcular o tempo total gasto no trânsito, desde o momento que sai de casa
#até o momento que regressa. Seu relógio é antigo, não possibilitando cronometrar um percurso,
#pausar e continuar a cronometragem no próximo, por isso só sabe o tempo gasto entre os percursos
#isoladamente, mas não o tempo gasto nos percursos somados. Até ofereceram um novo relógio com
#desconto para Julius, para ele respondeu ao vendedor que
#"não comprar o relógio daria um desconto maior".

#Você, como um bom amigo, se ofereceu para criar um programa que recebe como entrada os
#tempos dos três percursos de Julius
#(de casa até o primeiro emprego, do primeiro emprego até o segundo e do segundo até a casa) e
#exibe o tempo total consumido.
#Não se esqueça que os três tempos serão dados em minutos.

####SOLUÇÃO#####

T1 = int(input())
T2 = int(input())
T3 = int(input())
TT = (T1 + T2 + T3)
print(TT, 'minutos')
