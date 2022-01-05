#Como Ramón não tem um controle adequado para atualizar o valor da
#dívida de acordo com os valores pagos, pediu sua ajuda para construir
#um programa que receba como entrada o valor da dívida e o valor que se
#comprometeu a pagar mensalmente, o programa deve exibir, mês a mês, o
#valor da dívida antes e depois do pagamento.

divida = int(input())
parcela = int(input())
pgto = (1)
if (divida)-(parcela)<(0):
    print('pagamento:', (pgto))
    print('antes =', (divida))
    print('depois =', (parcela)-(parcela))
    print('-----')
else:
    while (divida)-(parcela)>(0):
        print('pagamento:', (pgto))
        print('antes =', (divida))
        print('depois =', (divida)-(parcela))
        print('-----')
        pgto = (pgto)+(1)
        divida = (divida)-(parcela)
    if (divida)-(parcela)==(0):
        print('pagamento:', (pgto))
        print('antes =', (divida))
        print('depois =', (divida)-(parcela))
        print('-----')
    if(divida)<(parcela):
        print('pagamento:', (pgto))
        print('antes =', (divida))
        print('depois =', (divida)-(divida))
        print('-----')
